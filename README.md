# T3 - Backend DSW
Web service para gerenciar tarefas da SPA React.

## Como Rodar
- **Local**: 
  - Backend: `dotnet run` (na pasta `C:\Users\nivea\Downloads\TodoWebService`)
  - Frontend: `npm start` (na pasta `D:\Área de Trabalho\projeto2-dsw`)
- Acesse: `http://localhost/api/todos` (Backend) / `http://localhost:3000` (Frontend)
- **Docker**: Configurado, mas enfrentou problemas de conexão com o daemon no ambiente local (pendente).

## Endpoints
- GET /api/todos: Listar
- POST /api/todos: Inserir
- PUT /api/todos/{id}: Atualizar uma tarefa existente
- DELETE /api/todos/{id}: Deletar

## Evidências
As evidências estão organizadas na pasta `assets/`:
- ---
- <img src="assets/GET_inicial.png" alt="[GET]" width="380"/> - Listagem vazia antes de inserir tarefas
- <img src="assets/Post.png" alt="[POST]" width="380"/> - Criação de uma tarefa
- <img src="assets/Put.png" alt="[PUT]" width="380"/> - Atualização de uma tarefa
- <img src="assets/Delete.png" alt="[DELETE]" width="380"/> - Exclusão de uma tarefa
- <img src="assets/GET_apos_delete.png" alt="[GET]" width="380"/> - Listagem vazia após deletar todas as tarefas
- <img src="assets/spa.png" alt="[SPA]" width="450"/> - Interface da SPA com uma tarefa adicionada

## Sequência da SPA
Veja a sequência completa de uso da SPA em: [Apresentação SPA](assets/Apresentacao_SPA_Niveah4_500028.pdf)