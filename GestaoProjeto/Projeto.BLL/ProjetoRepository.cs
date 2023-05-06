using Projeto.MODEL;
using Projeto.DAL.DBContext;
using Microsoft.EntityFrameworkCore;

namespace Projeto.BLL
{
    public class ProjetoRepository
    {
        public static void Add(Projeto _projeto)
        {
            using (var dbContext = new CUsersJorgeSourceReposLpiiiAv2GestaoprojetoProjetoDalDatabaseDatabaseMdfContext()
            {
                dbContext.Add(_projeto);
                dbContext.SaveChanges();
            }
        }

    }
}