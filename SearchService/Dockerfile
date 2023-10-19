FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app
EXPOSE 80

COPY AuctionMicro.sln AuctionMicro.sln
COPY AuctionMicro/AuctionMicro.csproj AuctionMicro/AuctionMicro.csproj
COPY SearchService/SearchService.csproj SearchService/SearchService.csproj
COPY src/GatewayService/GatewayService.csproj src/GatewayService/GatewayService.csproj
COPY src/BiddingService/BiddingService.csproj src/BiddingService/BiddingService.csproj
COPY src/NotificationService/NotificationService.csproj src/NotificationService/NotificationService.csproj
COPY Contracts/Contracts.csproj Contracts/Contracts.csproj
COPY src/identityservice/IdentityService.csproj src/identityservice/IdentityService.csproj

RUN dotnet restore AuctionMicro.sln

COPY SearchService src/SearchService
COPY Contracts src/Contracts 
WORKDIR /app/src/SearchService
RUN dotnet publish -c Release -o /app/src/out

FROM mcr.microsoft.com/dotnet/aspnet:7.0 
WORKDIR /app
COPY --from=build /app/src/out .
ENTRYPOINT ["dotnet", "SearchService.dll"]