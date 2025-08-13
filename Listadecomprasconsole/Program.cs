// See https://aka.ms/new-console-template for more information
//Cria uma lista vazia com a variavel string que vai conter todos itens que o usuario digitar
List<string> itensDeCompras = new List<string>();

//Introdução e boas vindas
Console.WriteLine("--- Minha Lista de Compras ---");
Console.WriteLine("Digite os itens que deseja adicionar. Digite 'fim' para terminar.");

//Cria o loop para inserir os itens e pedir os itens até o break
while (true)
{
 //Pede os itens e os lê, salvando-os na string item.
    Console.Write("Adicionar item: ");
    string item = Console.ReadLine() ?? "";

    //Coloca um fim no loop se for digitado fim.
    //item.ToLower() certifica que fim pode ser escrito com letras maiusculas mas será convertido pra minusculas
    //para que funcione o "if".
    if (item.ToLower() == "fim")
    {
        break;
    }
    //Se nao for encerrado, adiciona oque foi digitado na List
    itensDeCompras.Add(item);
}

//Quando encerrado o loop apresenta o titulo final da lista de compras completa
//(/n pula uma linha e a deixa em branco) 
Console.WriteLine("\n--- Sua Lista de Compra Final ---");

//Para cada item dentro da lista "itensDeCompras", é enviado para a "itemDaLista"
//e imediatamente impresso em uma linha diferente
foreach (string itemDaLista in itensDeCompras)
{
    Console.WriteLine($"- {itemDaLista}[ ]");
}



