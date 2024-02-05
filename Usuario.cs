namespace sistema_produtos
{
    public class Usuario
    {
        //propriedades Código, Nome, Email, Senha
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<Usuario> novoUsuario = new List<Usuario>();

        //construtor:
        public Usuario(int _codigo, string _nome, string _email, string _senha)
        {
            Codigo = _codigo;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            DataCadastro = DateTime.Now;
        }
        public Usuario()
        {
            Cadastrar();
        }
        //métodos:
        public void Cadastrar()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($@"
Vamos iniciar nossas operações cadastrando o usuário.
");
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write($"Insira seu e-mail: ");
            Console.ResetColor();

            this.Email = Console.ReadLine()!;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write($"Insira sua senha: ");
            Console.ResetColor();

            this.Senha = Console.ReadLine()!;
            Console.WriteLine();
        }

        public string Deletar(Usuario _usuario)
        {
            novoUsuario.Remove(_usuario);

            Console.ForegroundColor = ConsoleColor.Red;
            return "Usuário deletado, obrigado(a)!";

        }
    }
}

