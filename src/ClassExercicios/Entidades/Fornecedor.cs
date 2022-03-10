
namespace ClassExercicios.Entidades
{
    public class Fornecedor : Pessoa
    {
        public double ValorCredito { get;  set; }
        public double ValorDivida { get;  set; } 
        
        public double ObterSaldo()
        {
            return ValorCredito - ValorDivida;

        }
        public Fornecedor(string nome, string telefone, string endereco, double valorcredito,double valordivida)
            : base(nome, telefone, endereco) 
        { 
            ValorCredito = valorcredito; 
            ValorDivida = valordivida;
        }

    }
}
