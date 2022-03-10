
namespace ClassExercicios.Entidades
{
    public class Administrador : Empregado

    {
        public decimal AjudadeCusto { get; set; }
        public Administrador(string nome, string telefone, string endereco, decimal salario, decimal imposto,decimal ajudadecusto) : base(nome, telefone, endereco, salario, imposto)
        {
            AjudadeCusto = ajudadecusto;
        }
        public decimal CalcularSalario(decimal ajuda)
        {
            return (SalarioBase + ajuda) * (1 - Imposto / 100) ;
        }
    }
}
