using System.Data.Entity;
using elkirko.Generics.Entities;


namespace elkirko.Generics.Data
{
    public class StorageAppDBContext : DbContext 
    {
        public StorageAppDBContext() : base("name=EmployeeConnectionstring")
        {
            
        }
        public DbSet <Employee> Employees {get; set;}
        public DbSet <Organization> Organizations {get ; set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        
    }
}
