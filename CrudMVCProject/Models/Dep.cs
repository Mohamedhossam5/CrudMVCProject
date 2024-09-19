using System;
using System.Collections.Generic;

namespace CrudMVCProject.Models;

public partial class Dep
{
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;
}
