using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        // TRABALHANDO COM LISTA (LIST)
        // Criando uma lista
        List<string> frutas = new List<string>();

        //Adicionar itens na lista
        frutas.Add("Morango");
        frutas.Add("Manga");
        frutas.Add("Goiaba");
        frutas.Add("Uva");

        // Imprimir os Itens da Lista
        Console.WriteLine("Minha lista de frutas:");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        Console.WriteLine(); //Pula linha em Branco

        // Imprimir elemento no índice específico
        Console.WriteLine("Fruta na indice 2:" + frutas[2]); //obs: índice sempre começa em 0


        // Inserindo um elemento no índice específico -> Adição 
        frutas.Insert(1, "Maracujá");

        Console.WriteLine(); //Pula linha em Branco

        // Impressão da lista em uma única linha
        frutas.ForEach(Console.WriteLine);

        // Alterar um elemento no índice específico -> Substituição
        frutas[4] = "Pêra";

        Console.WriteLine(); //Pula linha em Branco

        // Impressão da lista em uma única linha
        frutas.ForEach(Console.WriteLine);

        // Remover elementos da lista do índice específico 
        frutas.RemoveAt(3);

        // Remover elementos pelo valor do conteúdo
        frutas.Remove("Morango");

        Console.WriteLine(); //Pula linha em Branco

        // Impressão da lista em uma única linha
        frutas.ForEach(Console.WriteLine);

        // Apagar todos os elementos da lista
        frutas.Clear();

        //Minha tentativa falha de função:
        //FunctionPointerAttributes(frutas);
        //{
        //    Console.WriteLine(); //Pula linha em Branco
        //    Console.WriteLine("Minha lista de frutas:");
        //    foreach (string fruta in frutas)
        //    {
        //        Console.WriteLine(fruta);
        //    }
        //}

        // Impressão da lista em uma única linha
        frutas.ForEach(Console.WriteLine);

        //(----------------------------------------------------------------------------------------------------------------)

        // TRABALHANDO COM DICIONÁRIO (DICTIONARY)

        // Criando um Dicionário de Dados
        Dictionary<int, string> carros = new Dictionary<int, string>();
        // Adicionar Dados a um Dicionário
        carros.Add(5, "Combe");
        carros.Add(10, "Fusca");
        carros.Add(2, "McQueen");

        // Imprimir um Dicionário de Dados 
        foreach (var carro in carros)
        {
            Console.WriteLine($"{carro.Key} - {carro.Value}");
        }

    }
}