namespace Console_mvc.Model
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        private const string PATH = "Database/Produto.csv";

        public Produto()
        {
            string pasta = PATH.Split("/")[0]; //Database

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            if (!File.Exists(PATH))
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

                p.Codigo = int.Parse(atributos[0]);//001
                p.Nome = atributos[1];//"Coca"
                p.Preco = float.Parse(atributos[2]);

                produtos.Add(p);
            }
            return produtos;
        }
        public string PrepararLinhasCSV(Produto p)
        {
            return $"{p.Codigo};{p.Nome};{p.Preco}";
        }
        public void Inserir(Produto p)
        {
            string[] linhas = {PrepararLinhasCSV(p)};

            File.AppendAllLines(PATH, linhas);
        }
    }
}