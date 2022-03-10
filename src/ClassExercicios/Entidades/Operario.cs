namespace ClassExercicios.Entidades
{
    public class Operario : Empregado
    {
        public decimal ValorProducao { get; set; }
        public decimal Comissao { get; set; }
        public Operario(string nome, string telefone, string endereco, decimal salario, decimal imposto,decimal valordeproducao,decimal comissao) : base(nome, telefone, endereco, salario, imposto)
        {
            ValorProducao = valordeproducao;
            Comissao = comissao;
        }
        public decimal CalcularSalario(decimal comissao)
        {
            return (SalarioBase + comissao) * (1 - Imposto / 100) ;
        }
    }
}
