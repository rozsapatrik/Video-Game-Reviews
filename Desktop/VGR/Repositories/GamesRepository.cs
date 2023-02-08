using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VGR.Models;

namespace VGR.Repositories
{
    class GamesRepository
    {
        private vgrEntities db = new vgrEntities();
        private int _totalItems;

        public BindingList<games> GetAll(
            int page=0,
            int itemsPerPage = 0,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            var query = db.games.OrderBy(x => x.ID).AsQueryable();
            //Keresés
            if(!string.IsNullOrWhiteSpace(search))
            {
                int.TryParse(search, out int szam);
                DateTime.TryParse(search, out DateTime datum);
                query = query.Where(x =>
                    x.ID.Equals(szam) ||
                    x.GameName.Contains(search) ||
                    x.MainPlatform.Contains(search) ||
                    x.MainGenre.Contains(search) ||
                    x.Developer.Contains(search) ||
                    x.ReleaseDate.Equals(datum));
;
            }

            //Sorbarendezés
            if(!string.IsNullOrWhiteSpace(sortBy))
            {
                switch(sortBy)
                {
                    case "ID":
                        query = ascending ? query.OrderBy(x => x.ID) : query.OrderByDescending(x => x.ID);
                        break;
                    case "GameName":
                        query = ascending ? query.OrderBy(x => x.GameName) : query.OrderByDescending(x => x.GameName);
                        break;
                    case "ReleaseDate":
                        query = ascending ? query.OrderBy(x => x.ReleaseDate) : query.OrderByDescending(x => x.ReleaseDate);
                        break;
                    case "MainPlatform":
                        query = ascending ? query.OrderBy(x => x.MainPlatform) : query.OrderByDescending(x => x.MainPlatform);
                        break;
                    case "MainGenre":
                        query = ascending ? query.OrderBy(x => x.MainGenre) : query.OrderByDescending(x => x.MainGenre);
                        break;
                    case "Developer":
                        query = ascending ? query.OrderBy(x => x.Developer) : query.OrderByDescending(x => x.Developer);
                        break;
                    default:
                        break;
                }
            }

            //Összes találat kiszámítása
            _totalItems = query.Count();

            //Oldaltörés
            if(page + itemsPerPage > 0)
            {
                query = query.Skip((page - 1) * itemsPerPage).Take(itemsPerPage);
            }
            return new BindingList<games>(query.ToList());
        }
        public int TotalItems
        {
            get { return _totalItems; }
        }

        public bool Exists(string name)
        {
            return db.games.Any(x => x.GameName.Equals(name));
        }

        public games GetGame(int id)
        {
            return db.games.AsNoTracking().SingleOrDefault(x => x.ID == id);
        }

        public void Insert(games game)
        {
            db.games.Add(game);
        }

        public void Update(games param)
        {
            var game = db.games.Find(param.ID);
            if(game != null)
            {
                db.Entry(game).CurrentValues.SetValues(param);
            }
        }

        public void Delete(int id)
        {
            var game = db.games.Find(id);
            db.games.Remove(game);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
