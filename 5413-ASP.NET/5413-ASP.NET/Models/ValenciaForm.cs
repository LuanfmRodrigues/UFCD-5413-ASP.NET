using System.ComponentModel.DataAnnotations;

namespace _5413_ASP.NET.Models
{

    /// <summary>
    /// Class e suas propiedades da Valências da instituição
    /// </summary>
    public class ValenciaForm
    {
        public int IdValencia { get; set; }

        [Required(ErrorMessage = "A descrição da valência é obrigatória.")]
        public string? DescValencia { get; set; }

        [Required(ErrorMessage = "A abreviatura da valência é obrigatória.")]
        public string? AbvValencia { get; set; }
        public AreaValencia AreaValencia { get; set; }

        public ValenciaForm() { }


        /// <summary>
        /// Constructor da Classe Valencia com parâmetros
        /// </summary>
        /// <param name="idValencia"> indentificador da Valencia </param>
        /// <param name="descValencia">Descriçºao da valencia </param>
        /// <param name="abvValencia">Abreviatura da valencia </param>
        /// <param name="areaValencia">Area de atuação </param>
        public ValenciaForm(int idValencia, string descValencia, string abvValencia, AreaValencia areaValencia)
        {
            this.IdValencia = idValencia;
            this.DescValencia = descValencia;
            this.AreaValencia = areaValencia;
            this.AbvValencia = abvValencia;
        }
    }
}
