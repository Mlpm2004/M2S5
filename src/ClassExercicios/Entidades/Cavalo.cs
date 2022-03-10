namespace ClassExercicios.Entidades
{
    public class Cavalo : Animal
    {
        private string _som = "Relincha";
        private string _mov = "corre";
        public string Som { get => _som; }
        public string Movimento { get => _mov; }

        public Cavalo() { }
        public Cavalo(string nome, int idade) : base(nome, idade) { }

    }
}

