namespace EX02;

public class Nafta : Abastecimentos
{

    public Nafta (string nome, decimal valorInicial): base (nome, valorInicial)
    {


    }
    public override void ExecutarTransacoesdeFimdeMes()
    {
        if (ValorAcumulado > 0 ){
            decimal juros = ValorAcumulado * 0.02m;
            EfetuarDeposito(juros, DateTime.Now, "Ajuste para Nafta");

        }
    }
}