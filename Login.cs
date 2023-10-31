namespace sistema_produtos
{
    public class Login
    {
        //propriedades:
        public bool Logado;
        private string email;

        public string Senha { get; private set; }

        //construtor:
        public Login()
        {
            Usuario user = new Usuario();
            Logar(user);
            if (Logado)
            {
                Menu();
            }
        }

        //métodos:
        public void Logar(Usuario usuario)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Agora, a verificação final: ");
            Console.ResetColor();

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write($"Insira seu email novamente: ");
            Console.ResetColor();

            string email = Console.ReadLine()!;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write($"Insira sua senha novamente: ");
            Console.ResetColor();
            string senha = Console.ReadLine()!;
            Console.WriteLine();
            Console.WriteLine();



            if (email == usuario.Email && senha == usuario.Senha)
            {
                this.Logado = true;
                Console.WriteLine($"Login efetuado com sucesso!");
            }
            else
            {
                this.Logado = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Usuário ou senha incorretos, tente novamente!");
                Console.ResetColor();
            }
        }


        public void Deslogar()
        {

        }

        public void Menu()
        {
            string opcao;

            Console.WriteLine($@"
Bem-Vindo(a) ao nosso sistema!
                ");

            do
            {


                Console.WriteLine($"Selecione uma opção:");

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(@$"
(1)- Cadastrar Marcas
(2)- Listar Marcas
(3)- Remover Marcas
                
(4)- Cadastrar Produtos
(5)- Listar Produtos
(6)- Remover Produtos

(0) - Sair/Cancelar
                ");
                Console.ResetColor();

                opcao = Console.ReadLine()!;

                switch (opcao)
                {
                    case "1":
                        Marca.Cadastrar();
                        break;

                    case "2":
                        Marca.Listar();
                        break;

                    case "3":
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write($"Insira o código da marca que deseja deletar: ");
                        Console.ResetColor();
                        int codigoMarca = int.Parse(Console.ReadLine()!);
                        Marca.Deletar(codigoMarca);
                        break;

                    case "4":
                        Produto.Cadastrar();
                        break;

                    case "5":
                        Produto.Listar();
                        break;

                    case "6":
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write($"Insira o código do produto que deseja deletar: ");
                        Console.ResetColor();
                        int codigoProduto = int.Parse(Console.ReadLine()!);
                        Produto.Deletar(codigoProduto);
                        break;

                    case "0":
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Obrigado(a) por usar o programa!");
                        Console.ResetColor();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Opção inválida, tente novamente!");
                        Console.ResetColor();
                        break;
                }

            } while (opcao != "0");
        }
    }
}
