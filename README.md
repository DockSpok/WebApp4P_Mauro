# WebApp4P_Mauro
TesteApi4P

# WebApp4P
Solução de uma API desenvolvida em C# .NET 

Para executar a solução faça um clone desse repositório em sua máquina local.
Com a solução aberta no Visual Studio realize o Build.
Use as URLs abaixo para testar a API na ferramenta de sua preferencia, RestMan, PostMan, etc.

Para acessar as rotas da Api use http://localhost:xxxxx/Help
xxxxx = porta

As rotas ainda seguem a convenção de nomes dos verbos http, não estão nomeadas conforme o projeto.

JSON das entidades:
// POST: api/Funcionarios
{
  "Id": 1,
  "Nome": "sample string 2",
  "DataCriacaoRegistro": "2019-12-16T21:18:41.4464683-03:00",
  "DataAtualizacaoRegistro": "2019-12-16T21:18:41.4464683-03:00"
}

// POST: api/Enderecos
 {
   "Id": 1,
   "IdPessoa": 1,
   "CEP": 1
 }
