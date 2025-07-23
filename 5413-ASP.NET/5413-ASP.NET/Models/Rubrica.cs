namespace _5413_ASP.NET.Models
{
    public enum CategoriasRubricas
    {
        Receita,
        Despesa,
        geral
       
    }
    
    public class Rubrica
    {
        public int IdRubrica { get; set; }
        public string? DescRubrica { get; set; }
        public CategoriasRubricas Categoria { get; set; }
        public int OrdemRubrica { get; set; }
        public bool? Ativo { get; set; }


        public Rubrica() { }

        public Rubrica(int idRubrica, string descRubrica, CategoriasRubricas categoria, int ordem, bool ativo)
        {
            this.IdRubrica = idRubrica;
            this.DescRubrica = descRubrica;
            this.Categoria = categoria;
            this.OrdemRubrica = ordem;
            this.Ativo = ativo;
        }
    }
}
