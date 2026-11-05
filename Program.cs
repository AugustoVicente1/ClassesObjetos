string nome = "Augusto";

 using ClassesObjetos; 

 Produto  p1 = new Produto();

 p1.Nome = "Notebook";
 p1.Preco = 3500.00m;

 p1.exibir();

 Produto p2 = new Produto();
 p2.Nome = "Mouse";
 p2.Preco = 100.00m; 

 p2.exibir();

 Conta.Depositar(100);
 Conta.Depositar(50); 

Conta conta_corrente = new Conta();
Conta conta_poupança = new Conta();
 
conta_corrente.Depositar(100);
conta_poupança.Depositar(50);

Console.WriteLine(Math.Round(10., 2));

