
namespace CAPA_PRESENTACION
{
    partial class Temas
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.combobox1 = new CAPA_PRESENTACION.Combobox();
            this.buttonpersolizado1 = new CAPA_PRESENTACION.Buttonpersolizado();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CAPA_PRESENTACION.Properties.Resources.delete_remove_close_checkbox_check_icon_181586;
            this.pictureBox1.Location = new System.Drawing.Point(191, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 31);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // combobox1
            // 
            this.combobox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Celeste",
            "Verde",
            "Aqua",
            "Morado",
            "Defecto"});
            this.combobox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combobox1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.combobox1.BorderSize = 1;
            this.combobox1.DisplayMember = "Acua";
            this.combobox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.combobox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.combobox1.ForeColor = System.Drawing.Color.DimGray;
            this.combobox1.IconColor = System.Drawing.Color.DodgerBlue;
            this.combobox1.Items.AddRange(new object[] {
            "Defecto",
            "Acua",
            "Celeste",
            "Morado",
            "Verde"});
            this.combobox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.combobox1.ListTextColor = System.Drawing.Color.DimGray;
            this.combobox1.Location = new System.Drawing.Point(9, 36);
            this.combobox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.combobox1.Name = "combobox1";
            this.combobox1.Padding = new System.Windows.Forms.Padding(1);
            this.combobox1.Size = new System.Drawing.Size(200, 30);
            this.combobox1.TabIndex = 0;
            this.combobox1.Texts = "";
            this.combobox1.OnSelectedIndexChanged += new System.EventHandler(this.combobox1_OnSelectedIndexChanged);
            // 
            // buttonpersolizado1
            // 
            this.buttonpersolizado1.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonpersolizado1.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.buttonpersolizado1.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.buttonpersolizado1.BorderRadius = 5;
            this.buttonpersolizado1.BorderSize = 0;
            this.buttonpersolizado1.FlatAppearance.BorderSize = 0;
            this.buttonpersolizado1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.buttonpersolizado1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.buttonpersolizado1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonpersolizado1.ForeColor = System.Drawing.Color.White;
            this.buttonpersolizado1.Location = new System.Drawing.Point(37, 86);
            this.buttonpersolizado1.Name = "buttonpersolizado1";
            this.buttonpersolizado1.Size = new System.Drawing.Size(150, 40);
            this.buttonpersolizado1.TabIndex = 2;
            this.buttonpersolizado1.Text = "Cambiar";
            this.buttonpersolizado1.TextColor = System.Drawing.Color.White;
            this.buttonpersolizado1.UseVisualStyleBackColor = false;
            this.buttonpersolizado1.Click += new System.EventHandler(this.buttonpersolizado1_Click);
            // 
            // Temas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 152);
            this.Controls.Add(this.buttonpersolizado1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.combobox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Temas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Combobox combobox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Buttonpersolizado buttonpersolizado1;
    }
}