using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoldersController : ControllerBase
    {
        IFolderService _folderService;

        public FoldersController(IFolderService folderService)
        {
            _folderService = folderService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _folderService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int folderId)
        {
            var result = _folderService.GetById(folderId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //post-add,update ,delete
        [HttpPost("add")]
        public IActionResult Add(Folder folder)
        {
            var result = _folderService.Add(folder);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Folder folder)
        {
            var result = _folderService.Update(folder);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Folder folder)
        {
            var result = _folderService.Delete(folder);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
