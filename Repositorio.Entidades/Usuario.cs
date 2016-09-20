using System;

namespace Repositorio.Entidades
{
    public class Usuario
    {
        public Usuario()
        {
            this.DataCadastro = DateTime.Now;
            this.Ativo = true;
        }
        
        public int UsuarioId { get; set; }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string SenhaKey { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Sexo { get; set; }
        public byte Foto { get; set; }
        public DateTime DatadeNascimento { get; set; }
        public int Idade { get; set; }
        public bool Ativo { get; set; }
    }
}
