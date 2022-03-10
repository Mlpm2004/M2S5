namespace ClassExercicios.Entidades;
public class Macaco : Animal
{
    private string _som = "macaquice";
    private string _mov = "sobe em arvores";
    public string Som { get => _som; }
    public string Movimento { get => _mov; }

    public Macaco() { }
    public Macaco(string nome, int idade) : base(nome, idade) { }
}