using Microsoft.EntityFrameworkCore;
// Utilizamos pois é necessário para fazer a conexão entre o SQLite e o Entity Framework, manipulando os dados.
using System;
// Utilizamos pois é necessário para usar os recursos como 'Exception' e 'DateTime' do .NET.
using System.Windows.Forms;
// Utilizamos pois é necessário para usar os recursos como "MessageBox" e "Form" do Windows Forms.

namespace VisitantesCartorio
{
    // Mesmo conceito explicado em 'FormMain'.
    public partial class FormVisitors : Form
    {
        // 1. CONSTRUTOR:
        public FormVisitors()
        {
            InitializeComponent();
        }

        // 2. LOAD: Ao carregar a tela, chama a função para atualizar o DataGridView.
        private void FormVisitors_Load(object sender, EventArgs e)
        {
            AtualizarTabela(); // Chama a função para preencher o grid assim que a tela abrir
        }

        // 3. FUNÇÃO INTERNA: Utilizada pelas demais funções para atualizar o DataGridView com os dados do banco de dados.
        private void AtualizarTabela()
        {
            // Executa o 'try' e, se der algum erro no código dentro dele, cai no 'catch' e mostra o erro para o usuário.
            try
            {
                // O 'using' irá garantir que o banco de dados não fique travado na memória do Windows, esperando ser utilizado.
                // Se não implementado, pode ocorrer o erro: "O arquivo já está sendo usado por outro processo".
                // Explicação: quando o bloco inicia, o 'using' abre a conexão com o arquivo SQLite e, quando chega no final,
                // força o encerramento da conexão e libera o arquivo .db com as mudanças.
                using (var context = new CartorioDbContext())
                {
                    // Pega os visitantes, coloca dentro da variável 'lista' e ordena os IDs em ordem decrescente
                    // (mais recente para o mais antigo).
                    var lista = System.Linq.Enumerable.ToList(
                        System.Linq.Enumerable.OrderByDescending(context.Visitantes, v => v.Id)
                    );

                    // Exibe a lista no DataGridView.
                    dataGridViewPrev.DataSource = lista;

                    // Formata a coluna "DataVisita" para exibir apenas a data curta (dd/MM/yyyy), sem horário. 
                    // P.S: "MM" se refere à mês, enquanto "mm" se refere a minutos.
                    dataGridViewPrev.Columns["DataVisita"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }
            }
            // Se houver algum erro ao carregar a tabela, mostra um pop-up.
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar a tabela: {ex.Message}", "Erro", MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }
        }


        // 4. BOTÃO 'CADASTRAR': para salvar os dados inseridos.
        private void buttonRegInfo_Click(object sender, EventArgs e)
        {
            // 4.1. Validação do Nome: se o campo estiver vazio ou apenas com espaços, impede o cadastro e mostra um pop-up.
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Por favor, preencha o campo 'Nome'.", "Aviso", MessageBoxButtons.OK, 
                                MessageBoxIcon.Warning);
                return;
            }

            // 4.2. Validação do Gênero: se nada foi selecionado na ComboBox, impede o cadastro e mostra um pop-up.
            // O '-1' indica que nenhum item foi selecionado.
            if (comboBoxGender.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um 'Gênero' antes de cadastrar.", "Aviso", MessageBoxButtons.OK, 
                                MessageBoxIcon.Warning);
                return;
            }

            // 4.3. Validação do Serviço: se nada foi selecionado na ComboBox, impede o cadastro e mostra um pop-up.
            if (comboBoxProcedure.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um 'Serviço' antes de cadastrar.", "Aviso", MessageBoxButtons.OK, 
                                MessageBoxIcon.Warning);
                return;
            }

            // 4.4. Criação do novo 'Visitor': Se passar por todas as validações acima, continua com o código abaixo.
            // Cria um novo objeto 'Visitor', recebendo os dados inseridos pelo usuário na interface.
            Visitor newVisitor = new Visitor
            {
                // As variáveis abaixo são preenchidas com os respectivos valores dos campos do formulário.
                // O 'ToString()' é usado pois a comboBox devolve um 'object' (tipo genérico, pode ser várias coisas) em vez de
                // uma 'string' (tipo definido, não há confusão). Assim, para que o Entity Framework consiga salvar o texto
                // corretamente no banco de dados, precisa converter.
                Nome = textBoxName.Text,
                Genero = comboBoxGender.SelectedItem.ToString(),
                Servico = comboBoxProcedure.SelectedItem.ToString(),
                DataVisita = dateTimePickerDMY.Value
            };

            try
            {
                using (var context = new CartorioDbContext())
                {
                    // Adiciona o novo visitante ao banco de dados (em memória).
                    context.Visitantes.Add(newVisitor);
                    // Grava no arquivo .db
                    context.SaveChanges();
                }

                MessageBox.Show("Visitante cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);

                // Limpa o campo de texto para o próximo cadastro.
                textBoxName.Clear(); 

                // Reseta o índice de seleção das comboBox para -1 (vazio).
                comboBoxProcedure.SelectedIndex = -1;
                comboBoxGender.SelectedIndex = -1;

                // Chama a função abaixo para atualizar o DataGridView, mostrando o novo visitante cadastrado.
                AtualizarTabela();
            }

            catch (Exception ex)
            {
                // Se houver erro interno (InnerException), exibe ele. Se não, mostra a mensagem de erro padrão.
                string erroReal = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                // Exibe o erro interno real do banco de dados em um pop-up para o usuário.
                MessageBox.Show($"Erro real do Banco: {erroReal}", "Erro", MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }
        }

        // 5. BOTÃO 'DELETAR': para deletar uma linha selecionada no DataGridView.
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Verifica se o usuário realmente selecionou alguma linha no Grid e mostra um pop-up.
            if (dataGridViewPrev.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecione um visitante na tabela para deletar.", "Aviso", MessageBoxButtons.OK, 
                                MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Pega os dados da linha que foi selecionada no DataGridView e armazena na variável 'visitorSelecionado'.
                Visitor visitorSelecionado = (Visitor)dataGridViewPrev.CurrentRow.DataBoundItem;

                // Verifica se há informações dentro da variável (por segurança).
                if (visitorSelecionado != null)
                {
                    // Pede uma confirmação para evitar que o usuário delete sem querer.
                    var resultado = MessageBox.Show($"Tem certeza que deseja deletar o registro de '{visitorSelecionado.Nome}'?",
                                                    "Selecione",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

                    // Se o usuário clicar em 'Sim', a linha é deletada do banco de dados.
                    if (resultado == DialogResult.Yes)
                    {
                        // Roda um 'using' novamente, dessa vez para deletar um registro do banco de dados.
                        using (var context = new CartorioDbContext())
                        {
                            context.Visitantes.Remove(visitorSelecionado);
                            context.SaveChanges();
                        }

                        MessageBox.Show("Registro deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, 
                                        MessageBoxIcon.Information);

                        // Atualiza o Grid.
                        AtualizarTabela();
                    }
                }
            }
            // Se houver algum erro ao tentar deletar, mostra um pop-up.
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao deletar do banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }
        }

        // 6. BOTÃO 'RESETAR': para apagar todos os registros do banco de dados.
        private void buttonReset_Click(object sender, EventArgs e)
        {
            // 6.1. Pop-up de Confirmação.
            var confirmacao = MessageBox.Show(
                "AVISO! Esta ação irá apagar DEFINITIVAMENTE todos os visitantes cadastrados no banco de dados.\n\nDeseja continuar?",
                "Atenção",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                // Destaca o botão 'Não' (por segurança).
                MessageBoxDefaultButton.Button2
            );

            // 6.2. Se o usuário clicar em "Sim":
            if (confirmacao == DialogResult.Yes)
            {
                try
                {
                    using (var context = new CartorioDbContext())
                    {
                        // Deleta o arquivo .db no diretório do projeto.
                        context.Database.EnsureDeleted();

                        // Cria um novo arquivo .db, com todas as tabelas vazias e IDs resetados.
                        context.Database.EnsureCreated();
                    }
                
                    MessageBox.Show("O banco de dados foi resetado com sucesso! Todos os registros foram apagados.", 
                                    "Sucesso", MessageBoxButtons.OK, 
                                    MessageBoxIcon.Information);

                    // Atualiza o DataGridView.
                    AtualizarTabela();
                }
                // Se houver algum erro ao tentar resetar o banco de dados, mostra um pop-up.
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao reiniciar o banco de dados: {ex.Message}", 
                                    "Erro", MessageBoxButtons.OK, 
                                    MessageBoxIcon.Error);
                }

            }
        }
    }
}
