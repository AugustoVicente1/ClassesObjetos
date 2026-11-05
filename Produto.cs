namespace ClassesObjetos
 {
    public class Produto
    {
         //  int Quantidade; => Campo: é uma forma simplicficada de representar atributos de uma classe, mas não é a forma mais recomendada.
        public string? Nome { get; set; }
         public decimal Preco { get; private set; }
        

 public void exibir()
     {
         Console.WriteLine($"Nome: {Nome}, Preço: {Preco:C}");
        }
    }
}
