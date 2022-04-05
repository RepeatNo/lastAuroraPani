using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("CONVOY_ELEMENTS")]
public abstract class AConvoyElement {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("ELEMENT_ID")]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    [Column("CODE")]
    public string Code { get; set; }

    [Column("PRICE")]
    [Range(0, Int32.MaxValue)]
    public int Price { get; set; }
}