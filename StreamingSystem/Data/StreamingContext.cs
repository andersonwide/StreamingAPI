using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Data
{
    public class StreamingContext : DbContext
    {
        public StreamingContext(DbContextOptions<StreamingContext> opt) : base(opt)
        {

        }

        public DbSet<Streaming> Filmes { get; set; }

    }
}