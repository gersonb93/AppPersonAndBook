using Microsoft.EntityFrameworkCore;

namespace RestWithASPNETUdemy.Model.Contex
{
    public class DbContex
    {
        private DbContextOptions<MySQLContext> options;

        public DbContex(DbContextOptions<MySQLContext> options)
        {
            this.options = options;
        }
    }
}