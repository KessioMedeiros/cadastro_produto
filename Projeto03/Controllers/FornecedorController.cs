using Projeto03.Entities;
using Projeto03.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.Controllers
{
    public class FornecedorController
    {
        public void CadastrarFornecedor(IFornecedorRepository fornecedorRepository)
        {
            Console.WriteLine("\tCADASTRO DE FORNECEDOR");

            try
            {
                var fornecedor = new Fornecedor();

                Console.Write("NOME DO FORNECEDOR...........: ");
                fornecedor.Nome = Console.ReadLine();

                Console.Write("CNPJ.........................: ");
                fornecedor.Cnpj = Console.ReadLine();

                for (int i = 1; i <= 2; i++)
                {
                    Console.WriteLine($"\t\nINFORME O {i} PRODUTO: \n");

                    var produto = new Produto();

                    Console.Write("NOME DO PRODUTO.........: ");
                    produto.Nome = Console.ReadLine();

                    Console.Write("PREÇO...................: ");
                    produto.Preco = decimal.Parse(Console.ReadLine());

                    Console.Write("QUANTIDADE..............: ");
                    produto.Quantidade = int.Parse(Console.ReadLine());

                    fornecedor.Produtos.Add(produto);
                }

                fornecedorRepository.Exportar(fornecedor);

                Console.WriteLine("\nDADOS SALVOS COM SUCESSO!");

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("\nFalha: " + e.Message);
            }
        }
    }
}
