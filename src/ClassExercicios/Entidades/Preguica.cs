namespace ClassExercicios.Entidades
{
    public class Preguica : Animal
    {
        private string _som = "Grune";
        private string _mov = "sobe em arvore";
        public string Som { get => _som; }
        public string Movimento { get => _mov; }

        public Preguica() { }
        public Preguica(string nome, int idade) : base(nome, idade) { }
    }
}
