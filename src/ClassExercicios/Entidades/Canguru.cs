namespace ClassExercicios.Entidades;
public class Canguru : Animal
{
    private string _som = "não faz som";
    private string _mov = "pula";
    public string Som { get => _som; }
    public string Movimento { get => _mov; }

    public Canguru() { }
    public Canguru(string nome, int idade) : base(nome, idade) { }
}
