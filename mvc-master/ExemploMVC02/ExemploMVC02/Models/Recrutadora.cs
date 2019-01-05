﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExemploMVC02.Models
{
    public class Recrutadora
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome não pode ser vazio")]
        [MinLength(7,ErrorMessage = "Nome deve conter no mínimo 7 caracteres")]
        [MaxLength(100,ErrorMessage = "Nome deve conter no máximo 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "CPF não pode ser vazio")]
        [MinLength(11, ErrorMessage = "CPF deve conter somente 11 digitos")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Tempo de empresa deve ser preenchido")]
        [Range(0, 6, ErrorMessage = "Pessoa deve ter entre 0 à 6 anos de empresa")]
        public byte TempoEmpresa { get; set; }

        [Required(ErrorMessage = "Salário deve ser preenchido")]
        [Range(1200.00, 100000.00, ErrorMessage = "Salário deve estar entre R$ 1.200,00 à R$ 100.000,00")]
        public decimal Salario { get; set; }
    }
}