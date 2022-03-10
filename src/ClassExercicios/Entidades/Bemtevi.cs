namespace ClassExercicios.Entidades;
public class Bemtevi : Animal
{
    private string _som = " faz Bem te vi";
    private string _mov = "voa";
    public string Som { get => _som; }
    public string Movimento { get => _mov; }

    public Bemtevi() { }
    public Bemtevi(string nome, int idade) : base(nome, idade) { }
}