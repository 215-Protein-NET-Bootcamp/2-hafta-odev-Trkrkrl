using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Context
{
    public class EfCoreDbContext:DbContext
    {

        //aşağıdaki bu kodu hocadan almıştım-fakata data-concrete ef teki dalları kızdırıyor-
        //public parametlerless bişey olmasın diyor
       /* public EfCoreDbContext(DbContextOptions<EfCoreDbContext> options) : base(options)
        {

        }*/
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        //--Burada database ile buradaki nesnelerimizin bağlantısı yapılır
        //dbset içerisinde yazan bizimki- sağdaki ise databasedeki tablo adı
        //yani yazarken dikkat et
        public DbSet<Employee> Employee{ get; set; }
        public DbSet<Folder> Folder { get; set; }










    }
}
