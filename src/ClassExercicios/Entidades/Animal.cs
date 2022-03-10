namespace ClassExercicios.Entidades
{
    public class Animal
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string Som { get; set; }
        public string Movimento { get; set; }

        public Animal()
        {

        }
        public Animal( string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
