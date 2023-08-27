using System;
using System.Collections.Generic;

namespace PracticeApp.Models;

public partial class ExemptionApplication
{
    public int VersionId { get; set; }

    public string? ApplicationReference { get; set; }

    public string? ExemptionApplicationId { get; set; }

    public string? PropertyId { get; set; }

    public string? YearId { get; set; }
}
