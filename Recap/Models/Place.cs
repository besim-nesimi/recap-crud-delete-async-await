using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap.Models;

public class Place
{

    // För att fatta att strängen Location är primary key, så gör vi på följande sätt:
    [Key] // Berättar att Location är vå nyckel.
    public string Location { get; set; } = null!; 

    public string? Description { get; set; }

    public virtual List<Character> Characters { get; set; } = new();
}
