using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VGR.Models;
using VGR.Repositories;
using VGR.ViewInterfaces;

namespace VGR.Presenters
{
    class GamesListPresenter
    {
        private IGamesListView view;
        private GamesRepository repo;

        public GamesListPresenter(IGamesListView param)
        {
            view = param;
            repo = new GamesRepository();
        }

        public void LoadData()
        {
            view.BindingList = repo.GetAll(view.page, view.itemsPerPage, view.search, view.sortBy, view.ascending);
            view.totalItems = repo.TotalItems;
        }

        public void Add(games game)
        {
            view.BindingList.Insert(0, game);
            repo.Insert(game);
            view.totalItems++;
        }

        public void Modify(games game)
        {
            repo.Update(game);
        }

        public void Remove(int index)
        {
            var game = view.BindingList.ElementAt(index);
            view.BindingList.RemoveAt(index);
            if(game.ID > 0)
            {
                repo.Delete((int)game.ID);
                view.totalItems--;
            }
        }

        public void Save()
        {
            repo.Save();
        }
    }
}
