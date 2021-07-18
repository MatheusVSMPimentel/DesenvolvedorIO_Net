using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationMVC.Models
{
    public class Produtora
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Nome precisa está preenchido. Verifique e tente novamente"), Display(Name = "Nome da Produtora")]
        public string NomeProdutora { get; set; }
        [Required(ErrorMessage = "O campo Nome Fundador precisa está preenchido. Verifique e tente novamente"), Display(Name = "Nome do Fundador"),
        StringLength(40, MinimumLength = 3, ErrorMessage = "Nome do Fundador invalido minimo de 3 caracteres e maximo de 40. Verifique e tente novamente")]
        public string NomeFundador { get; set; }
        [Required(ErrorMessage = "O campo Data Fundação precisa está preenchido. Verifique e tente novamente"), Display(Name = "Data de Fundação")]
        [DataType(DataType.DateTime,ErrorMessage = "Data inserida incorretamente. Verifique e tente novamente")]
        public DateTime DataFundacao { get; set; }
        [ Display(Name = "Oscar"), Range(0, Int32.MaxValue, 
             ErrorMessage = "Valor do campo não pode ser menor que 0 nem maior que a memoria reservada para ele: 2147483647")]
        public int Oscars { get; set; }
        [Required(ErrorMessage = "O campo Nome Fundador precisa está preenchido. Verifique e tente novamente"), Display(Name = "Valor Patrimonio"),
        Column(TypeName = "decimal(18,2)"),
         Range(-100000000000.00, Double.MaxValue, ErrorMessage = "Valor do campo não pode ser menor que -100.000.000.000,00 nem maior que a memoria reservada para ele: 1.79769313486232E+308D")]
        public decimal  ValorPatrimonial { get; set; }
        
        public List<Diretor> Diretores { get; set; } //Questionar sobre isso
        
    }
}