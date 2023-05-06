using System;
using System.Collections.Generic;

namespace LP3.DAL.DBContext;

public partial class Projeto
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Manager { get; set; }

    public DateTime? StartDate { get; set; }

    public string? Summary { get; set; }

    public string? Status { get; set; }
}
