
namespace ClassExercicios.Entidades
{
    public class Cobra:Animal
    {
        private string _som = "Sibila";
        private string _mov = "rasteja";
        public string Som { get => _som; }
        public string Movimento { get => _mov; }

        public Cobra() { }
        public Cobra(string nome, int idade) : base(nome, idade) { }
    }
}
