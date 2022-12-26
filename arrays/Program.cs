// using ExemploFundamentos.Models

internal class Program
{
    private static void Main(string[] args)
    {
        string opcao;


        while (true)
        {
            Console.WriteLine("Digite a sua opção: ");
            Console.WriteLine("1 - Cadastrar cliente : ");
            Console.WriteLine("2 - Buscar cliente : ");
            Console.WriteLine("3 - Apagar cliente : ");
            Console.WriteLine("4 - Encerrar ");
            opcao = Console.ReadLine();
            bool exibirMenu = true;
            Console.Clear();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Cadastro Cliente");
                    Console.WriteLine("Digite o nome do cliente :");
                    string nome = Console.ReadLine();
                    Console.WriteLine($" O Nome do cliente é  {nome}");
                    break;
                case "2":
                    Console.WriteLine("Busca de Cliente");
                    break;
                case "3":
                    Console.WriteLine("Apagar Cliente");
                    break;
                case "4":
                    Console.WriteLine("Encerrar");
                    exibirMenu = false;
                    Console.WriteLine("Fim do prgrama");
                    Environment.Exit(0);
                    break;
                defaut:
                    Console.WriteLine("A Opção não existe.");


            }
        }
    }
}