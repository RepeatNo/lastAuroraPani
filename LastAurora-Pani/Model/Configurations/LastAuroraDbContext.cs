using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Model.Configurations;

public class LastAuroraDbContext : DbContext {
    public DbSet<Convoy> Convoys { get; set; }
    public DbSet<Addon> Addons { get; set; }
    public DbSet<AConvoyElement> ConvoyElements { get; set; }
    public DbSet<AUpgradableElement> UpgradableElements { get; set; }
    public DbSet<Truck> Trucks { get; set; }
    public DbSet<Waggon> Waggons { get; set; }


    public LastAuroraDbContext(DbContextOptions<LastAuroraDbContext> options) : base(options) {
    }

    protected override void OnModelCreating(ModelBuilder builder) {
        builder.Entity<AConvoyElement>()
            .HasIndex(ce => ce.Code)
            .IsUnique();

        builder.Entity<Convoy>()
            .HasOne(c => c.BackTruck)
            .WithOne()
            .HasForeignKey<Convoy>(c => c.BackTruckId);

        builder.Entity<Convoy>()
            .HasOne(c => c.FrontTruck)
            .WithOne()
            .HasForeignKey<Convoy>(c => c.FrontTruckId);

        builder.Entity<Waggon>()
            .HasOne(w => w.Truck)
            .WithMany(t => t.Waggons)
            .HasForeignKey(w => w.TruckId);

        builder.Entity<AUpgradableElement>()
            .HasOne(ue => ue.Addon)
            .WithOne()
            .HasForeignKey<AUpgradableElement>(ue => ue.AddonId);
    }
}