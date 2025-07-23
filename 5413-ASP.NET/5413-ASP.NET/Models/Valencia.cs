namespace _5413_ASP.NET.Models
{
    /// <summary>
    /// Numeração da área de atuação da valência
    /// </summary>
    public enum AreaValencia
       
    {
        Direção,            
        Senior,
        Saúde,
        Infância,
        Administrativa,
        Financeira,
        Qualidade

    }
    /// <summary>
    /// Class e suas propiedades da Valências da instituição
    /// </summary>
    public class Valencia
    {
        public int IdValencia { get; set; }
        public string? DescValencia { get; set; }
        public string? AbvValencia { get; set; }
        public AreaValencia AreaValencia { get; set; }

        public Valencia() { }


        /// <summary>
        /// Constructor da Classe Valencia com parâmetros
        /// </summary>
        /// <param name="idValencia"> indentificador da Valencia </param>
        /// <param name="descValencia">Descriçºao da valencia </param>
        /// <param name="abvValencia">Abreviatura da valencia </param>
        /// <param name="areaValencia">Area de atuação </param>
        public Valencia(int idValencia, string descValencia, string abvValencia, AreaValencia areaValencia)
        {
            this.IdValencia = idValencia;
            this.DescValencia = descValencia;
            this.AreaValencia = areaValencia;
            this.AbvValencia = abvValencia;
        }
    }
}
