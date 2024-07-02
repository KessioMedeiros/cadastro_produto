using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Projeto03.Entities
{
    public class Produto
    {
        private Guid? _idProduto;
        private string? _nome;
        private decimal? _preco;
        private int? _quantidade;
        private Fornecedor? _fornecedor;

        public Produto()
        {
            _idProduto = Guid.Empty;
            _nome = string.Empty;
            _preco = 0;
            _quantidade = 0;
            _fornecedor = new Fornecedor();
        }

        public Guid? IdProduto
        {
            set
            {
                if (value == Guid.Empty)
                    throw new ArgumentException("Campo obrigatório.");

                _idProduto = value;
            }
            get => _idProduto;
        }

        public string? Nome
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Campo obrigatório.");

                var regex = new Regex(@"^[A-Za-zÀ-Üà-ü\s]{6,50}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("campo deve conter minimo de 6 caracteres e maximo de 50");

                _nome = value;
            }
            get => _nome;
        }

        public decimal? Preco
        {
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Campo não pode ser zero.");

                _preco = value;
            }
            get => _preco;
        }

        public int? Quantidade
        {
            set
            {
                if (value < 0)
                    throw new ArgumentException("Informe uma quantidade maior o igual a zero.");

                _quantidade = value;
            }
            get => _quantidade;
        }

        public Fornecedor? Fornecedor
        {
            set => _fornecedor = value;
            get => _fornecedor;
        }


    }
}
