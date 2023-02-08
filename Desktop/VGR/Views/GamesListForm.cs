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
using VGR.Services;
using VGR.ViewInterfaces;

namespace VGR.Views
{
    public partial class GamesListForm : Form, IGamesListView
    {
        private GamesListPresenter presenter;
        private int sortIndex;
        private int pageCount;
        private int _totalItems;
        
        public GamesListForm()
        {
            InitializeComponent();
            presenter = new GamesListPresenter(this);
            Init();
            if(CurrentUser.UserName != "admin1" && CurrentUser.UserName != "admin2" && CurrentUser.UserName != "admin3")
            {
                toolStripLabelDelete.Visible = false;
                toolStripLabelDelete.Enabled = false;
            }
            else
            {
                toolStripLabelDelete.Visible = true;
                toolStripLabelDelete.Enabled = true;
            }
        }

        public void Init()
        {
            page = 1;
            itemsPerPage = 20;
            sortIndex = 0;
            ascending = true;
        }
        public int page { get; set; }
        public int itemsPerPage { get; set; }

        public string search => toolStripTextBoxSearch.Text;

        public string sortBy { get; set; }
        public bool ascending { get; set; }
        public int totalItems
        {
            get
            {
                return _totalItems;
            }
            set
            {
                _totalItems = value;
                pageCount = (value - 1) / itemsPerPage + 1;
                labelPages.Text = page + "/" + pageCount;
                labelTotalItems.Text = "Total Items: " + value;
            }
        }

        public BindingList<games> gamesList { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public BindingList<games> BindingList
        {
            get => (BindingList<games>)dataGridView1.DataSource;
            set => dataGridView1.DataSource = value;
        }

        private void GamesListForm_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void toolStripLabelSearch_Click(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void dataGridView1_ColumnHeaderClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (sortIndex == e.ColumnIndex)
            {
                ascending = !ascending;
            }
            switch(e.ColumnIndex)
            {
                case 0:
                    sortBy = "ID";
                    break;
                case 1:
                    sortBy = "GameName";
                    break;
                case 2:
                    sortBy = "ReleaseDate";
                    break;
                default:
                    break;
            }

            sortIndex = e.ColumnIndex;
            presenter.LoadData();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            page = 1;
            presenter.LoadData();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if(page != 1)
            {
                page--;
                presenter.LoadData();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if(page != pageCount)
            {
                page++;
                presenter.LoadData();
            }
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            page = pageCount;
            presenter.LoadData();
        }

        private void toolStripLabelNew_Click(object sender, EventArgs e)
        {
            NewDGRow();
        }

        private void toolStripLabelSave_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }

        private void toolStripLabelDelete_Click(object sender, EventArgs e)
        {
            DelDGRow();
        }

        private void NewDGRow()
        {
            using(var editForm = new AddGameForm())
            {
                DialogResult dr = editForm.ShowDialog(this);
                if(dr == DialogResult.OK)
                {
                    presenter.Add(editForm.game);
                    editForm.Close();
                }
            }
        }

        private void EditDGRow(int index)
        {
            var game = (games)dataGridView1.Rows[index].DataBoundItem;
            using(var editForm = new AddGameForm())
            {
                editForm.game = game;
                DialogResult dr = editForm.ShowDialog();
                if(dr == DialogResult.OK)
                {
                    presenter.Modify(editForm.game);
                    editForm.Close();
                }
            }
        }

        private void DelDGRow()
        {
            while(dataGridView1.SelectedRows.Count > 0)
            {
                presenter.Remove(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void toolStripLabelEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var sorIndex = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.ClearSelection();
                dataGridView1.Rows[sorIndex].Selected = true;
                EditDGRow(sorIndex);
            }
        }
    }
}
