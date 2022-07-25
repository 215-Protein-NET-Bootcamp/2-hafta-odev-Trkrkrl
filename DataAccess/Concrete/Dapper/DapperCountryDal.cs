using Dapper;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Dapper
{
    public class DapperCountryDal:ICountryDal
    {
        private readonly DapperDbContext _dapperDbContext;

        public DapperCountryDal(DapperDbContext dapperDbContext)
        {
            _dapperDbContext = dapperDbContext;
        }

        public async void Add(Country country)
        {
            var query= "INSERT INTO \"Countries\" (\"Name\",\"Continent\",\"Currency\",\"IsDeleted\")"+
                "VALUES(@Name,@Continent,@Currency,@IsDeleted)";
            var parameters = new DynamicParameters();

            parameters.Add("Name",country.Name);
            parameters.Add("Continent", country.Continent);
            parameters.Add("Currency", country.Currency);
            parameters.Add("IsDeleted", country.IsDeleted);

            using (var connection = _dapperDbContext.CreateConnection())
            {
                connection.Open();
                await connection.ExecuteAsync(query, parameters);
            }

        }

        public void Delete(Country country)
        {
            throw new NotImplementedException();
        }
        public void Update(Country country)
        {
            throw new NotImplementedException();
        }

        public Country Get(Expression<Func<Country, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Country> GetAll(Expression<Func<Country, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        
    }
}
