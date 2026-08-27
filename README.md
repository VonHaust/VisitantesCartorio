# Projeto Visitantes Cartório
Projeto de estudo demonstrando a integração do Entity Framework com o banco de dados SQLite, construído sobre a plataforma .NET e Windows Forms.

&nbsp;
## **📖 Sobre**

Voltado para um uso prático, com o objetivo de registrar o fluxo de pessoas que realizam serviços em cartórios, o **Formulário de Visitantes** permite o cadastro e a remoção de indivíduos, bem como a geração de um relatório contendo todos os visitantes, seus dados, serviços realizados, data e hora.

Por ser uma aplicação local e isolada, é ideal para cenários que necessitam de respostas rápidas na interface sem depender de conexões instáveis de internet para gravar dados básicos.

&nbsp;
## **📸 Demonstração**

<img width="500" height="281" alt="Print_1" src="https://github.com/user-attachments/assets/90816d1a-31af-42b3-ad0e-96f17663bc03" />

*Acima: Visão geral do Menu Principal do formulário.*

<img width="500" height="281" alt="Print_2" src="https://github.com/user-attachments/assets/80aaecda-a45c-4a96-a072-bc7da61ecadd" />

*Acima: Interface de cadastro de visitantes com validação de campos em tempo real.*

&nbsp;
## **⚙️ Arquitetura e Fluxo de Dados**

O ecossistema funciona através da seguinte lógica:
* **Interface Gráfica (Windows Forms):** Através da qual o usuário realiza a interação com o sistema. 
* **Mapeamento Objeto-Relacional (Entity Framework Core):** Realiza a ponte entre o código em C# e o banco de dados.
* **Banco de Dados Local (SQLite):** Armazena as informações cadastradas no arquivo físico local (`.db`).

&nbsp;
## **💼 Funcionalidades**

* **Menu Principal ("FormMain"):** Interface central que apresenta duas opções: "Cadastrar" e "Listar". A navegação foi projetada para que as janelas secundárias não se sobreponham, exigindo que finalize a tela atual para acessar a próxima.
* **Cadastro de Visitantes ("FormVisitor"):** Permite a inserção de nome, gênero, serviço cartorial solicitado e a data do atendimento. Conta com validação preventiva de dados (impedindo cadastros em branco), um painel Grid atualizado em tempo real com os últimos registros e botões de ação ("Cadastrar", "Deletar" e "Resetar"). 
* **Listagem e Relatório ("FormList"):** Exibe todos os registros ativos do banco em um documento selecionável e copiável, incluindo o horário exato do cadastro.
* **Segurança no Gerenciamento de Dados:** Para as opções de exclusão individual ou reset completo do banco de dados, conta com o uso de pop-ups de confirmação afim de evitar acidentes. Acionar essas funções também redefine automaticamente os identificadores (IDs) do SQLite.

&nbsp;
## **🚀 Como Executar**

Para executar o projeto no seu ambiente, você precisará do **Visual Studio** instalado com o pacote de desenvolvimento para desktop do .NET.

1. Clone este repositório;
2. Abra o projeto diretamente através do Visual Studio;
3. Se necessário, faça a restauração das dependências e dos pacotes NuGet digitando `dotnet restore` no Console do Gerenciador de Pacotes ou compilando a solução pela primeira vez;
4. Pressione `F5` ou o botão *Iniciar* para rodar a aplicação;
5. Interaja e aproveite!

*Nota¹: O arquivo do banco de dados SQLite (`bancoVisitantes.db`) será gerado automaticamente na pasta raiz de execução (`bin/Debug`) assim que o sistema for iniciado pela primeira vez.*

&nbsp;
## **💻 Tecnologias Utilizadas**

* **C# (.NET):** Linguagem utilizada como base do projeto.
* **Windows Forms:** Framework para a construção da interface gráfica.
* **Entity Framework Core (EF Core):** ORM utilizado para gerenciar o banco de dados, fazer o mapeamento das entidades e executar os comandos relacionais.
* **SQLite:** Banco de dados escolhido por sua portabilidade e facilidade de implementação em projetos Windows Form.

*Nota²: Para o desenvolvimento do projeto, foi utilizado o Visual Studio 2026 na versão "18.9.2".*

<div align="center">
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#">
  <img src="https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white" alt=".NET">
  <img src="https://img.shields.io/badge/SQLite-07405E?style=for-the-badge&logo=sqlite&logoColor=white" alt="SQLite">
  <img src="https://img.shields.io/badge/Windows%20Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white" alt="Windows Forms">
</div>

<br>

&nbsp;
## **👩🏻‍💻 Autores**

[<img src="https://images.weserv.nl/?url=avatars.githubusercontent.com/u/50738663?v=4&h=125&w=125&fit=cover&mask=circle&maxage=7d" width=115><br><sub>Marcella Portela</sub>](https://github.com/VonHaust)
