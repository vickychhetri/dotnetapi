using System.ComponentModel.DataAnnotations;

namespace dotrest.Model;

public class Employee
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public DateTime DOJ { get; set; }
}