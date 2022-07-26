using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CountryManager : ICountryService
    {
        ICountryDal _countryDal;

        public CountryManager(ICountryDal countryDal)
        {
            _countryDal = countryDal;
        }

        public IResult Add(Country country)
        {
            try
            {
                _countryDal.Add(country);
                return new SuccessResult("Country Added Successfully");
            }
            catch (Exception ex)
            {

                throw new Exception("Country Adding Error");
            }
        }

        public IResult Delete(Country country)
        {
            _countryDal.Delete(country);
            return new Result(true, "Country Deleted");
        }
        public IResult Update(Country country)
        {
            _countryDal.Update(country);
            return new Result(true);
        }

        public IDataResult<List<Country>> GetAll()
        {
            return new DataResult<List<Country>>(_countryDal.GetAllAsync().Result, true, "Countries Listed");
        }

        public  IDataResult<Country> GetById(int countryId)
        {
            return new SuccessDataResult<Country>( _countryDal.GetByIdAsync(countryId).Result);//result yazınca çalıştı
        }

        
    }
}
