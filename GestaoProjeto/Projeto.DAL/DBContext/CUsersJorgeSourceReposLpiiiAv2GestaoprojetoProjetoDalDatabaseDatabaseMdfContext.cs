using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Projeto.DAL.DBContext
{
    public partial class CUsersJorgeSourceReposLpiiiAv2GestaoprojetoProjetoDalDatabaseDatabaseMdfContext : DbContext
    {
        public CUsersJorgeSourceReposLpiiiAv2GestaoprojetoProjetoDalDatabaseDatabaseMdfContext()
        {
        }

        public CUsersJorgeSourceReposLpiiiAv2GestaoprojetoProjetoDalDatabaseDatabaseMdfContext(DbContextOptions<CUsersJorgeSourceReposLpiiiAv2GestaoprojetoProjetoDalDatabaseDatabaseMdfContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Projeto> Projetos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jorge\\source\\repos\\LPIII-AV2\\GestaoProjeto\\Projeto.DAL\\database\\database.mdf;Integrated Security=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Projeto>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Projeto__3213E83F79E9AFC8");

                entity.ToTable("Projeto");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Manager)
                    .HasColumnType("text")
                    .HasColumnName("manager");
                entity.Property(e => e.Name)
                    .HasColumnType("text")
                    .HasColumnName("name");
                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("startDate");
                entity.Property(e => e.Status)
                    .HasColumnType("text")
                    .HasColumnName("status");
                entity.Property(e => e.Summary)
                    .HasColumnType("text")
                    .HasColumnName("summary");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}