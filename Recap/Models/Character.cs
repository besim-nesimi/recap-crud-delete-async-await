using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap.Models;

public class Character
{
    public int CharacterId { get; set; }
    public string FirstName { get; set; } = null!;
    public string? LastName { get; set; }
    public string Lineage { get; set; } = null!;

    public virtual Place Place { get; set; } = null!;
}
