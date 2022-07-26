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

        public async void Delete(Country country)//dikkat buradaki methodlar async olmalı ki execute async ler calissin
        {
          /*  var deleteQuery = "Delete  From \"Countries\"  WHERE (\"Id\")" +
                "VALUES(@Id)";


            var parameters = new DynamicParameters();

            parameters.Add("Id", country.Id);
            */
            using (var connection = _dapperDbContext.CreateConnection())
            {
                connection.Open();
                var deleteQuery = "DELETE FROM \"Countries\" WHERE \"Id\" = @Id";
                await connection.ExecuteAsync(deleteQuery, new { Id = country.Id });
            }
            
            
        }
        public async Task Update(Country country)
        {
            //update date e gerek var mı-veya updated diye satatus göstermesine
                var updateQuery = "UPDATE \"Countries\" (\"Name\",\"Continent\",\"Currency\")" +
                "VALUES(@Name,@Continent,@Currency)";


                var parameters = new DynamicParameters();

                parameters.Add("Name", country.Name);
                parameters.Add("Continent", country.Continent);
                parameters.Add("Currency", country.Currency);
                

                using (var connection = _dapperDbContext.CreateConnection())
                {
                    connection.Open();
                    await connection.ExecuteAsync(updateQuery, parameters);
                }



            
            //update methodunu daha yapmadık-içerisini yapcaz- addmi ne gelecekse bulacaz 
            
        }

      

        public async Task<List<Country>> GetAllAsync()
        {
            var sql = "SELECT * FROM public.\"Countries\"";
            using (var connection = _dapperDbContext.CreateConnection())
            {
                connection.Open();
                var result = await connection.QueryAsync<Country>(sql);
                return result.ToList();
            }
        }

        public async Task<Country> GetByIdAsync(int Id)
        {
            var query = "SELECT * FROM public.\"Countries\" WHERE \"Id\" = @Id";
            using (var connection = _dapperDbContext.CreateConnection())
            {
                connection.Open();
                var result = await connection.QueryFirstAsync<Country>(query, new { Id });
                return result;
            }
        }
    }
}
