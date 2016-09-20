using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Repositorio.MVC.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "E-mail é obrigatório")]
        [Display(Name = "E-mail")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha é obrigatório")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        [StringLength(10, ErrorMessage = "Senha deve ter pelo menos 10 caracteres")]
        public string Senha { get; set; }

        [Display(Name = "Esqueci minha senha.")]
        public bool RememberMe { get; set; }
    }
}