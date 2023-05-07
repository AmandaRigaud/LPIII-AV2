namespace Projeto.APP
{
    using Projeto.BLL;
    using Projeto.MODEL;

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Projeto p = new Projeto();
            p.Nome = "Projetinho";
            p.Gerente = "Josias";
            p.Resumo = "Tika!"!;
            p.DataInicio = DateTime.Parse("6/5/2023");
            p.DataFim = DateTime.Parse("7/5/2023");

            ProjetoRepository.Add(p);

            p.Status = "Fogo";
            ProjetoRepository.Update(p);

            Console.WriteLine("Cadastro concluido \n\n");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
    }
}