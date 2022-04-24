namespace SistemaBancoByteCode
{
    public class ContaSalario
    {
        public Cliente titular;
        public Cliente cpf;
        public Cliente rg;
        public Cliente bairro;
        public Cliente numero;
        public Cliente nomeDaRua;
        public Cliente complemento;
        public Cliente primeiroDinheiro;
        public int agencia;
        public int numeroDaConta;
        public double saldo;

        public bool Depositar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo += valor;
                return true;
            }
        }

        public void Sacar(double valor)
        {
            this.Depositar(valor);
        }
    }
}