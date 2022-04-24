namespace SistemaBancoByteCode
{
    public class ContaCorrente
    {
        public Cliente titular;
        public Cliente cpf;
        public Cliente rg;
        public Cliente profissao;
        public Cliente bairro;
        public Cliente numero;
        public Cliente nomDaRua;
        public Cliente primeiroDinheiro;
        public int numeroDaConta;
        public int agencia;
        public double saldo;

        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return true;
            }
            this.saldo -= valor;
            return false;
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestinataria)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.Depositar(valor);
            this.saldo -= valor;
            return true;
        }
    }
}
