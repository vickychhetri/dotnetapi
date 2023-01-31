using System.ComponentModel.DataAnnotations;

namespace dotrest.Model;

public class Department
{
    [Key]
    public int Id { get; set; }
    public string DepartmentName { get; set; }
}