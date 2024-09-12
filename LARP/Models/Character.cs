// Models/Character.cs
using LARP.Models.Enums;

namespace Larp.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Species Species { get; set; }
        public int ExperiencePoints { get; set; }
        public List<string>? Skills { get; set; }
    }
}
