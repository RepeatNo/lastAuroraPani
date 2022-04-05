using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("UPGRADABLE_ELEMENTS")]
public abstract class AUpgradableElement : AConvoyElement {
    [Column("ADDON_ID")] public int? AddonId { get; set; }

    public Addon? Addon { get; set; }
}