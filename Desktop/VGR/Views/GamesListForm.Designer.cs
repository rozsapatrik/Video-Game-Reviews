
namespace VGR.Views
{
    partial class GamesListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelNew = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelSave = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelEdit = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabelSearch = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelDelete = new System.Windows.Forms.ToolStripLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelTotalItems = new System.Windows.Forms.Label();
            this.labelPages = new System.Windows.Forms.Label();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainPlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Developer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelNew,
            this.toolStripLabelSave,
            this.toolStripLabelEdit,
            this.toolStripTextBoxSearch,
            this.toolStripLabelSearch,
            this.toolStripSeparator1,
            this.toolStripLabelDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabelNew
            // 
            this.toolStripLabelNew.Name = "toolStripLabelNew";
            this.toolStripLabelNew.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabelNew.Text = "New";
            this.toolStripLabelNew.Click += new System.EventHandler(this.toolStripLabelNew_Click);
            // 
            // toolStripLabelSave
            // 
            this.toolStripLabelSave.Name = "toolStripLabelSave";
            this.toolStripLabelSave.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabelSave.Text = "Save";
            this.toolStripLabelSave.Click += new System.EventHandler(this.toolStripLabelSave_Click);
            // 
            // toolStripLabelEdit
            // 
            this.toolStripLabelEdit.Name = "toolStripLabelEdit";
            this.toolStripLabelEdit.Size = new System.Drawing.Size(27, 22);
            this.toolStripLabelEdit.Text = "Edit";
            this.toolStripLabelEdit.Click += new System.EventHandler(this.toolStripLabelEdit_Click);
            // 
            // toolStripTextBoxSearch
            // 
            this.toolStripTextBoxSearch.Name = "toolStripTextBoxSearch";
            this.toolStripTextBoxSearch.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabelSearch
            // 
            this.toolStripLabelSearch.Name = "toolStripLabelSearch";
            this.toolStripLabelSearch.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabelSearch.Text = "Search";
            this.toolStripLabelSearch.Click += new System.EventHandler(this.toolStripLabelSearch_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelDelete
            // 
            this.toolStripLabelDelete.Name = "toolStripLabelDelete";
            this.toolStripLabelDelete.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabelDelete.Text = "Delete";
            this.toolStripLabelDelete.Click += new System.EventHandler(this.toolStripLabelDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.gameNameDataGridViewTextBoxColumn1,
            this.releaseDateDataGridViewTextBoxColumn1,
            this.MainPlatform,
            this.MainGenre,
            this.Developer,
            this.descriptionDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.gamesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 278);
            this.dataGridView1.TabIndex = 2;
            // 
            // gamesBindingSource
            // 
            this.gamesBindingSource.DataSource = typeof(VGR.Models.games);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.buttonEnd, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonNext, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonStart, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTotalItems, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPages, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonPrevious, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 352);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 68);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // buttonEnd
            // 
            this.buttonEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEnd.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnd.Location = new System.Drawing.Point(543, 16);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(75, 35);
            this.buttonEnd.TabIndex = 5;
            this.buttonEnd.Text = ">>";
            this.buttonEnd.UseVisualStyleBackColor = false;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNext.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(414, 16);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 35);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStart.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(156, 16);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 35);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "<<";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelTotalItems
            // 
            this.labelTotalItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTotalItems.AutoSize = true;
            this.labelTotalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalItems.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTotalItems.Location = new System.Drawing.Point(18, 24);
            this.labelTotalItems.Name = "labelTotalItems";
            this.labelTotalItems.Size = new System.Drawing.Size(92, 20);
            this.labelTotalItems.TabIndex = 0;
            this.labelTotalItems.Text = "Total Items:";
            // 
            // labelPages
            // 
            this.labelPages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPages.AutoSize = true;
            this.labelPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPages.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPages.Location = new System.Drawing.Point(695, 24);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(31, 20);
            this.labelPages.TabIndex = 1;
            this.labelPages.Text = "1/1";
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPrevious.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrevious.Location = new System.Drawing.Point(285, 16);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 35);
            this.buttonPrevious.TabIndex = 2;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.Width = 50;
            // 
            // gameNameDataGridViewTextBoxColumn1
            // 
            this.gameNameDataGridViewTextBoxColumn1.DataPropertyName = "GameName";
            this.gameNameDataGridViewTextBoxColumn1.HeaderText = "GameName";
            this.gameNameDataGridViewTextBoxColumn1.Name = "gameNameDataGridViewTextBoxColumn1";
            this.gameNameDataGridViewTextBoxColumn1.Width = 200;
            // 
            // releaseDateDataGridViewTextBoxColumn1
            // 
            this.releaseDateDataGridViewTextBoxColumn1.DataPropertyName = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn1.HeaderText = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn1.Name = "releaseDateDataGridViewTextBoxColumn1";
            // 
            // MainPlatform
            // 
            this.MainPlatform.DataPropertyName = "MainPlatform";
            this.MainPlatform.HeaderText = "MainPlatform";
            this.MainPlatform.Name = "MainPlatform";
            // 
            // MainGenre
            // 
            this.MainGenre.DataPropertyName = "MainGenre";
            this.MainGenre.HeaderText = "MainGenre";
            this.MainGenre.Name = "MainGenre";
            // 
            // Developer
            // 
            this.Developer.DataPropertyName = "Developer";
            this.Developer.HeaderText = "Developer";
            this.Developer.Name = "Developer";
            this.Developer.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.Width = 2000;
            // 
            // GamesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "GamesListForm";
            this.Text = "GamesListForm";
            this.Load += new System.EventHandler(this.GamesListForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelNew;
        private System.Windows.Forms.ToolStripLabel toolStripLabelSave;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabelSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabelDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelTotalItems;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.ToolStripLabel toolStripLabelEdit;
        private System.Windows.Forms.BindingSource gamesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainPlatform;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Developer;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
    }
}