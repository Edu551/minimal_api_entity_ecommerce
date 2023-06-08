using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Entidades;

[Table("tb_clientes")]
public record Cliente
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    [Column(name: "cli_nome")]
    public string Nome { get; set; } = string.Empty;

    [Required]
    [MaxLength(20)]
    [Column(name: "cli_telefone")]
    public string Telefone { get; set; } = string.Empty;

    public string? Observacao { get; set; }
}