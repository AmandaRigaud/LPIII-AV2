using System;
using System.Collections.Generic;

namespace Projeto.MODEL;

public partial class Projetos
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Manager { get; set; }

    public DateTime? StartDate { get; set; }

    public string? Summary { get; set; }

    public string? Status { get; set; }
}
