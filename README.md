# 🕸️ Lista de Exercícios – Sistemas Distribuídos

# Aluno: Alice Barros Viana

# [README COM OS RESULTADOS DA MINHA ATIVIDADE](ReadmeApi.md)
## Exercício: SpiderNet API – Registro de Missões do Homem-Aranha

### 📌 Orientações
- A atividade pode ser realizada **individualmente ou em equipes de até 05 alunos**.
- Deve ser entregue **até a data definida em aula**.
- O código deve ser desenvolvido em **C# utilizando .NET 10**.
- A API deve seguir o **padrão MVC (Model–View–Controller)**.
- O código deve estar **bem organizado e devidamente indentado**.
- O projeto deve ser **versionado no GitHub pessoal de cada aluno**.
- Entregar **apenas a URL do repositório** na plataforma indicada em aula.

---

# 🕷️ Exercício Prático  
## SpiderNet API – Sistema Distribuído de Registro de Missões do Homem-Aranha

### 🧠 Contexto

Após os eventos envolvendo o multiverso, **Peter Parker (interpretado por Tom Holland)** continua atuando como o **Homem-Aranha em Nova York**, mas agora precisa de um sistema para registrar e consultar suas missões de forma organizada.

Para ajudar o herói, **Ned Leeds decidiu criar uma API distribuída chamada `SpiderNetApi`**, que permite registrar ocorrências enfrentadas pelo Homem-Aranha e consultar o histórico de missões realizadas.

Essa API funcionará como um **serviço de registro de missões**, permitindo que diferentes aplicações (apps da polícia, sistemas dos Vingadores ou o próprio traje Stark do Peter) possam consultar ou registrar novas atividades do herói.

---

# 🎯 O Desafio

Você deverá criar uma **Web API em .NET 10 chamada `SpiderNetApi`**.

O objetivo da API é **registrar e consultar missões do Homem-Aranha**, utilizando métodos **GET** e **POST**.

---

# ⚙️ Requisitos Técnicos

### 1️⃣ Criação do Modelo

Crie uma classe (ou `record`) chamada:

```

MissaoAranha.cs

````

Ela deve possuir as seguintes propriedades:

```csharp
Id (int)
VilaoEnfrentado (string)
Localizacao (string)
NivelPerigo (int)
Resolvido (bool)
````

---

### 2️⃣ Criação do Controller

Crie um controller chamado:

```
MissoesController.cs
```

Utilize a rota:

```csharp
[Route("api/[controller]")]
```

---

### 3️⃣ Simulação de Banco de Dados

Dentro do controller, crie uma estrutura que simule um banco de dados em memória:

```csharp
static List<MissaoAranha>
```

Essa lista armazenará todas as missões registradas.

---

### 4️⃣ Método GET – Consultar Missões

Implemente um método **GET** que retorne **todas as missões registradas**.

Exemplo de endpoint:

```
GET /api/missoes
```

Esse método deverá retornar a lista completa de missões do Homem-Aranha.

---

### 5️⃣ Método POST – Registrar Nova Missão

Implemente um método **POST** que receba um objeto `MissaoAranha` no corpo da requisição e o adicione à lista.

Exemplo de endpoint:

```
POST /api/missoes
```

---

### 6️⃣ Diferencial (Lógica Opcional)

Implemente uma validação no método **POST**:

* O campo **NivelPerigo** deve estar entre **1 e 10**.
* Caso o valor seja inválido, a API deve retornar:

```
BadRequest()
```

---

# 📦 Exemplo de JSON para o POST

```json
{
  "id": 1,
  "vilaoEnfrentado": "Duende Verde",
  "localizacao": "Ponte de Queensboro",
  "nivelPerigo": 9,
  "resolvido": true
}
```

Outro exemplo:

```json
{
  "id": 2,
  "vilaoEnfrentado": "Doutor Octopus",
  "localizacao": "Laboratório Stark abandonado",
  "nivelPerigo": 8,
  "resolvido": false
}
```

---

# 🧪 Testes da API

Teste sua API utilizando ferramentas como:

* **Swagger**
* **Postman**
* **Bruno**
* **arquivo `.http`**

Você deverá demonstrar:

1️⃣ Um **POST** registrando uma nova missão
2️⃣ Um **GET** retornando a lista de missões registradas

---

# 📁 Entrega e Submissão

Para realizar a entrega, siga os passos abaixo para garantir o versionamento correto do seu nó da rede SpideySense:

### 1️⃣ Fluxo de Trabalho no GitHub
1. Clique no botão **Fork**, localizado no canto superior direito deste repositório, para criar uma cópia em sua conta pessoal.
2. Clone o **seu fork** para sua máquina local.
3. Desenvolva a solução em .NET 10.
4. Faça o `commit` e `push` das alterações para o seu GitHub.

### 2️⃣ O que o Repositório deve conter:
- [ ] **Código Fonte:** A Solution completa da Web API.
- [ ] **Arquitetura:** Estrutura MVC organizada (Controllers, Models).
- [ ] **Evidências:** Prints do Swagger/Postman ou um arquivo `.http` demonstrando os métodos GET e POST funcionando.

### 3️⃣ Envio Final
Após finalizar, copie a URL do **seu repositório** (ex: `https://github.com/seu-usuario/sdm-challenge-spider-man-01`) e envie na plataforma indicada em aula.

> ⚠️ **Atenção:** Certifique-se de que o repositório esteja configurado como **Público** para que o professor possa avaliar o código.

---

### 2️⃣ Demonstração

O repositório deve mostrar:

✔ Um **POST funcionando**
✔ Um **GET retornando os dados registrados**

---

# 💡 Dica

Lembre-se que a lista criada é **estática e armazenada em memória**.

Isso significa que **os dados serão perdidos ao reiniciar a aplicação**.

Em um **sistema distribuído real**, utilizaríamos tecnologias como:

* **SQL Server**
* SQLite
* **MongoDB**
* **Redis**
* **Azure Cosmos DB**

para persistência de dados entre serviços.

---

# 🕷️ Frase motivacional do Peter Parker

> “Com grandes poderes vêm grandes responsabilidades.”

Agora é sua vez de ajudar o Homem-Aranha a organizar suas missões usando **APIs e Sistemas Distribuídos**! 🕸️
