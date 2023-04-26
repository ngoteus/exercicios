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
<<<<<<< HEAD
            return "0";
=======
            return "";
>>>>>>> 1ce3d968c45048f1ea48b18d8bdce03949e04a61
        }
        
        public string ligacao()
        {
            Console.WriteLine($"Chamada efetuada.");
<<<<<<< HEAD
            return "0";
        }
        public string mensagem()
        {
            Console.WriteLine($"chamada enviada com sucesso.");
            return "0";
=======
            return "";
        }
        public string mensagem()
        {
            Console.WriteLine($"mensagem enviada com sucesso.");
            return "";
>>>>>>> 1ce3d968c45048f1ea48b18d8bdce03949e04a61
        }
        public string desligar()
        {
            ligado=false;
            Console.WriteLine($"o celular desligou.");
<<<<<<< HEAD
            return "0";
=======
            return "";
>>>>>>> 1ce3d968c45048f1ea48b18d8bdce03949e04a61
        }
    }
}