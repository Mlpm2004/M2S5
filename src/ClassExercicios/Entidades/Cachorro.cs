namespace ClassExercicios.Entidades
{
    public class Cachorro:Animal
    {
        private string _som = "Late";
        private string _mov = "corre";
        public string Som       { get => _som;  }
        public string Movimento { get => _mov;  }

        public Cachorro() {  }
        public Cachorro( string nome, int idade):base(nome,idade) { }
    }
}

