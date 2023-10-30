# NET_GraphQL_API
 API .NET utilizando GraphQL para CRUD

http://localhost:5008/graphql/

Detalhes dos endpoints

Listar todos as montadoras:

query{
  montadoras{
    id,
    nome
  }
}

Pesquisar uma montadora:

query{
  montadorasById(montadoraId: 1){
    id,
    nome
  }
}

parameter: "montadoraId", do tipo (int) contendo o código da montadora

Listar todos os carros:

query{
  carros{
    id,
    nome,
    montadoraId
  }
}

Listar todos os carros por montadora:

query{
  carrosByMontadora(montadoraId: 1){
    id,
    nome,
    montadoraId
  }
}

parameter: "montadoraId", do tipo (int) contendo o código da montadora

Pesquisar um carro:

query{
  carroById(carroId: 1){
    id,
    nome,
    montadoraId
  }
}

parameter: "carroId", do tipo (int) contendo o código do carro

Inserir um carro:

mutation{
  CreateCarro(carroInput: {
    id: XX,
    nome: "Carro"
    montadoraId: Y
  })
  {
    id,
    nome,
    montadoraId
  }
}

body: "id" do tipo (int) contendo o id único na lista de carros, "nome" do tipo (string) contendo o nome do carro; "montadoraId" do tipo (int) contendo o id da montadora do carro

Atualizar um carro:

mutation{
  UpdateCarro(carroId: XX, carroInput:  {
    id: XX,
    nome: "Novo Nome"
    montadoraId : YY
  })
  {
    id,
    nome,
    montadoraId
  }
}

parameter: "carroId", do tipo (int) contendo o código do carro

body: "id" do tipo (int) contendo o id único na lista de carros, "nome" do tipo (string) contendo o nome do carro; "montadoraId" do tipo (int) contendo o id da montadora do carro

Deletar um carro:

mutation{
  DeleteCarro(carroId: 13)
}

parameter: "id", do tipo (int) contendo o código do carro