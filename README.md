# Gerenciador de Tarefas (To-Do List)

Este é um projeto em C# para gerenciar uma lista de tarefas (To-Do List). O programa permite ao usuário adicionar, listar, buscar, filtrar e ordenar tarefas, além de salvar e carregar os dados em um arquivo para persistência entre execuções.

## Funcionalidades

- **Adicionar nova tarefa**: O usuário pode adicionar tarefas com nome, descrição, data de criação e data de vencimento.
- **Listar todas as tarefas**: Exibe todas as tarefas cadastradas com informações detalhadas.
- **Buscar tarefas**: O usuário pode buscar tarefas por nome ou descrição.
- **Filtrar tarefas por status**: Permite filtrar tarefas com base no status ("Pendente" ou "Concluída").
- **Ordenar tarefas**: Ordena as tarefas por data de vencimento (crescente ou decrescente).
- **Marcar tarefa como concluída**: Permite ao usuário marcar uma tarefa como "Concluída".
- **Remover tarefa**: Remove uma tarefa específica.
- **Persistência de dados**: O sistema salva as tarefas em um arquivo de texto (ou formato JSON) e as carrega ao iniciar o programa.

## Tecnologias Utilizadas

- C#
- .NET (qualquer versão que suporte Console Application)

## Requisitos

Para executar este projeto, você precisa ter instalado:

- [.NET SDK](https://dotnet.microsoft.com/download) (qualquer versão compatível com Console Application)
- Um editor de código como [Visual Studio Code](https://code.visualstudio.com/) ou [Visual Studio](https://visualstudio.microsoft.com/)

## Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/to-do-list-csharp.git
Navegue até o diretório do projeto:

bash
Copiar código
cd to-do-list-csharp
Abra o projeto no Visual Studio ou Visual Studio Code.

Execute o projeto:

Se estiver utilizando o Visual Studio, basta pressionar Ctrl+F5 ou clicar em "Start".
Se estiver utilizando o Visual Studio Code, você pode usar o terminal para rodar o comando:
bash
Copiar código
dotnet run
Como Usar
Ao executar o programa, será exibido um menu com várias opções, como:

Adicionar nova tarefa
Listar todas as tarefas
Buscar tarefas por nome ou descrição
Filtrar tarefas por status (Pendente/Concluída)
Ordenar tarefas por data de vencimento
Marcar tarefa como concluída
Remover tarefa
Salvar tarefas em um arquivo
Carregar tarefas do arquivo
Estrutura do Código
Classe Tarefa
Representa uma tarefa com os seguintes atributos:

Id: Identificador único da tarefa.
Nome: Nome da tarefa.
Descricao: Descrição da tarefa.
DataCriacao: Data de criação da tarefa.
DataVencimento: Data limite para concluir a tarefa.
Status: Status da tarefa (ex.: "Pendente", "Concluída").
Classe ToDoList
Contém as funcionalidades para gerenciar a lista de tarefas:

Adicionar, listar, buscar, filtrar, ordenar, concluir e remover tarefas.
Salvar e carregar as tarefas de um arquivo.
Como Funciona a Persistência de Dados
O sistema pode salvar as tarefas em um arquivo de texto simples ou JSON. Ao iniciar o programa, ele carrega as tarefas salvas automaticamente, garantindo que os dados sejam preservados entre execuções.

Exemplos de Uso
Adicionar Tarefa
bash
Copiar código
Digite o nome da tarefa:
Estudar C#
Digite a descrição da tarefa:
Estudar sobre LINQ, Delegates e Eventos
Digite a data de vencimento (dd/mm/yyyy):
20/12/2024
Listar Tarefas
yaml
Copiar código
Lista de Tarefas:
Id: 1 | Nome: Estudar C# | Status: Pendente | Vencimento: 20/12/2024
Buscar Tarefa
yaml
Copiar código
Digite o termo para buscar:
Estudar
Id: 1 | Nome: Estudar C# | Status: Pendente | Vencimento: 20/12/2024
Contribuições
Se você quiser contribuir para este projeto, fique à vontade para abrir uma issue ou enviar um pull request. Para melhorias, correções ou sugestões, fique à vontade para nos informar!

Fork o repositório.
Crie uma nova branch para sua feature (git checkout -b minha-feature).
Faça as alterações desejadas.
Envie as alterações para o seu fork (git push origin minha-feature).
Crie um pull request explicando as mudanças.
Licença
Este projeto está sob a licença MIT - veja o arquivo LICENSE para mais detalhes.

Contato
Para mais informações, entre em contato através do e-mail: seu-email@dominio.com.

markdown
Copiar código

### Explicação:

- **Título e Descrição**: Explica de maneira simples o que o projeto faz e suas funcionalidades principais.
- **Tecnologias Utilizadas**: Lista as tecnologias usadas no projeto (C# e .NET).
- **Instruções de Execução**: Passo a passo de como executar o projeto.
- **Como Usar**: Detalha como o usuário pode interagir com o programa.
- **Estrutura do Código**: Descrição geral das principais classes e seus papéis no código.
- **Exemplos de Uso**: Exemplos simples de como o usuário pode interagir com a aplicação.
- **Contribuições**: Instruções para quem quiser contribuir com o projeto.
- **Licença**: Inclui a licença do projeto (MIT, mas pode ser alterada conforme necessário).
- **Contato**: Fornece um contato para dúvidas ou sugestões.
