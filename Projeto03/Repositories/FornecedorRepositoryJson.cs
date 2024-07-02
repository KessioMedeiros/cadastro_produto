using Newtonsoft.Json;
using Projeto03.Entities;
using Projeto03.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.Repositories
{
    public class FornecedorRepositoryJson : IFornecedorRepository
    {
        public void Exportar(Fornecedor fornecedor)
        {
            var json = JsonConvert.SerializeObject(fornecedor, Formatting.Indented);
            var streamWriter = new StreamWriter($"c:\\temp\\fornecedor_{fornecedor.IdFornecedor}.json");
            streamWriter.Write(json);
            streamWriter.Write("\n");
            streamWriter.Close();
        }
    }
}
