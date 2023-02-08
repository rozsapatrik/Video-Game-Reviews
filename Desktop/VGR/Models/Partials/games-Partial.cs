using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGR.Models
{
    public partial class games
    {
        public games(int ID, string GameName, DateTime ReleaseDate, string MainPlatform, string MainGenre, string Developer, string Description)
        {
            this.ID = ID;
            this.GameName = GameName;
            this.ReleaseDate = ReleaseDate;
            this.MainPlatform = MainPlatform;
            this.MainGenre = MainGenre;
            this.Developer = Developer;
            this.Description = Description;
        }
    }
}
