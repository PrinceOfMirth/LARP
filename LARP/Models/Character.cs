// Models/Character.cs
using System.Collections.Generic;

namespace Larp.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Species { get; set; }
        public int ExperiencePoints { get; set; }
        public List<string>? Skills { get; set; }
    }
}
