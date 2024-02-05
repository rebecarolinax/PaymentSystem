namespace sistema_produtos
{
    public class Marca
    {
        //propridades:
        public int Codigo;
        public string NomeMarca;
        public DateTime DataCadastro {get; set;}
        public static List<Marca> marca = new List<Marca>();
        private static DateTime _dataCadastro;

        //contrutor:
        public Marca(int _codigo, string _nomeMarca, DateTime _dataCadastro)
        {
            Codigo = _codigo;
            NomeMarca = _nomeMarca;
            DataCadastro = _dataCadastro;
        }

        //métodos:
        public static void Cadastrar()
        {
            Console.WriteLine();

            Console.WriteLine($"Vamos cadastrar a marca!");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write($"Insira um código: ");
            Console.ResetColor();
            int _codigo = int.Parse(Console.ReadLine()!);


            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write($"Insira um nome: ");
            Console.ResetColor();

            string _nomeMarca = Console.ReadLine()!;
            Console.WriteLine();


            marca.Add(
                new Marca(_codigo, _nomeMarca, _dataCadastro)
            );

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Marca cadastrada com sucesso!");
            Console.ResetColor();

        }

        public static void Listar()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($@"
Lista de Marcas:
            ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            foreach (var item in marca)
            {
                Console.WriteLine($@"
Código: {item.Codigo} 
Nome: {item.NomeMarca}
                ");
            }
            Console.ResetColor();
        }

        public static void Deletar(int codigoMarca)
        {
            Marca marcaEncontrada = marca.Find(item => item.Codigo == codigoMarca);
            int index = marca.IndexOf(marcaEncontrada);
            marca.RemoveAt(index);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Marca deletada!");
            Console.ResetColor();
        }
    }
}
