using Microsoft.EntityFrameworkCore;
using System;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Persistencia
{
    public class ApplicationContext : DbContext
    {

        public DbSet<Aspirante> Aspirantes { get; set; }

        public ApplicationContext()
        {
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            :base(options)
        {
        }



    }
}
