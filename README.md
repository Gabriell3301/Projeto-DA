# 🛒 iShopping

> Aplicação de gestão de compras domésticas desenvolvida em C# (WinForms) com Entity Framework e SQL Server.

---

## 📋 Descrição

O **iShopping** é um protótipo de aplicação desktop que permite a famílias gerir o seu orçamento e compras domésticas de forma organizada. Com suporte a múltiplos utilizadores, a aplicação permite planear listas de compras, registar artigos adquiridos (previstos e não previstos), controlar o orçamento mensal e consultar estatísticas detalhadas.

---

## 👥 Equipa

| Nome | Número de Estudante |
|---|---|
| Gabriell Barbosa | 2025168383 |
| Maria Cotovio | 2025190994 |

---

## 🎯 Funcionalidades Principais

- 🔐 **Autenticação** — Login e registo de utilizadores com username e password únicos
- 👤 **Gestão de Utilizadores** — CRUD completo com registo de quem criou/alterou cada entrada
- 🏷️ **Tipos de Artigo** — Organização de artigos por categorias (CRUD)
- 📦 **Artigos** — Gestão de artigos por tipo (CRUD)
- 💰 **Orçamento Mensal** — Definição de um orçamento único por mês com controlo de gastos em tempo real
- 📝 **Planeamento de Compras** — Criação e gestão de listas de compras com itens previstos
- 🛍️ **Modo Compra** — Registo de itens adquiridos (previstos e não previstos), com preço unitário e quantidade
- 📊 **Estatísticas** — Análise de orçamentos, compras fechadas e sugestões inteligentes
- 📤 **Exportação CSV** — Exportação de compras fechadas para ficheiro `.csv`

---

## 🧱 Arquitetura

O projeto segue o padrão **MVC (Model-View-Controller)**:

```
iShopping/
├── Models/          # Entidades e lógica de dados (Entity Framework)
├── Views/           # Formulários WinForms (.cs / .Designer.cs)
├── Controllers/     # Lógica de negócio e ligação entre Views e Models
├── Data/            # DbContext e configuração do Entity Framework
└── Migrations/      # Migrações da base de dados
```

---

## 🖥️ Formulários

| Formulário | Descrição |
|---|---|
| **Login** | Identificação do utilizador; permite registo de novos utilizadores |
| **Principal** | Menu principal; lista de compras em aberto |
| **Tipos de Artigo** | CRUD de tipos de artigo |
| **Artigos** | CRUD de artigos, filtrados por tipo |
| **Orçamentos** | Visualização e gestão dos orçamentos mensais |
| **Planeamento de Compras** | Listagem e filtro de compras; acesso a criação/edição |
| **Criação/Alteração de Compra** | Edição de compra planeada e respetivos itens |
| **Modo Compra** | Registo de aquisições em tempo real, com controlo de orçamento |
| **Estatísticas** | Análise e sugestões baseadas em histórico |

---

## 📊 Estatísticas Disponíveis

1. **Orçamento vs. Gastos** — Listagem mensal com orçamento definido, total gasto e diferença
2. **Previstos vs. Não Previstos** — Percentagem de artigos previstos e não previstos por compra fechada
3. **Sugestões Inteligentes** — Sugestão de orçamento para o próximo mês e lista de compras com base na semana do mês atual, calculadas a partir do histórico

---

## 📤 Exportação CSV

As compras fechadas podem ser exportadas para `.csv` (separado por `;`) com os seguintes campos:

```
NomeCompra ; DataCriacao ; DataFechada ; NomeArtigo ; ArtigoPrevisto ; ArtigoNaoPrevisto ; QuantidadePrevista ; QuantidadeAdquirida ; PrecoUnitario
```

---

## ⚙️ Tecnologias Utilizadas
 
| Tecnologia | Versão |
|---|---|
| C# / .NET | WinForms |
| Entity Framework | Code First |
| SQL Server LocalDB | Incluído com o Visual Studio |
| Git / GitHub | Controlo de versões colaborativo |
 
---
 
## 🚀 Instalação e Configuração
 
### Pré-requisitos
 
- Visual Studio 2022 (ou superior)
- SQL Server LocalDB (incluído com o Visual Studio)
- .NET Framework / .NET (versão utilizada no projeto)
- Entity Framework (instalado via NuGet)
### Passos
 
1. **Clonar o repositório:**
   ```bash
   git clone https://github.com/<utilizador>/iShopping.git
   cd iShopping
   ```
 
2. **Aplicar as migrações:**
   Na consola do Package Manager (Visual Studio):
   ```powershell
   Update-Database
   ```
 
3. **Compilar e executar:**
   Abrir a solução `.sln` no Visual Studio, compilar (`Ctrl+Shift+B`) e executar (`F5`).
---
 
## 📁 Estrutura do ZIP de Entrega
 
```
GabriellBarbosa_MariaCotovio.zip
├── Relatorio/
│   ├── relatorio.pdf         # Manual de utilização, diagrama de classes, justificações
│   └── DiagramaClasses.png
├── iShopping/                # Projeto completo com código fonte
│   ├── iShopping.sln
│   └── ...
└── readme.txt                # Este ficheiro (instalação e configuração)
```
 
---

## 📁 Estrutura do ZIP de Entrega

```
GabriellBarbosa_MariaCotovio.zip
├── Relatorio/
│   ├── relatorio.pdf         # Manual de utilização, diagrama de classes, justificações
│   └── DiagramaClasses.png
├── iShopping/                # Projeto completo com código fonte
│   ├── iShopping.sln
│   └── ...
└── readme.txt                # Este ficheiro (instalação e configuração)
```

---

## 📅 Datas Importantes

| Data | Evento |
|---|---|
| 11/04/2026 | Publicação do enunciado |
| 09/06/2026 | Entrega do projeto (Moodle, até às 23:59) |
| 18/06/2026 | Defesa individual |

---

## 📝 Notas

- Todos os registos ficam associados ao utilizador autenticado (criação e alteração)
- O orçamento mensal é único por mês; ultrapassá-lo gera um alerta visível durante a compra
- Uma compra fechada não pode ser editada
- Itens não previstos são registados diretamente como adquiridos

---

*Projeto Final — Desenvolvimento de Aplicações 2025/2026*
*Curso Técnico Superior Profissional de Programação de Sistemas de Informação — ESTG, Politécnico de Leiria*
