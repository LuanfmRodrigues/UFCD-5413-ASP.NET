namespace _5413_ASP.NET.Models
{
   
    public class MapaFinanceiro
    {
        public List<Movimento> Mapa { get;  }

        public MapaFinanceiro()
        {
            Mapa = new List<Movimento>();
            DataSource();
        }


        private void DataSource() 
        {
            Mapa.Add(new Movimento(6,9845,1, 2025, TipoMovimento.Crédito, 12921.93));
            Mapa.Add(new Movimento(2, 9005,7, 2025, TipoMovimento.Crédito, 1451.93));
            Mapa.Add(new Movimento(37, 9115,1, 2025, TipoMovimento.Débito, 23421.91));
            Mapa.Add(new Movimento(5, 9845,9, 2025, TipoMovimento.Débito, 921.23));
            Mapa.Add(new Movimento(56, 9095,4, 2025, TipoMovimento.Crédito, 98231.23));
            Mapa.Add(new Movimento(2, 8115, 1, 2025, TipoMovimento.Débito, 1324.77));
            Mapa.Add(new Movimento(6, 9000, 3, 2025, TipoMovimento.Crédito, 1324.21));
            Mapa.Add(new Movimento(22, 6223, 8, 2025, TipoMovimento.Débito, 1312.22));
            Mapa.Add(new Movimento(49, 9242, 6, 2025, TipoMovimento.Débito, 2426.52));
            Mapa.Add(new Movimento(32, 9245, 1, 2025, TipoMovimento.Débito, 3.57));
            Mapa.Add(new Movimento(15, 9003, 2, 2025, TipoMovimento.Crédito, 21371.25));
            Mapa.Add(new Movimento(25, 9011, 4, 2025, TipoMovimento.Débito, 272.04));

        }
    }
}
