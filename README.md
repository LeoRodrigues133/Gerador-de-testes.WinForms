# Gerador-de-Testes-2024-A&M


## Sumário Executivo

Mariana deseja informatizar os exercícios preparatórios para suas filhas, possibilitando a geração de testes aleatórios. Cada teste gerado deve ser armazenado com suas questões e a data de geração. Na geração de um teste, é necessário especificar o número de questões desejadas e a disciplina a que pertence.

---

## Módulo de Disciplinas

### 1. Cadastrar Disciplinas

- **Registrar Nova Disciplina:** Permite cadastrar uma nova disciplina com seu nome. É obrigatório fornecer o nome da disciplina, e não é permitido cadastrar disciplinas com o mesmo nome.

### 2. Editar Disciplinas

- **Editar Disciplina:** Permite modificar o nome de uma disciplina existente.

### 3. Excluir Disciplinas

- **Remover Disciplina:** Permite excluir uma disciplina do sistema, desde que não haja matérias ou testes relacionados a ela.

### 4. Visualizar Todas as Disciplinas

- **Listar Disciplinas:** Apresenta uma lista com o ID e o nome de todas as disciplinas cadastradas.

---

## Módulo de Matérias

### 1. Cadastrar Matérias

- **Registrar Nova Matéria:** Permite cadastrar uma nova matéria com seu nome, disciplina e série. Todos os campos são obrigatórios, e não é permitido cadastrar matérias com o mesmo nome.

### 2. Editar Matérias

- **Editar Matéria:** Permite modificar as informações de uma matéria existente.

### 3. Excluir Matérias

- **Remover Matéria:** Permite excluir uma matéria do sistema, desde que não esteja sendo utilizada em questões.

### 4. Visualizar Todas as Matérias

- **Listar Matérias:** Apresenta uma lista com o ID, nome, disciplina e série de todas as matérias cadastradas.

---

## Módulo de Questões

### 1. Cadastrar Questões

- **Registrar Nova Questão:** Permite cadastrar uma nova questão com enunciado, alternativas e a matéria relacionada. Todos os campos são obrigatórios.

### 2. Editar Questões

- **Editar Questão:** Permite modificar as informações de uma questão existente.

### 3. Excluir Questões

- **Remover Questão:** Permite excluir uma questão do sistema, desde que não esteja associada a nenhum teste.

### 4. Visualizar Todas as Questões

- **Listar Questões:** Apresenta uma lista com o ID, enunciado, matéria e resposta correta de todas as questões cadastradas.

### 5. Configurar Alternativas da Questão

- **Configurar Alternativas:** Permite adicionar ou remover alternativas em uma questão. Garante que apenas uma alternativa seja marcada como correta.

---

## Módulo de Testes

### 1. Gerar Testes

- **Criar Novo Teste:** Permite gerar um novo teste com título, disciplina, matéria, série e quantidade de questões desejadas. As questões são selecionadas aleatoriamente.

### 2. Duplicar Testes

- **Duplicar Teste Existente:** Permite duplicar um teste existente, mantendo suas configurações. As questões são duplicadas com o teste, mas inicialmente vazias.

### 3. Excluir Testes

- **Remover Teste:** Permite excluir um teste do sistema.

### 4. Visualizar Todos os Testes

- **Listar Testes:** Apresenta uma lista com o ID, título, disciplina, matéria (ou indica que é uma prova de recuperação) e quantidade de questões de todos os testes cadastrados.

### 5. Visualizar Detalhes dos Testes

- **Detalhar Teste:** Permite visualizar detalhes de um teste específico, incluindo suas questões.

### 6. Gerar PDF dos Testes

- **Exportar Teste para PDF:** Gera um arquivo PDF contendo o título, disciplina, matéria, questões e alternativas dos testes.

### 7. Gerar PDF do Gabarito dos Testes

- **Exportar Gabarito para PDF:** Gera um arquivo PDF contendo o gabarito das questões dos testes, indicando as alternativas corretas.

---

## Requisitos Não Funcionais

- **Persistência das Informações:** Os dados devem ser salvos e recuperados em arquivo.
- **Arquitetura:** Utilização do padrão MVC para a estruturação do projeto.
- **Interfaces com o Usuário:** Detalhamento dos critérios para as telas de cadastro e listagem.
- 
---

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.
---
## Como Usar

#### Clone o Repositório
```
git clone https://github.com/Arco-e-Machado/Gerador-de-testes-2024.git
```

#### Navegue até a pasta raiz da solução
```
cd gerador-de-testes-2024
```

#### Restaure as dependências
```
dotnet restore
```

#### Navegue até a pasta do projeto
```
cd GeradorDeTestes.WinApp
```

#### Execute o projeto
```
dotnet run
```
