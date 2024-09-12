// Controllers/CharactersController.cs
using Microsoft.AspNetCore.Mvc;
using Larp.Services;

namespace Larp.Controllers
{
    public class CharactersController : Controller
    {
        private readonly YamlCharacterService _characterService;

        public CharactersController(YamlCharacterService characterService)
        {
            _characterService = characterService;
        }

        public IActionResult Index()
        {
            var characters = _characterService.GetCharacters();
            return View(characters);
        }

        public IActionResult Details(int id)
        {
            var characters = _characterService.GetCharacters();
            var character = characters.FirstOrDefault(c => c.Id == id);
            if (character == null)
            {
                return NotFound();
            }

            return View(character);
        }
    }
}
