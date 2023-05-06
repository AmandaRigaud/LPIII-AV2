using Microsoft.EntityFrameworkCore;
using Projeto.MODEL;
using Projeto.DAL.DBContext;
using System.Security.Cryptography.X509Certificates;

namespace Projeto.BLL
{
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
    }
}