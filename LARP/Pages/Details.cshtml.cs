using Larp.Models;
using Larp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LARP.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly YamlCharacterService _characterService;

        public DetailsModel(YamlCharacterService characterService)
        {
            _characterService = characterService;
        }

        public Character Character { get; private set; }

        public IActionResult OnGet(int id)
        {
            Character = _characterService.GetCharacterById(id);
            if (Character == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
