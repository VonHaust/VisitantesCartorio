using System.Windows.Forms;
// Utilizamos pois é necessário para usar os recursos como "MessageBox" e "Form" do Windows Forms.

namespace VisitantesCartorio
{
    // O 'partial' se refere a uma classe que está dividida em mais de um arquivo.
    // Nesse caso, são dois arquivos: 'FormMain.cs' e 'FormMain.Designer.cs'.
    public partial class FormMain : Form
    {
        // 1. CONSTRUTOR: Ele inicializa o formulário na memória.
        public FormMain()
        {
            // Método obrigatório. Ele lê o arquivo 'FormMain.Designer.cs' e monta a interface.
            // Todo o código a ser desenvolvido deve vir após essa linha.
            InitializeComponent();
        }

        // 2. FORM CLOSING: Ao tentar fechar ('X') a aplicação:
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Exibe um pop-up, com opções 'Sim' e 'Não', perguntando se o usuário tem certeza em sair da aplicação.
            if (MessageBox.Show("Tem certeza que deseja sair?", "Selecione",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.No)
            {
                // Por padrão, a variável 'e.Cancel' é 'false', ou seja, o formulário fecha normalmente.
                // Mas se, sendo essa a condição (if), o usuário clicar em 'Não', então a variável passa a ser 'true', e o formulário NÃO fecha.
                e.Cancel = true;
            }
        }

        // 3. BOTÃO 'CADASTRAR': Ao clicar no botão 'Cadastrar':
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //Chama o Formulário de Visitantes ('FormVisitors').
            FormVisitors formVisitors = new FormVisitors();
            //Exibe o Formulário de Visitantes e trava o acesso à tela inicial.
            formVisitors.ShowDialog();
        }

        // 4. BOTÃO 'LISTAR': Ao clicar no botão 'Listar':
        private void buttonList_Click(object sender, EventArgs e)
        {
            // Chama o Formulário de Listagem ('FormList').
            FormList formList = new FormList();
            // Exibe o Formulário de Listagem e trava o acesso à tela inicial.
            formList.ShowDialog();
        }
    }
}
