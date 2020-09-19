using Microsoft.EntityFrameworkCore;
using NetWebApi.Models;

namespace NetWebApi.Data
{
	public class NetWebApiContext : DbContext
	{
        public NetWebApiContext(DbContextOptions<NetWebApiContext> opt) 
			: base(opt)
        {

        }

        public DbSet<Command> Commands { get; set; }
	}
}
