using Microsoft.EntityFrameworkCore;
using Projeto.DAL.DBContext;
using System.Security.Cryptography.X509Certificates;using Projeto.MODEL;

namespace Projeto.BLL
{
    using Projeto.MODEL;
    public class ProjetoRepository
    {
        public static void Add(Projeto _projeto)
        {
            using (var dbContext = new CUsersJorgeSourceReposLpiiiAv2GestorprojetoProjetoDalDatabaseDatabaseMdfContext())
            {
                dbContext.Add(_projeto);
                dbContext.SaveChanges();
            }
        }

        public static Projeto GetById(int Id)
        {
            using(var dbContext = new CUsersJorgeSourceReposLpiiiAv2GestorprojetoProjetoDalDatabaseDatabaseMdfContext())
            {
                var projeto = dbContext.Projetos.Single(p => p.Id == Id);
                return projeto;
            }
        }
        public static List<Projeto> GetAll()
        {
            using (var dbContext = new CUsersJorgeSourceReposLpiiiAv2GestorprojetoProjetoDalDatabaseDatabaseMdfContext())
            {
                var projeto = dbContext.Projetos.ToList();
                return projeto;
            }
        }
        public static void Update(Projeto _projeto)
        {
            using (var dbContext = new CUsersJorgeSourceReposLpiiiAv2GestorprojetoProjetoDalDatabaseDatabaseMdfContext())
            {
                var projeto = dbContext.Projetos.Single(p => p.Id ==_projeto.Id);
                projeto.Nome = _projeto.Nome;
                projeto.Status = _projeto.Status;
                projeto.Resumo = _projeto.Resumo;
                projeto.DataInicio = _projeto.DataInicio;
                projeto.DataFim = _projeto.DataFim;
                projeto.Gerente = _projeto.Gerente;
                dbContext.SaveChanges();
            }
        }
        public static void Excluir(Projeto _projeto)
        {
            using (var dbContext = new CUsersJorgeSourceReposLpiiiAv2GestorprojetoProjetoDalDatabaseDatabaseMdfContext())
            {
                var projeto = dbContext.Projetos.Single(p => p.Id == _projeto.Id);
                dbContext.Remove(projeto);
                dbContext.SaveChanges();
            }
        }
    }
}