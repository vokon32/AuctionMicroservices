using AuctionMicro.Models;
using Microsoft.EntityFrameworkCore;

namespace AuctionMicro.Data
{
    public class AuctionDbContext : DbContext
    {
        public AuctionDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Auction> Auctions { get; set; }
    }
}