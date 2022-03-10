namespace ClassExercicios.Entidades
{
    public class Vendedor : Empregado
    {
        public decimal ValorVendas { get; set; }
        public decimal Comissao { get; set; }
        public Vendedor(string nome, string telefone, string endereco, decimal salario, decimal imposto,decimal valorvendas,decimal comissao) : base(nome, telefone, endereco, salario, imposto)
        {
            ValorVendas = valorvendas;
            Comissao = comissao;
        }
        public decimal CalcularSalario(decimal comissao)
        {
            return (SalarioBase + comissao) * (1 - Imposto / 100);
        }


    }
}
