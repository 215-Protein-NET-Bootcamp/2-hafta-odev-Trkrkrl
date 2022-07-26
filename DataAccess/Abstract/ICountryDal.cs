using Core.DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICountryDal: IBaseRepository<Country>,IDapperDal<Country>
    {
        // IBaseRepositoryde temel methodlar var- özel bir şey olmadıkça buraya ayrı methoda gerek yok
        
    }
}
