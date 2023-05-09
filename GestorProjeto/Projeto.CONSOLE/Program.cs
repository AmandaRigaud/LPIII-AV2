using Projeto.BLL;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("\n | Projeto | Gerente | Status | Resumo | Data Inicio | Data FIm | \n");

        var list = ProjetoRepository.GetAll();
        foreach (var item in list)
        {
            Console.WriteLine("\n | " + item.Nome +
            " | " + item.Gerente +
            " | " + item.Status +
            " | " + item.Resumo +
            " | " + item.DataInicio.Value.ToShortDateString() +
            " | " + item.DataFim.Value.ToShortDateString() + " | \n");
        }
    }
}