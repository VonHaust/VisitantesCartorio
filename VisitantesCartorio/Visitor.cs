using System;
// Utilizamos pois o Entity Framework precisa dessa biblioteca para definir do tipo de dado 'DateTime'.

namespace VisitantesCartorio
{
    // A classe 'Visitor' representa a entidade 'Visitante' no banco de dados.
    // Ela serve como um molde (informações que deve ter) que o Entity Framework pecorre para
    // desenhar a tabela dentro do arquivo SQLite.
    public class Visitor
    {
        // O EF automaticamente cria a propriedade 'Id' como uma chave primária auto-incremental. Ela será mapeada.
        public int Id { get; set; }

        // Mapeia o conteúdo da 'textBoxName' (Nome)
        public string Nome { get; set; }

        // Mapeia a opção escolhida na 'comboBoxGender' (Gênero)
        public string Genero { get; set; }

        // Mapeia a opção escolhida na 'comboBoxProcedure' (Serviço)
        public string Servico { get; set; }

        // Mapeia a data informada no 'dateTimePickerDMY' (Data da Visita)
        public DateTime DataVisita { get; set; }
    }
}