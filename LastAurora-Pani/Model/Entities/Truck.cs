using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Model.Entities;

[Table("TRUCKS")]
public class Truck : AUpgradableElement {
    
    public List<Waggon> Waggons { get; set; }
}