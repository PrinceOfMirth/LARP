// Services/YamlCharacterService.cs
using System.Collections.Generic;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using Larp.Models;

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
