using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Projeto.DAL.DBContext { 
    using Projeto.MODEL;

public partial class CUsersJorgeSourceReposLpiiiAv2GestorprojetoProjetoDalDatabaseDatabaseMdfContext : DbContext
    {
        public CUsersJorgeSourceReposLpiiiAv2GestorprojetoProjetoDalDatabaseDatabaseMdfContext()
        {
        }

        public CUsersJorgeSourceReposLpiiiAv2GestorprojetoProjetoDalDatabaseDatabaseMdfContext(DbContextOptions<CUsersJorgeSourceReposLpiiiAv2GestorprojetoProjetoDalDatabaseDatabaseMdfContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Projeto> Projetos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jorge\\source\\repos\\LPIII-AV2\\GestorProjeto\\Projeto.DAL\\database\\database.mdf;Integrated Security=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Projeto>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Projetos__3214EC276D03498F");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.DataFim)
                    .HasColumnType("date")
                    .HasColumnName("DATA_FIM");
                entity.Property(e => e.DataInicio)
                    .HasColumnType("date")
                    .HasColumnName("DATA_INICIO");
                entity.Property(e => e.Gerente)
                    .HasColumnType("text")
                    .HasColumnName("GERENTE");
                entity.Property(e => e.Nome)
                    .HasColumnType("text")
                    .HasColumnName("NOME");
                entity.Property(e => e.Resumo)
                    .HasColumnType("text")
                    .HasColumnName("RESUMO");
                entity.Property(e => e.Status)
                    .HasColumnType("text")
                    .HasColumnName("STATUS");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}