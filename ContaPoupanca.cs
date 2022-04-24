namespace SistemaBancoByteCode
{
    public class ContaPoupanca
    {
        public Cliente titular;
        public Cliente cpf;
        public Cliente rg;
        public Cliente profissao;
        public Cliente bairro;
        public Cliente numero;
        public Cliente nomeDaRua;
        public Cliente complemento;
        public Cliente primeiroDinheiro;
        public int agencia;
        public int numeroDaConta;
        public double saldo = 100;
        public int contadorMes = 1;

        public bool Sacar(double valor)
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

        public void Depositar(double valor)
        {
            this.Sacar(valor);
        }

        public void Render(double valor)
        {
            this.saldo = valor;
            while (contadorMes >= 1 && contadorMes <= 12)
            {
                this.saldo = this.saldo + this.saldo * (0.36 / 100);
            }
        }
    }
}