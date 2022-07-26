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
    public class DapperDepartmentDal : IDepartmentDal
    {
        private readonly DapperDbContext _dapperDbContext;

        public DapperDepartmentDal(DapperDbContext dapperDbContext)
        {
            _dapperDbContext = dapperDbContext;
        }

        public async void Add(Department department)
        {
            var query = "INSERT INTO \"Departments\" (\"DepartmentName\",\"CountryId\",\"IsDeleted\")" +
                "VALUES(@DepartmentName,@CountryId,@IsDeleted)";
            var parameters = new DynamicParameters();

            parameters.Add("DepartmentName", department.DepartmentName);
            parameters.Add("IsDeleted", department.IsDeleted);
            parameters.Add("CountryId", department.CountryId);

            using (var connection = _dapperDbContext.CreateConnection())
            {
                connection.Open();
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void Delete(Department department)
        {
            using (var connection = _dapperDbContext.CreateConnection())
            {
                connection.Open();
                var deleteQuery = "DELETE FROM \"Departments\" WHERE \"Id\" = @Id";
                await connection.ExecuteAsync(deleteQuery, new { Id = department.DepartmentId });
            }
        }
        public async Task Update(Department department)
        {
            var updateQuery = "UPDATE \"Departments \" (\"DepartmentName\",\"CountryId\",\"IsDeleted\")" +
               "VALUES(@DepartmentName,@CountryId,@IsDeleted)";


            var parameters = new DynamicParameters();

            parameters.Add("DepartmentName", department.DepartmentName);
            parameters.Add("IsDeleted", department.IsDeleted);
            parameters.Add("CountryId", department.CountryId);


            using (var connection = _dapperDbContext.CreateConnection())
            {
                connection.Open();
                await connection.ExecuteAsync(updateQuery, parameters);
            }
        }



        public async Task<List<Department>> GetAllAsync()
        {
            var sql = "SELECT * FROM public.\"Departments\"";
            using (var connection = _dapperDbContext.CreateConnection())
            {
                connection.Open();
                var result = await connection.QueryAsync<Department>(sql);
                return result.ToList();
            }
        }

        public async Task<Department> GetByIdAsync(int DepartmentId)
        {
            var query = "SELECT * FROM public.\"Departments\" WHERE \"DepartmentId\" = @DepartmentId";
            using (var connection = _dapperDbContext.CreateConnection())
            {
                connection.Open();
                var result = await connection.QueryFirstAsync<Department>(query, new { DepartmentId });
                return result;
            }
        }

       
    }
}
