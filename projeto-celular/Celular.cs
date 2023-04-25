namespace projeto_celular
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public float tamanho;
        public bool ligado;
        
        public string ligar()
        {
            Console.WriteLine($"O celular ligou");
            return 0;
        }
        
        public string ligacao()
        {
            Console.WriteLine($"Chamada efetuada.");
            return 0;
        }
        public string mensagem()
        {
            Console.WriteLine($"chamada enviada com sucesso.");
            return 0;
        }
        public string desligar()
        {
            Console.WriteLine($"o celular desligou.");
            return 0;
        }
    }
}