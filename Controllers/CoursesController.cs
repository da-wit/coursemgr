using Microsoft.AspNetCore.Mvc;

namespace Corsemgr.Controllers;

[ApiController]
[Route("courses/")]

public class CourseController : ControllerBase
{
    public CourseController(){}

    [HttpGet]

    public ActionResult<List<Couse>> GetAllCourses() => CourseService.All();
}