
namespace VGR.Views
{
    partial class AddGameForm
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
            this.labelAddAGame = new System.Windows.Forms.Label();
            this.textBoxGameName = new System.Windows.Forms.TextBox();
            this.dateTimePickerReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.labelGameName = new System.Windows.Forms.Label();
            this.labelReleaseDate = new System.Windows.Forms.Label();
            this.labelDeveloper = new System.Windows.Forms.Label();
            this.labelMainGenre = new System.Windows.Forms.Label();
            this.labelMainPlatform = new System.Windows.Forms.Label();
            this.buttonAddAGame = new System.Windows.Forms.Button();
            this.textBoxDescriotion = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDeveloper = new System.Windows.Forms.TextBox();
            this.textBoxMainGenre = new System.Windows.Forms.TextBox();
            this.textBoxMainPlatform = new System.Windows.Forms.TextBox();
            this.errorProviderGameName = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGameName)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddAGame
            // 
            this.labelAddAGame.AutoSize = true;
            this.labelAddAGame.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddAGame.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAddAGame.Location = new System.Drawing.Point(323, 9);
            this.labelAddAGame.Name = "labelAddAGame";
            this.labelAddAGame.Size = new System.Drawing.Size(170, 39);
            this.labelAddAGame.TabIndex = 0;
            this.labelAddAGame.Text = "Add A Game";
            // 
            // textBoxGameName
            // 
            this.textBoxGameName.Location = new System.Drawing.Point(33, 88);
            this.textBoxGameName.Name = "textBoxGameName";
            this.textBoxGameName.Size = new System.Drawing.Size(315, 20);
            this.textBoxGameName.TabIndex = 1;
            // 
            // dateTimePickerReleaseDate
            // 
            this.dateTimePickerReleaseDate.Location = new System.Drawing.Point(33, 147);
            this.dateTimePickerReleaseDate.Name = "dateTimePickerReleaseDate";
            this.dateTimePickerReleaseDate.Size = new System.Drawing.Size(315, 20);
            this.dateTimePickerReleaseDate.TabIndex = 2;
            // 
            // labelGameName
            // 
            this.labelGameName.AutoSize = true;
            this.labelGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelGameName.Location = new System.Drawing.Point(29, 65);
            this.labelGameName.Name = "labelGameName";
            this.labelGameName.Size = new System.Drawing.Size(110, 20);
            this.labelGameName.TabIndex = 6;
            this.labelGameName.Text = "Game\'s Name";
            // 
            // labelReleaseDate
            // 
            this.labelReleaseDate.AutoSize = true;
            this.labelReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReleaseDate.ForeColor = System.Drawing.SystemColors.Control;
            this.labelReleaseDate.Location = new System.Drawing.Point(29, 124);
            this.labelReleaseDate.Name = "labelReleaseDate";
            this.labelReleaseDate.Size = new System.Drawing.Size(107, 20);
            this.labelReleaseDate.TabIndex = 7;
            this.labelReleaseDate.Text = "Release Date";
            // 
            // labelDeveloper
            // 
            this.labelDeveloper.AutoSize = true;
            this.labelDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeveloper.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDeveloper.Location = new System.Drawing.Point(29, 181);
            this.labelDeveloper.Name = "labelDeveloper";
            this.labelDeveloper.Size = new System.Drawing.Size(81, 20);
            this.labelDeveloper.TabIndex = 8;
            this.labelDeveloper.Text = "Developer";
            // 
            // labelMainGenre
            // 
            this.labelMainGenre.AutoSize = true;
            this.labelMainGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainGenre.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMainGenre.Location = new System.Drawing.Point(29, 240);
            this.labelMainGenre.Name = "labelMainGenre";
            this.labelMainGenre.Size = new System.Drawing.Size(92, 20);
            this.labelMainGenre.TabIndex = 9;
            this.labelMainGenre.Text = "Main Genre";
            // 
            // labelMainPlatform
            // 
            this.labelMainPlatform.AutoSize = true;
            this.labelMainPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainPlatform.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMainPlatform.Location = new System.Drawing.Point(29, 300);
            this.labelMainPlatform.Name = "labelMainPlatform";
            this.labelMainPlatform.Size = new System.Drawing.Size(106, 20);
            this.labelMainPlatform.TabIndex = 10;
            this.labelMainPlatform.Text = "Main Platform";
            // 
            // buttonAddAGame
            // 
            this.buttonAddAGame.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonAddAGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddAGame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddAGame.Location = new System.Drawing.Point(348, 371);
            this.buttonAddAGame.Name = "buttonAddAGame";
            this.buttonAddAGame.Size = new System.Drawing.Size(108, 38);
            this.buttonAddAGame.TabIndex = 16;
            this.buttonAddAGame.Text = "Add Game";
            this.buttonAddAGame.UseVisualStyleBackColor = false;
            this.buttonAddAGame.Click += new System.EventHandler(this.buttonAddAGame_Click);
            // 
            // textBoxDescriotion
            // 
            this.textBoxDescriotion.Location = new System.Drawing.Point(421, 88);
            this.textBoxDescriotion.Multiline = true;
            this.textBoxDescriotion.Name = "textBoxDescriotion";
            this.textBoxDescriotion.Size = new System.Drawing.Size(350, 256);
            this.textBoxDescriotion.TabIndex = 17;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDescription.Location = new System.Drawing.Point(417, 65);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(89, 20);
            this.labelDescription.TabIndex = 18;
            this.labelDescription.Text = "Description";
            // 
            // textBoxDeveloper
            // 
            this.textBoxDeveloper.Location = new System.Drawing.Point(33, 204);
            this.textBoxDeveloper.Name = "textBoxDeveloper";
            this.textBoxDeveloper.Size = new System.Drawing.Size(315, 20);
            this.textBoxDeveloper.TabIndex = 19;
            // 
            // textBoxMainGenre
            // 
            this.textBoxMainGenre.Location = new System.Drawing.Point(33, 263);
            this.textBoxMainGenre.Name = "textBoxMainGenre";
            this.textBoxMainGenre.Size = new System.Drawing.Size(315, 20);
            this.textBoxMainGenre.TabIndex = 20;
            // 
            // textBoxMainPlatform
            // 
            this.textBoxMainPlatform.Location = new System.Drawing.Point(33, 324);
            this.textBoxMainPlatform.Name = "textBoxMainPlatform";
            this.textBoxMainPlatform.Size = new System.Drawing.Size(315, 20);
            this.textBoxMainPlatform.TabIndex = 21;
            // 
            // errorProviderGameName
            // 
            this.errorProviderGameName.ContainerControl = this;
            // 
            // AddGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxMainPlatform);
            this.Controls.Add(this.textBoxMainGenre);
            this.Controls.Add(this.textBoxDeveloper);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescriotion);
            this.Controls.Add(this.buttonAddAGame);
            this.Controls.Add(this.labelMainPlatform);
            this.Controls.Add(this.labelMainGenre);
            this.Controls.Add(this.labelDeveloper);
            this.Controls.Add(this.labelReleaseDate);
            this.Controls.Add(this.labelGameName);
            this.Controls.Add(this.dateTimePickerReleaseDate);
            this.Controls.Add(this.textBoxGameName);
            this.Controls.Add(this.labelAddAGame);
            this.Name = "AddGameForm";
            this.Text = "AddGameForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGameName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddAGame;
        private System.Windows.Forms.TextBox textBoxGameName;
        private System.Windows.Forms.DateTimePicker dateTimePickerReleaseDate;
        private System.Windows.Forms.Label labelGameName;
        private System.Windows.Forms.Label labelReleaseDate;
        private System.Windows.Forms.Label labelDeveloper;
        private System.Windows.Forms.Label labelMainGenre;
        private System.Windows.Forms.Label labelMainPlatform;
        private System.Windows.Forms.Button buttonAddAGame;
        private System.Windows.Forms.TextBox textBoxDescriotion;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDeveloper;
        private System.Windows.Forms.TextBox textBoxMainGenre;
        private System.Windows.Forms.TextBox textBoxMainPlatform;
        private System.Windows.Forms.ErrorProvider errorProviderGameName;
    }
}