using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("CONVOY")]
public class Convoy {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("CODE", TypeName = "VARCHAR(50)")]
    public string Code { get; set; }

    public Truck? FrontTruck { get; set; }
    public Truck? BackTruck { get; set; }
    
    [Column("FRONT_TRUCK_ID")]
    public int? FrontTruckId { get; set; }
    
    [Column("BACK_TRUCK_ID")]
    public int? BackTruckId { get; set; }
    
}