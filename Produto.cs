namespace sistema_produtos
{
    public class Produto
    {
        //propriedades:
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca { get; set; }
        public Usuario CadastroPor { get; set; }
        public static List<Produto> produto = new List<Produto>();

        //costrutor:
        Produto(int _codigo, string _nomeProduto, float _preco)
        {
            Codigo = _codigo;
            NomeProduto = _nomeProduto;
            Preco = _preco;
        }

        //metodos:
        public static void Cadastrar()
        {
            Console.WriteLine();

            Console.WriteLine($"Vamos cadastrar o produto!");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write($"Insira um código:");
            Console.ResetColor();

            int codigo = int.Parse(Console.ReadLine()!);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write($"Insira um nome: ");
            Console.ResetColor();

            string nomeProduto = Console.ReadLine()!;
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write($"Insira um preço: ");
            Console.ResetColor();

            float preco = float.Parse(Console.ReadLine()!);
            Console.WriteLine();

            produto.Add(
                new Produto(codigo, nomeProduto, preco)
            );

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Produto cadastrado com sucesso!");
            Console.ResetColor();
        }
        public static void Listar()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Lista de Produtos: ");
            Console.ResetColor();
            Console.WriteLine();


            foreach (var item in produto)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($@"
Código:{item.Codigo}
Nome:{item.NomeProduto}
Preço:{item.Preco:C}
                ");
                Console.ResetColor();
            }

        }
        public static void Deletar(int codigoProduto)
        {
            Produto produtoEncontrado = produto.Find(item => item.Codigo == codigoProduto);
            int index = produto.IndexOf(produtoEncontrado);
            produto.RemoveAt(index);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Produto deletado!");
            Console.ResetColor();
        }
    }
}
