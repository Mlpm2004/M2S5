namespace ClassExercicios.Entidades;
public class Papagaio : Animal
{
    private string _som = "fala";
    private string _mov = "voa";
    public string Som { get => _som; }
    public string Movimento { get => _mov; }

    public Papagaio() { }
    public Papagaio(string nome, int idade) : base(nome, idade) { }
}