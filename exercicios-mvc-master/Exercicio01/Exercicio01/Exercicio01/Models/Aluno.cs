using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exercicio01.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        public string CodigoMatricula { get; set; }

        [Required(ErrorMessage = "Nome deve ser preenchido")]
        [MinLength(7, ErrorMessage = "Nome deve conver no mínimo 7 caracteres")]
        [MaxLength(150, ErrorMessage = "Nome deve conter no máximo 150 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Nota 1 deve ser preenchida")]
        [Range(0, 10, ErrorMessage = " 0,0 à 10,0")]
        public double Nota1 { get; set; }

        [Required(ErrorMessage = "Nota 2 deve ser preenchida")]
        [Range(0, 10, ErrorMessage = " 0,0 à 10,0")]
        public double Nota2 { get; set; }

        [Required(ErrorMessage = "Nota 3 deve ser preenchida")]
        [Range(0, 10, ErrorMessage = " 0,0 à 10,0")]
        public double Nota3 { get; set; }

        [Required(ErrorMessage = "Quantidade de faltas deve ser preenchida")]
        [Range(0, 200, ErrorMessage = "0 à 200")]
        public byte Faltas { get; set; }
        
        public byte Frequencia { get; set; }

        public string Media { get; set; }       
         
        public string ObterNotaCompleta(double nota)
        {
            return string.Format("{0:00.00}", nota);
        }

    }
}