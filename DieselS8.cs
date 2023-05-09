namespace EX02;

public class  DieselS8 : Abastecimentos
{

    public DieselS8 (string nome, decimal valorInicial): base (nome, valorInicial)
    {


    }
    public override void ExecutarTransacoesdeFimdeMes()
    {
        if (ValorAcumulado > 0 ){
            decimal juros = ValorAcumulado * 0.03m;
            EfetuarDeposito(juros, DateTime.Now, "Ajuste para DieselS8");
            
        }
    }
}