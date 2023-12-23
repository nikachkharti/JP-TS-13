using Microsoft.AspNetCore.Mvc;

namespace Employees.API.Controllers
{
    [Route("api/file")]
    [ApiController]
    public class FileController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetFile(string filename)
        {
            var path = Path.GetFullPath("./wwwroot/images/" + filename);

            MemoryStream memory = new MemoryStream();
            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, "image/png", Path.GetFileName(path));
        }
    }
}
