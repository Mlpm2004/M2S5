namespace ClassExercicios.Entidades
{
    public class Empregado : Pessoa
    {
        public int CodigoSetor { get; set; }
        public decimal SalarioBase { get; set; }
        public decimal Imposto { get; set; }

        public Empregado(string nome, string telefone, string endereco,decimal salario, decimal imposto)
            : base(nome, telefone, endereco)
        {
            Imposto = imposto;
            SalarioBase = salario;  
        }
        public decimal CalcularSalario()
        {
            return SalarioBase * (1 - Imposto / 100);
        }
    }
}
