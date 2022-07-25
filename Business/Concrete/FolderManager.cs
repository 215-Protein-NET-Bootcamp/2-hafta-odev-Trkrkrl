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
            _folderDal.Add(folder);
            return new SuccessResult("Folder added");
        }

        public IResult Delete(Folder folder)
        {
            return new Result(true, "Folder deleted"); ;
        }
        public IResult Update(Folder folder)
        {
            _folderDal.Update(folder);
            return new Result(true);
        }

        public IDataResult<List<Folder>> GetAll()
        {
            return new DataResult<List<Folder>>(_folderDal.GetAll(), true, "Folders Listed");
        }

        public IDataResult<Folder> GetById(int folderId)
        {
            
            return new SuccessDataResult<Folder>(_folderDal.Get(c => c.Id == folderId));
        }

        
    }
}
