namespace ClassExercicios.Entidades;
public class Elefante : Animal
{
    private string _som = "fua";
    private string _mov = "caminha";
    public string Som { get => _som; }
    public string Movimento { get => _mov; }

    public Elefante() { }
    public Elefante(string nome, int idade) : base(nome, idade) { }
}