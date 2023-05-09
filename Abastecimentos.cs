namespace EX02;
public class Abastecimentos{

    public string Cliente {get; set;}

    public decimal ValorAcumulado{
        get{
            decimal valor = 0;
            foreach (var item in todasTransacoes){
                valor += item.Valor;
            }
            return valor;
        }
    }
    public Abastecimentos(string nome,decimal valorIncicial)
    {
        this.Cliente = nome;
        EfetuarDeposito(valorIncicial, DateTime.Now, "Valor Inicial");
    }
    private List <Transacoes> todasTransacoes = new List<Transacoes>();

    public void EfetuarDeposito(decimal valor, DateTime data, string descricao)
    {
        if (valor < 0){
            throw new ArgumentOutOfRangeException(nameof(valor),"A quantia de deposito deve ser positiva");
        }
        var deposito = new Transacoes(valor, data, descricao);
        todasTransacoes.Add(deposito);

    }
    public void EfetuarSaque(decimal valor, DateTime data, string Descricao)
    {
        if (valor < 0)
    {
        throw new ArgumentOutOfRangeException(nameof(valor), "A quantia de saque deve ser positiva");
    }

    if (ValorAcumulado- valor > 0)
    {
        throw new InvalidOperationException("Fundo não suficiente para este saque");
    }
    var saque = new Transacoes(-valor, data, Descricao);
    todasTransacoes.Add(saque);
    }
    public string ObterHistoricodeConta()
    {
        
        var relatorio = new System.Text.StringBuilder();

        decimal valor = 0m;
        relatorio.AppendLine("Data\t\tQuantia\tSaldo\tNota");
        foreach (var item in todasTransacoes)
        {
            valor +=  item.Valor;
            relatorio.AppendLine($"{item.Data.ToShortDateString()}\t{item.Valor}\t{valor}\t{item.Descricao} ");
        }
        return relatorio.ToString();
        }
        public virtual void ExecutarTransacoesdeFimdeMes(){ }

}