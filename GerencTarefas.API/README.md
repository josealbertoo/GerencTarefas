
<h1 align="center">
	Fundamentos do C#
</h1>

<p align="center">
  <a href="#-sobre-o-projeto">Sobre</a> •
  <a href="#-funcionalidades">Funcionalidades</a> •
  <a href="#-rodando-a-aplicação">Rodando a aplicação</a> •
</p>

<br/>


## 💻 Sobre o projeto

Projeto desenvolvido no Desafio prático - Gerenciador de tarefas da [Rocketseat](https://www.rocketseat.com.br/),
Seu principal objetivo é desenvolver uma API para um sistema Gerenciador de tarefas.
O sistema deve permitir que o usuário crie, visualize, edite e exclua uma tarefa.

---

## ⚙️ Funcionalidades

Arquitetura em camadas


Como visto em aula, é uma boa prática dividirmos a nossa aplicação em camadas. 
Por isso, o seu projeto deve conter: 

- Camada de comunicação
- Camada de regras de negócios

---

Dados e campos sugeridos


Uma tarefa deverá ter os seguintes campos:

- Um id único pra identificar cada tarefa;
- Um nome;
- Uma descrição sobre o que é a tarefa em si;
- Uma prioridade;
*Você pode definir se tem prioridade* `alta`, `média` *ou* `baixa`*, por exemplo;*
- Uma data limite para tarefa ser realizada;
- Um status.
*Você pode definir três status:* `concluída`*,* `em andamento` *e* `aguardando`*, por exemplo.*

---


Endpoints necessários

- Deve ser possível criar uma tarefa;
- Deve ser possível visualizar todas as tarefas criadas;
- Deve ser possível visualizar uma tarefa buscando pelo seu id;
- Deve ser possível editar informações de uma tarefa;
- Deve ser possível excluir uma tarefa.

Lembre-se de retornar *status code* apropriados pra cada situação! 😉


---

## 🧭 Rodando a aplicação

```bash
# Clone este repositório

$ git clone https://github.com/josealbertoo/GerencTarefas
```


