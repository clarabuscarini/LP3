using EX02;

var Nafta = new Nafta ("Cliente01", 0);
Nafta.EfetuarDeposito(30, DateTime.Now, "Nafta");
Nafta.ExecutarTransacoesdeFimdeMes();
Console.WriteLine(Nafta.ObterHistoricodeConta());

var GNV = new GNV ("Cliente02", 0);
GNV.EfetuarDeposito(40, DateTime.Now, "GNV");
GNV.ExecutarTransacoesdeFimdeMes();
Console.WriteLine(GNV.ObterHistoricodeConta());

var DieselS10 = new DieselS10 ("Cliente03", 0);
DieselS10.EfetuarDeposito(30, DateTime.Now, "DieselS10");
DieselS10.ExecutarTransacoesdeFimdeMes();
Console.WriteLine(DieselS10.ObterHistoricodeConta());

var DieselS8 = new DieselS8 ("Cliente04", 0);
DieselS8.EfetuarDeposito(50, DateTime.Now, "DieselS8");
DieselS8.ExecutarTransacoesdeFimdeMes();
Console.WriteLine(DieselS8.ObterHistoricodeConta());

