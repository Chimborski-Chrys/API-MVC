using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploMVC.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage ="Campo Obrigatório")]
        public string Descricao { get; set; }

        
    }
}
