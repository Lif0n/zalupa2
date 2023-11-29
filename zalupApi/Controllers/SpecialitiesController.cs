using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using zalupApi.Models;

namespace zalupApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpecialitiesController : ControllerBase
    {
        MainContext _context = new MainContext();
        [HttpGet(Name = "GetGroups")]
        public IEnumerable<Group> Get()
        {
            return _context.Groups
                .Include(x=>x.Course)
                .ThenInclude(x=>x.Speciality)
                .ToArray();
        }
    }
}
