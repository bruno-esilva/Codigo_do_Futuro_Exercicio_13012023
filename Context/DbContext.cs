using Exercicio_13012023.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercicio_13012023.Contexto;

public class DbContexto : DbContext
{
    public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }

    // public DbContexto() { }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     var conexao = Environment.GetEnvironmentVariable("DATABASE_CDF");
    //     if(conexao == null) conexao = "Server=localhost;Database=persistencia_codigo_do_futuro;Uid=root;Pwd=root;";
    //     optionsBuilder.UseMySql(conexao, ServerVersion.AutoDetect(conexao));
    // }

    public DbSet<Administrador> Administradores { get; set; } = default!;
    public DbSet<Veiculo> Veiculos { get; set; } = default!;
}