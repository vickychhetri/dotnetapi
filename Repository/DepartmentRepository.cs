using dotrest.Data;
using dotrest.Model;
using Microsoft.EntityFrameworkCore;

namespace dotrest.Repository;

public class DepartmentRepository : IDepartmentRepository
{
    private readonly APIDbContext _apiDbContext;

    public DepartmentRepository(APIDbContext apiDbContext)
    {
        _apiDbContext = apiDbContext;
    }
    public async Task<IEnumerable<Department>> GetDepartment()
    {
        return await _apiDbContext.Departments.ToListAsync();
    }

    public async Task<Department> GetDepartmentByID(int ID)
    {
        return await _apiDbContext.Departments.FindAsync(ID);
    }

    public async Task<Department> InsertDepartment(Department objDepartment)
    {
        _apiDbContext.Departments.Add(objDepartment);
        await _apiDbContext.SaveChangesAsync();
        return objDepartment;
    }

    public async Task<Department> UpdateDepartment(Department objDepartment)
    {
        _apiDbContext.Entry(objDepartment).State = EntityState.Modified;
        await _apiDbContext.SaveChangesAsync();
        return objDepartment;
    }

    public bool DeleteDepartment(int ID)
    {
        bool result = false;
        var department = _apiDbContext.Departments.Find(ID);
        if (department != null)
        {
            _apiDbContext.Entry(department).State = EntityState.Deleted;
            _apiDbContext.SaveChangesAsync();
            result = true;
        }
        else
        {
            result = false;
        }
        return result;
    }
}
