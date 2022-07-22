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
    public class FolderManager : IFolderService
    {
        IFolderDal _folderDal;

        public FolderManager(IFolderDal folderDal)
        {
            _folderDal = folderDal;
        }

        public IResult Add(Folder folder)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Folder folder)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Folder>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Folder>> GetById(int folderId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Folder folder)
        {
            throw new NotImplementedException();
        }
    }
}
