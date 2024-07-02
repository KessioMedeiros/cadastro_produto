using Projeto03.Entities;
using Projeto03.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Projeto03.Repositories
{
    public class FornecedorRepositoryXml : IFornecedorRepository
    {
        public void Exportar(Fornecedor fornecedor)
        {
            var xml = new XmlSerializer(fornecedor.GetType());
            var streamWriter = new StreamWriter($"c:\\temp\\fornecedor_{fornecedor.IdFornecedor}.xml");
            xml.Serialize(streamWriter, fornecedor);
            streamWriter.Close();
        }
    }
}
