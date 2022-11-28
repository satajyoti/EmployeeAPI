using System;
using System.Collections.Generic;

namespace EmployeeAPI.Models;

public partial class TblEmployee
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Tel { get; set; }

    public string? Email { get; set; }
}
