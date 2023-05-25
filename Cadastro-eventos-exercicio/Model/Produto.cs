namespace Cadastro_eventos_exercicio.Model
{
    public class Produto
    {
        public string Nome{get; set;}
        public string Descricao{get; set;}
        public DateTime Data {get; set;}

        private const string PATH = "Database/Produto.csv";

        public Produto()
        {
            string pasta = PATH.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            if (File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        public List<Produto> Ler()
        {
            List<Produto> produtos = new List<Produto>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] atributos = item.Split(";");

                Produto p = new Produto();

                p.Nome = atributos[0];//001
                p.Descricao = atributos[1];
                p.Data = DateTime.Parse(atributos[2]);

                produtos.Add(p);
            }
            return produtos;
        }
        public string PrepararLinhasCSV(Produto p)
        {
            return $"{p.Nome};{p.Descricao};{p.Data}";
        }
        public void Inserir(Produto p)
        {
            string[] linhas = {PrepararLinhasCSV(p)};
        }

    }
}