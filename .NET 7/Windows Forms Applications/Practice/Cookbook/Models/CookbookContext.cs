using Microsoft.EntityFrameworkCore;

namespace Cookbook.Models;

public partial class CookbookContext : DbContext
{
    public DbSet<Ingredient> Ingredients { get; set; }

    public DbSet<Recipe> Recipes { get; set; }

    public DbSet<RecipeIngredient> RecipeIngredients { get; set; }

    public CookbookContext() {}

    public CookbookContext(DbContextOptions<CookbookContext> options) : base(options) {}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlServer("Server=localhost;Database=Cookbook;Trusted_Connection=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ingredient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ingredie__3214EC0718D1744B");
            entity.ToTable("Ingredient");
            entity.Property(e => e.Name).IsRequired().HasMaxLength(50).IsUnicode(false);
        });

        modelBuilder.Entity<Recipe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Recipe__3214EC073CC106D3");
            entity.ToTable("Recipe");
            entity.Property(e => e.Instructions).IsRequired();
            entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
        });

        modelBuilder.Entity<RecipeIngredient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RecipeIn__3214EC0745095915");
            entity.ToTable("RecipeIngredient");
            entity.HasOne(d => d.Ingredient).WithMany(p => p.RecipeIngredients).HasForeignKey(d => d.IngredientId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("IngredientFK");
            entity.HasOne(d => d.Recipe).WithMany(p => p.RecipeIngredients).HasForeignKey(d => d.RecipeId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("RecipeFK");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}