using System;
using System.Collections.Generic;

namespace Cookbook.Models;

public partial class Recipe
{
    public int Id { get; set; }

    public string Name { get; set; }

    public short PrepTime { get; set; }

    public string Instructions { get; set; }

    public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();
}
