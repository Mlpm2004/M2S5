namespace ClassExercicios.Entidades;
    public class Tubarao : Animal
{
    private string _som = "não faz som";
    private string _mov = "nada";
    public string Som { get => _som; }
    public string Movimento { get => _mov; }

    public Tubarao() { }
    public Tubarao(string nome, int idade) : base(nome, idade) { }
}