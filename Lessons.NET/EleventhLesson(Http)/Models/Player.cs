using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleventhLesson_Http_.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public string Position { get; set; }
        public int Team { get; set; }
        public DateTime Birthday { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string AvatarUrl { get; set; }
        public int Id { get; set; }
    }
}
