using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WFAPersonelTakibi.Personel;

namespace WFAPersonelTakibi.Context
{
    public class MyContext : DbContext
    {
        public MyContext()
        {
            Database.Connection.ConnectionString = "Server=.; database=PersonelTakibi; uid = sa; pwd = 123";
        }


        public virtual DbSet<Employee> Employees { get; set; }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Employee>()
        //        .HasKey(p => p.EmployeeID)
        //        .ToTable("Employees");
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
