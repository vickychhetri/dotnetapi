using dotrest.Model;
using dotrest.Repository;
using Microsoft.AspNetCore.Mvc;

namespace dotrest.Controllers;

public class DepartmentController : Controller
{
    private readonly DepartmentRepository _repo;

    public DepartmentController(DepartmentRepository repo)
    {
        _repo = repo;
    }
    // GET
    public Task<IEnumerable<Department>> Index()
    {
        return _repo.GetDepartment();
    }
}