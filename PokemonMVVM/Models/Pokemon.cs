using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMVVM.Models
{
    class CharacterAPIResult
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public List<Pokemon> Results { get; set; }
    }
    public class Pokemon
    {
        public string Name { get; set; }
        public string Url { set; get; }
         public Sprite Sprites { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
    public class Sprite
    {
        public string Front_default { get; set; }
        public string Back_default { set; get; }
    }

}
