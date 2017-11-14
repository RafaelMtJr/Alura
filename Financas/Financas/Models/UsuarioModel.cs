using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Financas.Models
{
    public class UsuarioModel
    {
        [Required]
        public String Nome { get; set; }

        [Required,EmailAddress]
        public String Email { get; set; }
        
        [Required]
        public String Senha { get; set; }

        [Compare("Senha")]
        public String ConfirmacaoSenha { get; set; }

    }
}