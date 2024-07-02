using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Projeto03.Entities
{/// <summary>
/// Modelo de entidade para fornecedor
/// </summary>
    public class Fornecedor
    {
        private Guid? _idFornecedor;
        private string? _nome;
        private string? _cnpj;
        private List<Produto>? _produtos;

        public Fornecedor()
        {
            _idFornecedor = Guid.Empty;
            _nome = string.Empty;
            _cnpj = string.Empty;
            _produtos = new List<Produto>();
        }

        public Guid? IdFornecedor
        {
            set
            {

                if (value == Guid.Empty)
                    throw new ArgumentException("Campo obrigatório.");

                _idFornecedor = value;
            }
            get => _idFornecedor;
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

        public string? Cnpj
        {
            set
            {

                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Campo obrigatório.");

                var regex = new Regex("^[0-9]{11}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("campo deve conter exatos 11 digitos.");

                _cnpj = value;
            }
            get => _cnpj;
        }

        public List<Produto>? Produtos
        {
            set => _produtos = value;
            get => _produtos;
        }
    }
}
