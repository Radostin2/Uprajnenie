using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Net.Http.Headers;
using Data.Model;

namespace Data
{
    public class CarContext : DbContext
    {
        public CarContext() : base("name=CarContext")
        {

        }
        public DbSet<Car> Car { get; set; }
    }
}
