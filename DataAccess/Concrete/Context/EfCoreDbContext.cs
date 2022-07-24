using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Context
{
    public class EfCoreDbContext : DbContext
    {
        //aşağıdaki bu kodu hocadan almıştım-fakata data-concrete ef teki dalları kızdırıyor-
        //public parametlerless bişey olmasın diyor
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {//hocanın kodunda startupcsten alıyordu-  ama benim yapıma uymadı-
            //configuraiton managerle appsettingsten gerekenleri cekip burada if else ile secim sagladım
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../WebAPI"));
            configurationManager.AddJsonFile("appsettings.json");
           

            var dbType = configurationManager.GetConnectionString("DbType");
            if(dbType == "SQL")
            {
                optionsBuilder.UseSqlServer(configurationManager.GetConnectionString( "DefaultConnection"));
            }else if(dbType == "PostgreSQL")
            {
                optionsBuilder.UseNpgsql(configurationManager.GetConnectionString("PostgreSqlConnection"));
            }


        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        //--Burada database ile buradaki nesnelerimizin bağlantısı yapılır
        //dbset içerisinde yazan bizimki- sağdaki ise databasedeki tablo adı
        //yani yazarken dikkat et
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Folder> Folders { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Country> Countries { get; set; }



        //context le ilgili -onconfiguring ve on model creating https://www.entityframeworktutorial.net/efcore/entity-framework-core-dbcontext.aspx
        // onmodelcreating method allows us to configure the model using ModelBuilder -Fluent API.





    }
}
