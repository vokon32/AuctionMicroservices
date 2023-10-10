FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app
EXPOSE 80

COPY AuctionMicro.sln AuctionMicro.sln
COPY AuctionMicro/AuctionMicro.csproj AuctionMicro/AuctionMicro.csproj
COPY SearchService/SearchService.csproj SearchService/SearchService.csproj
COPY src/GatewayService/GatewayService.csproj src/GatewayService/GatewayService.csproj
COPY Contracts/Contracts.csproj Contracts/Contracts.csproj
COPY src/identityservice/IdentityService.csproj src/identityservice/IdentityService.csproj

RUN dotnet restore AuctionMicro.sln

COPY src/identityservice src/IdentityService
WORKDIR /app/src/IdentityService
RUN dotnet publish -c Release -o /app/src/out

FROM mcr.microsoft.com/dotnet/aspnet:7.0 
WORKDIR /app
COPY --from=build /app/src/out .
ENTRYPOINT ["dotnet", "IdentityService.dll"]