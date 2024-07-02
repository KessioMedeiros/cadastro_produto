using Projeto03.Controllers;
using Projeto03.Repositories;
using System.Security.Cryptography;

var fornecedorController = new FornecedorController();

Console.Write("ESCOLHA (1) JSON (2) XML.....: ");
var opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        fornecedorController.CadastrarFornecedor(new FornecedorRepositoryJson());
        break;

    case 2:
        fornecedorController.CadastrarFornecedor(new FornecedorRepositoryXml());
        break;
}