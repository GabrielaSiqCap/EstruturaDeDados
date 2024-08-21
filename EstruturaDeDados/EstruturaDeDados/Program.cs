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
        Console.WriteLine(); //Pula linha em branco
        Console.WriteLine("==========================");
        Console.WriteLine(); //Pula linha em branco

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

        Console.WriteLine(); //Pula linha em branco
        Console.WriteLine("==========================");
        Console.WriteLine(); //Pula linha em branco

        // TRABALHANDO COM FILA
        // Criar um Fila (Queue)
        Queue<string> FilaBanco = new Queue<string>();

        // Adicionsr Elementos em uma FILA
        FilaBanco.Enqueue("André");
        FilaBanco.Enqueue("João");
        FilaBanco.Enqueue("Maria");
        FilaBanco.Enqueue("José");

        foreach (var pessoa in FilaBanco)
        {
            Console.WriteLine(pessoa);
        }

        // Para retirar o primeiro elemento da FILA:
        FilaBanco.Dequeue();

        Console.WriteLine(); //Pula linha em branco
        Console.WriteLine("==========================");
        Console.WriteLine(); //Pula linha em branco

        foreach (var pessoa in FilaBanco)
        {
            Console.WriteLine(pessoa);
        }

        // Verificar se existe um elemento na fila

        bool achou = FilaBanco.Contains("Bia");

        if (achou) // ou: if (achou == true)
        {
            Console.WriteLine("A pessoa está na fila");
        }
        else
        {
            Console.WriteLine("A pessoa NÃO está na fila");
        }

        Console.WriteLine(); //Pula linha em branco
        Console.WriteLine("==========================");
        Console.WriteLine(); //Pula linha em branco

        // TRABALHANDO COM PILHA (STACK)
        // Criando uma pilha
        Stack<string> livros = new Stack<string>();

        // Adicionar  elementos em uma pilha
        livros.Push("Chapeuzinho Vermelho");
        livros.Push("Branca de Neve e os Sete Anões");
        livros.Push("Princesa e o Sapo");

        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }

        Console.WriteLine(); //Pula linha em branco
        Console.WriteLine("==========================");
        Console.WriteLine(); //Pula linha em branco

        // Remove o primeiro elemento da Pilha
        livros.Pop();
        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }

        Console.WriteLine(); //Pula linha em branco
        Console.WriteLine("==========================");
        Console.WriteLine(); //Pula linha em branco
    }
}