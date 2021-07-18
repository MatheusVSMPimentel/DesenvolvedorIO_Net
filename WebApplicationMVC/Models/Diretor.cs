using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationMVC.Models
{
    public class Diretor
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Nome do Diretor  precisa está preenchido. Verifique e tente novamente"), Display(Name = "Nome Diretor"),
         StringLength(40, MinimumLength = 3, ErrorMessage = "Nome de Diretor invalido minimo de 3 caracteres e maximo de 40. Verifique e tente novamente")]
        public string NomeDiretor { get; set; }
        
        [Required(ErrorMessage = "O campo Data Nascimento precisa está preenchido. Verifique e tente novamente"), Display(Name = "Data de Nascimento")]
        [DataType(DataType.DateTime,ErrorMessage = "Data inserida incorretamente. Verifique e tente novamente")]
        public DateTime DataNascimento { get; set; }
        [Required(ErrorMessage = "O campo Salario precisa está preenchido. Verifique e tente novamente"), Display(Name = "Salario"),
         Column(TypeName = "decimal(18,2)"),
         Range(0.00, Double.MaxValue, ErrorMessage = "Valor do campo não pode ser menor que 0,00 nem maior que a memoria reservada para ele: 1.79769313486232E+308D")]
        public decimal Salario { get; set; }
        
        public int OscarFilmesDirigidos { get; set; }
        
        public Produtora Produtora { get; set; }
        
    }
}