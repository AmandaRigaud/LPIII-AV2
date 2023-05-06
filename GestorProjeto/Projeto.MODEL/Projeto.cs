using System;
using System.Collections.Generic;

namespace Projeto.MODEL;

public partial class Projeto
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public string? Gerente { get; set; }

    public DateTime? DataInicio { get; set; }

    public DateTime? DataFim { get; set; }

    public string? Resumo { get; set; }

    public string? Status { get; set; }
}
