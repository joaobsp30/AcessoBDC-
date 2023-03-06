using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pim_8.Models // Organizando classes em um namespace
{
	[Table("Usuario")]
	public class Usuario
	{
		[Display(Name = "Id")] // Especifica que a legenda para a caixa de texto seja ID
		[Column("Id")] // Controlar como as classes e propriedades são mapeadas para o banco de dados
		public int Id {get;set;} // Get utilizase na leitura e set ao se atribuir uma propriedade

		[Display(Name = "NOME")]
		[Column("NOME")]
		public string NOME {get;set;}

		[Display(Name= "Cpf")]
		[Column("Cpf")]
		public int Cpf {get;set;}

		[Display(Name= "Endereco")]
		[Column("Endereco")]
		public string Endereco {get;set;}

		[Display(Name = "Telefone")]
		[Column("Telefone")]
		public int Telefone {get;set;}

		[Display(Name = "DDD")]
		[Column("DDD")]
		public int DDD {get;set;}

		[Display(Name = "NumeroTel")]
		[Column("NumeroTel")]
		public int NumeroTel {get;set;}

		[Display(Name = "Tipo")]
		[Column("Tipo")]
		public string Tipo {get;set;}

		[Display(Name = "Logradouro")]
		[Column("Logradouro")]
		public string Logradouro {get;set;}

		[Display(Name = "Numero")]
		[Column("Numero")]
		public int Numero {get;set;}

		[Display(Name = "Cep")]
		[Column("Cep")]
		public int Cep {get;set;}

		[Display(Name = "Bairro")]
		[Column("Bairro")]
		public string Bairro {get;set;}

		[Display(Name = "Cidade")]
		[Column("Cidade")]
		public string Cidade {get;set;}

		[Display(Name = "Estado")]
		[Column("Estado")]
		public string Estado {get;set;}
	}
}