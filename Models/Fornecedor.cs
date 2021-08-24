using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Text.Json.Serialization;

namespace api_desafio21dias.Models
{
  [Table("f_cli_for")]
  public partial class Fornecedor
  {
    #region "Propriedades"
    [Key]
    [Column("cod_cfo")]
    public int Id { get; set; }

    [Column("nome_fantasia")]
    [Required]
    [JsonPropertyName("Nome")]
    public string NomeFantasia { get; set; }

    [Column("razao")]
    [Required]
    public string RazaoSocial { get; set; }

    [Column("cpf_cnpj")]
    [Required]
    [JsonIgnore]
    public string Cpf_Cnpj { get; set; }

    [NotMapped]
    public string CNPJ { get { return this.Cpf_Cnpj; } set { this.Cpf_Cnpj = value; } }
    
    [NotMapped]
    public string CPF { get { return this.Cpf_Cnpj; } set { this.Cpf_Cnpj = value; } }

    [Column("endereco")]
    [Required]
    public string Endereco { get; set; }

    #endregion

    #region Metodos 

    #endregion
  }
}