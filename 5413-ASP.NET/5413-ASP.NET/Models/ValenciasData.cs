using System.Collections.Generic;

namespace _5413_ASP.NET.Models
{


    /// <summary>
    /// estrutura de dados que contém uma lista de valências
    /// </summary>
    public class ValenciasData
    {
        public List<Valencia> Valencias { get; }
        /// <summary>
        /// constructor da classe ValenciasData, inicializa a lista de valências e chama o método DataSource para preencher a lista
        /// </summary>
        public ValenciasData()
        {
            Valencias = new List<Valencia>();
            DataSource();

        }
        /// <summary>
        /// dados de uma lista de valências, adiciona as valências à lista
        /// </summary>
        private void DataSource()
        {
            Valencias.Add(new Valencia(9045, "Farmacia Interna", "FarInt", AreaValencia.Saúde));
            Valencias.Add(new Valencia(9001, "Gestão de património", "G.Patrim", AreaValencia.Direção));
            Valencias.Add(new Valencia(9003, "Lar Residencial", "LarR", AreaValencia.Senior));
            Valencias.Add(new Valencia(9011, "Clinia de Reabilitação", "CliReab", AreaValencia.Saúde));
            Valencias.Add(new Valencia(9090, "Direção Geral", "DirGer", AreaValencia.Financeira));
            Valencias.Add(new Valencia(9242, "Unidade de Cuidados Continuados", "UCC", AreaValencia.Saúde));
            Valencias.Add(new Valencia(9245, "Creche", "cre", AreaValencia.Infância));
        }
    }
}
