using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VGR.Models;
using VGR.Presenters;
using VGR.ViewInterfaces;

namespace VGR.Views
{
    public partial class AddGameForm : Form, IGamesView
    {
        private int Id;
        private GamesPresenter presenter;
        
        public AddGameForm()
        {
            InitializeComponent();
            presenter = new GamesPresenter(this);
        }
        public string errorName
        {
            get => errorProviderGameName.GetError(textBoxGameName);
            set => errorProviderGameName.SetError(textBoxGameName, value);
        }
        public games game
        { 
            get
            {
                var game = new games(
                    Id,
                    textBoxGameName.Text,
                    dateTimePickerReleaseDate.Value,
                    textBoxMainPlatform.Text,
                    textBoxMainGenre.Text,
                    textBoxDeveloper.Text,
                    textBoxDescriotion.Text);
                game.ID = Id > 0 ? Id : 0;
                return game;
            }
            set
            {
                Id = (int)value.ID;
                textBoxGameName.Text = value.GameName;
                dateTimePickerReleaseDate.Value = value.ReleaseDate > new DateTime(0001, 01, 01) ? value.ReleaseDate : new DateTime(1900, 1, 1);
                textBoxDeveloper.Text = value.Developer;
                textBoxMainGenre.Text = value.MainGenre;
                textBoxMainPlatform.Text = value.MainPlatform;
                textBoxDescriotion.Text = value.Description;

            }
        }

        private void buttonAddAGame_Click(object sender, EventArgs e)
        {
            if(presenter.ValidateData())
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
