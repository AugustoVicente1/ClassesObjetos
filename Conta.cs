namespace ClassesObjetos
{
    public static class Conta
    {
        public static decimal Saldo = 0;

        public static void Depositar(decimal valor)
        { //Saldo = Saldo + valor;
            Console.WriteLine($"Saldo atualizado: {valor:C}");            
        }
    }
}