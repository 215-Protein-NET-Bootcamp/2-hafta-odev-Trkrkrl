
using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFolderService
    {
        IDataResult<List<Folder>> GetAll();
        IDataResult<Folder> GetById(int folderId);

        IResult Add(Folder folder);
        IResult Update(Folder folder);

        IResult Delete(Folder folder);
    }
}
