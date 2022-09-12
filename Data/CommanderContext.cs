#nullable disable
using dotnetTest.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetTest.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {
            
        }

        public DbSet<Command> Commands { get; set; }
    }
}