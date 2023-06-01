using System.ComponentModel.DataAnnotations;

namespace Projeto_Gamer2.Models
{
    public class Equipe
    {
        [Key]
        public int IdEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }
        public ICollection<Jogador> Jogador {get ; set ;}

        internal class FirstOrDefault : Equipe
        {
            private Func<object, bool> value;

            public FirstOrDefault(Func<object, bool> value)
            {
                this.value = value;
            }
        }
    }
}