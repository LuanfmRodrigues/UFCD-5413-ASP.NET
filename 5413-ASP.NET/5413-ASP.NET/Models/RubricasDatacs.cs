namespace _5413_ASP.NET.Models
{
    public class RubricasDatacs
    {

        public List<Rubrica> Rubricas { get; }

        public RubricasDatacs()
        {
            Rubricas = new List<Rubrica>();
            DataSource();

        }

        private void DataSource()
        {
            Rubricas.Add(new Rubrica(2, "Prestação de Serviços", CategoriasRubricas.Receita, 1, true));
            Rubricas.Add(new Rubrica(5, "Quotas", CategoriasRubricas.Receita, 2, true));
            Rubricas.Add(new Rubrica(6, "Matriculas e Mensalidades", CategoriasRubricas.Receita, 3, true));
            Rubricas.Add(new Rubrica(15, "Outros Rendimentos", CategoriasRubricas.Receita, 4, true));
            Rubricas.Add(new Rubrica(37, "Gastos com Pessoal", CategoriasRubricas.Despesa, 5, true));
            Rubricas.Add(new Rubrica(21, "Trabalhos Especializados", CategoriasRubricas.Despesa, 6, true));
            Rubricas.Add(new Rubrica(25, "Reparação e Conservação", CategoriasRubricas.Despesa, 7, true));
            Rubricas.Add(new Rubrica(26, "Ferramentas", CategoriasRubricas.Despesa, 8, true));
            Rubricas.Add(new Rubrica(32, "Água", CategoriasRubricas.Despesa, 9, true));
            Rubricas.Add(new Rubrica(49, "Doações", CategoriasRubricas.Despesa, 10, true));
        }
    }
}
