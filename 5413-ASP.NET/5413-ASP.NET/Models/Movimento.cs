namespace _5413_ASP.NET.Models
{public enum TipoMovimento
    {
        Crédito,
        Débito
    }
    /// <summary>
    /// cria as propiedade da tabela
    /// </summary>
    public class Movimento
    {
        public int IdRubrica { get; set; }
        public int IdValencia { get; set; }

        public int Mes { get; set; }
        public int Ano { get; set; }
        public TipoMovimento TipoMovimento { get; set; }
        public double Valor { get; set; }


        /// <summary>
        /// seus parametros e cnstrutores
        /// </summary>
        public Movimento() { }

        public Movimento(int idRubrica, int idValencia, int mes, int ano, TipoMovimento tipo, double valor)
        {
            this.IdRubrica = idRubrica;
            this.IdValencia = idValencia;
            this.Mes = mes;
            this.Ano = ano;
            this.TipoMovimento = tipo;
            this.Valor = valor;
        }
    }
}
