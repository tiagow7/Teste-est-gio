namespace API.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NomeSobrenome { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Aluno { get; set; }
        public bool Professor { get; set; }
    }
}
