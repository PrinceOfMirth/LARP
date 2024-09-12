// Pages/Index.cshtml.cs
using Microsoft.AspNetCore.Mvc.RazorPages;
using Larp.Models;
using Larp.Services;

namespace Larp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly YamlCharacterService _characterService;

        public IndexModel(YamlCharacterService characterService)
        {
            _characterService = characterService;
        }

        public IEnumerable<Character> Characters { get; private set; }

        public void OnGet()
        {
            Characters = _characterService.GetCharacters();
        }
    }
}
