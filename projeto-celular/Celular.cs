namespace projeto_celular
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public float tamanho;
        public bool ligado = false;
        
        public string ligar()
        {
            ligado =true;
            Console.WriteLine($"O celular ligou");
            return "";
        }
        
        public string ligacao()
        {
            Console.WriteLine($"Chamada efetuada.");
            return "";
        }
        public string mensagem()
        {
            Console.WriteLine($"mensagem enviada com sucesso.");
            return "";
        }
        public string desligar()
        {
            ligado=false;
            Console.WriteLine($"o celular desligou.");
            return "";
        }
    }
}