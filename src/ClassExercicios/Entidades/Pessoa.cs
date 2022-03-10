namespace ClassExercicios.Entidades
{
    public class Pessoa
    {
        public string Nome { get ; set ; }
        public string Endereco { get ; set ; }
        public string Telefone { get ; set ; }

        public Pessoa() { }

        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public Pessoa(string endereco, string telefone)
        {
            Endereco = endereco;
            Telefone = telefone;
        }
        public Pessoa(string nome, string telefone,string endereco)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;

        }



    }
}
