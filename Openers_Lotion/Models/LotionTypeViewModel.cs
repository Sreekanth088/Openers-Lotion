using Microsoft.AspNetCore.Mvc.Rendering;
using Openers_Lotion.Models;
using System.Collections.Generic;

namespace Openers_Lotion.Models;

public class LotionTypeViewModel
{
    public List<Lotion>? Lotions { get; set; }
    public SelectList? SkinTypes { get; set; }
    public string? LotionType { get; set; }
    public string? SearchString { get; set; }
}
