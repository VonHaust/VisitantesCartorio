using Microsoft.EntityFrameworkCore;
// Utilizamos pois essa é a biblioteca faz a conexão entre o SQLite e o Entity Framework.

namespace VisitantesCartorio
{
    // A classe se torna 'public' para que o resto do projeto consiga usá-la, pois é aqui que o Entity Framework fará
    // a conexão com o banco de dados SQLite e isso servirá de base para todo o projeto.
    public class CartorioDbContext : DbContext
    {
        // 1. CONSTRUTOR:  Ele inicializa o formulário na memória.
        public CartorioDbContext()
        {
            // 'Ensure Created' irá garantir que o banco de dados seja criado caso ele ainda não exista.
            // Caso contrário, apenas abre a conexão.
            this.Database.EnsureCreated();
        }

        // Estabelece a classe 'Visitor' como tabela 'Visitantes' dentro do banco de dados SQLite.
        // É através dessa propriedade que conseguimos manipular os cadastros de visitantes no banco de dados.
        public DbSet<Visitor> Visitantes { get; set; }

        // 2. CONFIGURAÇÃO: Permite definir as configurações do banco de dados.
        // Se torna 'protected' para que nenhum 'Form' possa bagunçar as configurações da conexão.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Define o provedor de banco de dados a ser utilizado (SQLite).
            // Define o nome do arquivo físico (dentro da pasta) do banco de dados (bancoVisitantes.db).
            optionsBuilder.UseSqlite("Data Source=bancoVisitantes.db");
        }
    }
}