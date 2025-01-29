using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace pr78.DataModel
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=ModelEF")
        {
        }

        public virtual DbSet<Prognosi> Prognosis { get; set; }
        public virtual DbSet<Type_of_weather> Type_of_weather { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
