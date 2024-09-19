using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CrudMVCProject.Models;

public partial class Employee
{
    [Required]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = null!;
    [Required]
    public string Phone { get; set; } = null!;
    [Required]
    public int DepartmentId { get; set; }
}
