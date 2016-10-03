using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWithModel.Models
{
    public class CharacterRepo
    {
        public List<Character> CharacterList { get; set; }
                                       = new List<Character>();
    }
}
