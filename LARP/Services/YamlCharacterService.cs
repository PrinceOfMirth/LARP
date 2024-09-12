// Services/YamlCharacterService.cs
using YamlDotNet.Serialization;
using Larp.Models;
using LARP.Models.Enums;

namespace Larp.Services
{
    public class YamlCharacterService
    {
        private readonly string _filePath;

        public YamlCharacterService(string filePath)
        {
            _filePath = filePath;
        }

        public List<Character> GetCharacters()
        {
            var deserializer = new DeserializerBuilder()
                .Build();

            using (var reader = new StreamReader(_filePath))
            {
                var characters = deserializer.Deserialize<List<Character>>(reader);
                return characters ?? new List<Character>();
            }
        }

        public Character GetCharacterById(int id)
        {
            var characters = GetCharacters();
            return characters.Find(character => character.Id == id);
        }
    }
}
