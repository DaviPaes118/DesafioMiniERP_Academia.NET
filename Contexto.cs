using Microsoft.EntityFrameworkCore;
using MiniERP.Models;

namespace MiniERP
{
    public class Contexto : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Nota> NotasFiscais { get; set; }
        public DbSet<ItemNota> NotasFiscaisItens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=miniERP; User ID=miniERP; password=senha1234;language=Portuguese");

            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Relação Produto - Fornecedor
            modelBuilder.Entity<Produto>()
                        .HasOne(p => p.Fornecedor)
                        .WithMany(f => f.Produtos)
                        .OnDelete(DeleteBehavior.Restrict);
                        
            //Relação Nota - Cliente
            modelBuilder.Entity<Nota>()
                        .HasOne(nf => nf.Cliente)
                        .WithMany(c => c.Notas)
                        .HasPrincipalKey(c => c.ClienteID)
                        .HasForeignKey(nf => nf.ClienteID)
                        .OnDelete(DeleteBehavior.Restrict);

            //Relação Nota - ItemNota
            modelBuilder.Entity<Nota>()
                        .HasMany(nf => nf.Itens)
                        .WithOne(nfi => nfi.Nota);

            //Relação ItemNota - Produto
            modelBuilder.Entity<ItemNota>()
                        .HasOne(nfi => nfi.Produto);
                        
            modelBuilder.Entity<Cliente>()
                        .HasIndex(c => c.CPF)
                        .IsUnique();

            modelBuilder.Entity<Fornecedor>()
                        .HasIndex(f => f.CNPJ) 
                        .IsUnique();
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
