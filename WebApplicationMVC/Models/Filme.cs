using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Authentication;

namespace WebApplicationMVC.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Titulo precisa está preenchido. Verifique e tente novamente"), Display(Name = "Titulo Do Filme"),
         StringLength(40, MinimumLength = 3, ErrorMessage = "Titulo do Filme invalido minimo de 3 caracteres e maximo de 40. Verifique e tente novamente")]
        public string Titulo { get; set; }
        public int IdProdutora { get; set; }
        [Required(ErrorMessage = "Informe se o filme possui algum Oscar. Sim ou Não."), Display(Name = "Possui Oscar?")]
        public bool Oscar { get; set; }
        public Produtora ProdutoraResponsavel { get; set; }
        public Diretor DiretorGeral { get; set; }
        [Required(ErrorMessage = "O campo Data Lançamento precisa está preenchido. Verifique e tente novamente"), Display(Name = "Data Lançamento")]
        [DataType(DataType.DateTime,ErrorMessage = "Data inserida incorretamente. Verifique e tente novamente")]
        public DateTime DataLancamento { get; set; }
        [Required(ErrorMessage = "O campo Genero precisa está preenchido. Verifique e tente novamente"), Display(Name = "Genero do Filme"),
         RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$",ErrorMessage = "Genero deve começar com letras Maiuscula"),
         StringLength(40, MinimumLength = 3, ErrorMessage = "Genero de Filme invalido minimo de 3 caracteres e maximo de 40. Verifique e tente novamente")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "O campo Custo precisa está preenchido. Verifique e tente novamente"), Display(Name = "Custo de Filmagem"),
         Column(TypeName = "decimal(18,2)"),
         Range(1000.00, Double.MaxValue, ErrorMessage = "Valor do campo não pode ser menor que -100.000.000.000,00 nem maior que a memoria reservada para ele: 1.79769313486232E+308D")]
        public decimal Custo { get; set; }
        [RegularExpression(@"^[0-5]*$")]
        public int Avaliacao { get; set; }
        //public List<string> Comentarios { get; set; }

    }

   
}