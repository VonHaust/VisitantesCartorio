using System;
// Utilizamos pois é necessário para usar os recursos como 'Exception' e 'DateTime' do .NET.
using System.Text;
// Utilizamos pois é necessário para usar os recursos como 'StringBuilder' do .NET.
using System.Windows.Forms;
// Utilizamos pois é necessário para usar os recursos como "MessageBox" e "Form" do Windows Forms.

namespace VisitantesCartorio
{
    // Mesmo conceito explicado em 'FormMain'.
    public partial class FormList : Form
    {
        // 1. CONSTRUTOR: Ele inicializa o formulário na memória.
        public FormList()
        {
            InitializeComponent();

            // Garante que assim que o formulário é carregado, ele executa a função de carregar o banco.
            this.Load += new System.EventHandler(this.FormList_Load);
        }

        // 2. LOAD: Carrega todos os registros do banco ao abrir a janela.
        private void FormList_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new CartorioDbContext())
                {
                    // Busca TODOS os visitantes cadastrados.
                    var todosOsVisitantes = System.Linq.Enumerable.ToList(context.Visitantes);

                    // Se não houver visitanets cadastrados, retorna uma mensagem dentro do RichTextBox.
                    // P.S: 'RichTextBox' foi utilizado no lugar de 'TextBox' porque permite rolagem e melhor formatação de texto.
                    if (todosOsVisitantes.Count == 0)
                    {
                        richTextBoxList.Text = "Ainda não há visitantes cadastrados no banco de dados.";
                        return;
                    }

                    // Usa o StringBuilder para evitar problemas com consumo de memória e para juntar os blocos de texto
                    // definidos via AppendLine.
                    StringBuilder construtorTexto = new StringBuilder();

                    // Cabeçalho do formulário. Também menciona a data e hora em que foi GERADO.
                    construtorTexto.AppendLine("##################################################");
                    construtorTexto.AppendLine("       FORMULÁRIO DE VISITANTES           ");
                    construtorTexto.AppendLine($" Gerado em: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")} ");
                    construtorTexto.AppendLine("##################################################");
                    construtorTexto.AppendLine();

                    // Para cada visitante, exibe suas informações no formulário.
                    // P.S: No formulário, foi permitido que o horário da visita seja exibido.
                    foreach (var v in todosOsVisitantes)
                    {
                        construtorTexto.AppendLine($"REGISTRO nº: {v.Id}");
                        construtorTexto.AppendLine($"Nome: {v.Nome}");
                        construtorTexto.AppendLine($"Gênero: {v.Genero}");
                        construtorTexto.AppendLine($"Serviço realizado: {v.Servico}");
                        construtorTexto.AppendLine($"Data da Visita: {v.DataVisita.ToString("dd/MM/yyyy HH:mm")}");
                        construtorTexto.AppendLine("--------------------------------------------------");
                    }

                    // Converte todo o conteúdo dentro da variável 'construtorTexto' para string e exibe dentro do RichTextBox.
                    richTextBoxList.Text = construtorTexto.ToString();
                }
            }
            // Caso ocorra algum erro ao carregar os registros, exibe um pop-up de erro.
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar a listagem completa: {ex.Message}", "Erro", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

    }
}
