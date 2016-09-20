using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Repositorio.MVC.ViewModels
{
    public class UsuarioViewModel
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(10, ErrorMessage = "Nome deve ter pelo menos 10 caracteres")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "E-mail é obrigatório")]
        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "E-mail é inválido.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Senha é obrigatório")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        [StringLength(10, ErrorMessage = "Senha deve ter pelo menos 10 caracteres")]
        public string Senha { get; set; }

        [ScaffoldColumn(false)]
        public string SenhaKey { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [ScaffoldColumn(false)]
        public string Sexo { get; set; }

        [ScaffoldColumn(false)]
        public byte Foto { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DatadeNascimento { get; set; }

        [ScaffoldColumn(false)]
        public int Idade { get; set; }

        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }
    }
}