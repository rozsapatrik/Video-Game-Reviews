using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VGR.Repositories;
using VGR.ViewInterfaces;

namespace VGR.Presenters
{
    public class GamesPresenter
    {
        private IGamesView view;
        private GamesRepository repo;

        public GamesPresenter(IGamesView param)
        {
            view = param;
            repo = new GamesRepository();
        }

        public bool ValidateData()
        {
            var valid = true;
            view.errorName = null;
            if(repo.Exists(view.game.GameName) && view.game.ID == 0)
            {
                valid = false;
                view.errorName = "Ez a játék már létezik az adatbázisban";
            }
            return valid;
        }
    }
}
