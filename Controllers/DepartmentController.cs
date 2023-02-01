using dotrest.Model;
using dotrest.Repository;
using Microsoft.AspNetCore.Mvc;

namespace dotrest.Controllers;

[ApiController]
[Route("[controller]")]
public class DepartmentController : Controller
{
    private readonly IDepartmentRepository _department;
    private readonly ILogger<DepartmentController> _logger;
    public DepartmentController(IDepartmentRepository department,ILogger<DepartmentController> logger)
    {
        _department = department;
        _logger = logger;
    }
    [HttpGet("GetDepartment")]
    public async Task<IActionResult> Get()
    {
        _logger.LogInformation("Get Department API executed");
        return Ok(await _department.GetDepartment());
    }
    
    [HttpPost("PostDepartment")]
    public async Task<IActionResult> Post(Department dep)
    {
        _logger.LogInformation("Post Department API executed");
        // return Ok(dep);
         var result = await _department.InsertDepartment(dep);
        return result.Id == 0 ? StatusCode(StatusCodes.Status500InternalServerError, "Something went wrong") : Ok("Added Successfully");
    }
    
    
}