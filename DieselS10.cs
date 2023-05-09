namespace EX02;

public class DieselS10 : Abastecimentos
{

    public DieselS10 (string nome, decimal valorInicial): base (nome, valorInicial)
    {


    }
    public override void ExecutarTransacoesdeFimdeMes()
    {
        if (ValorAcumulado > 0 ){
            decimal juros = ValorAcumulado * 0.02m;
            EfetuarDeposito(juros, DateTime.Now, "Ajuste para DieselS10");
            decimal bonus = 90m;
            EfetuarSaque(bonus, DateTime.Now, "Ajuste para DieselS10");
        }
    }
}