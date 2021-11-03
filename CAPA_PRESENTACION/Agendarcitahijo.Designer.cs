
namespace CAPA_PRESENTACION
{
    partial class Agendarcitahijo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtacita = new System.Windows.Forms.DataGridView();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelagenda = new CAPA_PRESENTACION.Paneldegradado();
            this.Fechacita = new System.Windows.Forms.Label();
            this.Calendaragenda = new System.Windows.Forms.MonthCalendar();
            this.buttonpersolizado1 = new CAPA_PRESENTACION.Buttonpersolizado();
            this.textapellido = new CAPA_PRESENTACION.textboxpersonal();
            this.textnombre = new CAPA_PRESENTACION.textboxpersonal();
            this.textcodigo = new CAPA_PRESENTACION.textboxpersonal();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comidin = new CAPA_PRESENTACION.Pictureboxpersonal();
            ((System.ComponentModel.ISupportInitialize)(this.dtacita)).BeginInit();
            this.panelagenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comidin)).BeginInit();
            this.SuspendLayout();
            // 
            // dtacita
            // 
            this.dtacita.AllowUserToResizeColumns = false;
            this.dtacita.AllowUserToResizeRows = false;
            this.dtacita.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtacita.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtacita.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dtacita.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtacita.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtacita.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtacita.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtacita.ColumnHeadersHeight = 30;
            this.dtacita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtacita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hora,
            this.Cita});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtacita.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtacita.EnableHeadersVisualStyles = false;
            this.dtacita.GridColor = System.Drawing.Color.PaleTurquoise;
            this.dtacita.Location = new System.Drawing.Point(422, 12);
            this.dtacita.Name = "dtacita";
            this.dtacita.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtacita.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtacita.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtacita.ShowCellErrors = false;
            this.dtacita.ShowCellToolTips = false;
            this.dtacita.ShowEditingIcon = false;
            this.dtacita.ShowRowErrors = false;
            this.dtacita.Size = new System.Drawing.Size(398, 532);
            this.dtacita.TabIndex = 6;
            this.dtacita.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtacita_CellContentClick);
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora de cita";
            this.Hora.Name = "Hora";
            this.Hora.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Cita
            // 
            this.Cita.HeaderText = "Nombre del estudiante";
            this.Cita.Name = "Cita";
            // 
            // panelagenda
            // 
            this.panelagenda.angulo = 0F;
            this.panelagenda.Colorleft = System.Drawing.Color.Empty;
            this.panelagenda.Colorrigth = System.Drawing.Color.Empty;
            this.panelagenda.Controls.Add(this.Fechacita);
            this.panelagenda.Controls.Add(this.Calendaragenda);
            this.panelagenda.Controls.Add(this.buttonpersolizado1);
            this.panelagenda.Controls.Add(this.textapellido);
            this.panelagenda.Controls.Add(this.textnombre);
            this.panelagenda.Controls.Add(this.textcodigo);
            this.panelagenda.Controls.Add(this.label6);
            this.panelagenda.Controls.Add(this.label5);
            this.panelagenda.Controls.Add(this.label4);
            this.panelagenda.Controls.Add(this.label2);
            this.panelagenda.Controls.Add(this.label1);
            this.panelagenda.Controls.Add(this.comidin);
            this.panelagenda.Location = new System.Drawing.Point(30, 12);
            this.panelagenda.Name = "panelagenda";
            this.panelagenda.Size = new System.Drawing.Size(386, 532);
            this.panelagenda.TabIndex = 5;
            // 
            // Fechacita
            // 
            this.Fechacita.AutoSize = true;
            this.Fechacita.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechacita.ForeColor = System.Drawing.Color.White;
            this.Fechacita.Location = new System.Drawing.Point(133, 281);
            this.Fechacita.Name = "Fechacita";
            this.Fechacita.Size = new System.Drawing.Size(52, 16);
            this.Fechacita.TabIndex = 13;
            this.Fechacita.Text = "label1";
            // 
            // Calendaragenda
            // 
            this.Calendaragenda.Location = new System.Drawing.Point(129, 306);
            this.Calendaragenda.Name = "Calendaragenda";
            this.Calendaragenda.TabIndex = 12;
            this.Calendaragenda.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendaragenda_DateChanged);
            // 
            // buttonpersolizado1
            // 
            this.buttonpersolizado1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonpersolizado1.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.buttonpersolizado1.BorderColor = System.Drawing.Color.DarkBlue;
            this.buttonpersolizado1.BorderRadius = 20;
            this.buttonpersolizado1.BorderSize = 0;
            this.buttonpersolizado1.FlatAppearance.BorderSize = 0;
            this.buttonpersolizado1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonpersolizado1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonpersolizado1.ForeColor = System.Drawing.Color.White;
            this.buttonpersolizado1.Location = new System.Drawing.Point(82, 480);
            this.buttonpersolizado1.Name = "buttonpersolizado1";
            this.buttonpersolizado1.Size = new System.Drawing.Size(150, 40);
            this.buttonpersolizado1.TabIndex = 11;
            this.buttonpersolizado1.Text = "Agendar cita";
            this.buttonpersolizado1.TextColor = System.Drawing.Color.White;
            this.buttonpersolizado1.UseVisualStyleBackColor = false;
            this.buttonpersolizado1.Click += new System.EventHandler(this.buttonpersolizado1_Click);
            // 
            // textapellido
            // 
            this.textapellido.BackColor = System.Drawing.Color.SkyBlue;
            this.textapellido.BorderColor = System.Drawing.Color.DodgerBlue;
            this.textapellido.BorderFocusColor = System.Drawing.Color.Blue;
            this.textapellido.BorderRadius = 0;
            this.textapellido.BorderSize = 2;
            this.textapellido.Enabled = false;
            this.textapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textapellido.IsFocused = false;
            this.textapellido.IsPasswordChar = false;
            this.textapellido.IsPlaceholder = false;
            this.textapellido.Location = new System.Drawing.Point(106, 232);
            this.textapellido.Margin = new System.Windows.Forms.Padding(4);
            this.textapellido.Multiline = false;
            this.textapellido.Name = "textapellido";
            this.textapellido.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textapellido.PasswordChar = false;
            this.textapellido.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textapellido.PlaceholderText = "";
            this.textapellido.Size = new System.Drawing.Size(188, 31);
            this.textapellido.TabIndex = 9;
            this.textapellido.Texts = "";
            this.textapellido.UnderlinedStyle = true;
            // 
            // textnombre
            // 
            this.textnombre.BackColor = System.Drawing.Color.SkyBlue;
            this.textnombre.BorderColor = System.Drawing.Color.DodgerBlue;
            this.textnombre.BorderFocusColor = System.Drawing.Color.Blue;
            this.textnombre.BorderRadius = 0;
            this.textnombre.BorderSize = 2;
            this.textnombre.Enabled = false;
            this.textnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnombre.IsFocused = false;
            this.textnombre.IsPasswordChar = false;
            this.textnombre.IsPlaceholder = false;
            this.textnombre.Location = new System.Drawing.Point(106, 177);
            this.textnombre.Margin = new System.Windows.Forms.Padding(4);
            this.textnombre.Multiline = false;
            this.textnombre.Name = "textnombre";
            this.textnombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textnombre.PasswordChar = false;
            this.textnombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textnombre.PlaceholderText = "";
            this.textnombre.Size = new System.Drawing.Size(183, 31);
            this.textnombre.TabIndex = 8;
            this.textnombre.Texts = "";
            this.textnombre.UnderlinedStyle = true;
            // 
            // textcodigo
            // 
            this.textcodigo.BackColor = System.Drawing.Color.SkyBlue;
            this.textcodigo.BorderColor = System.Drawing.Color.DodgerBlue;
            this.textcodigo.BorderFocusColor = System.Drawing.Color.Blue;
            this.textcodigo.BorderRadius = 0;
            this.textcodigo.BorderSize = 2;
            this.textcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcodigo.IsFocused = false;
            this.textcodigo.IsPasswordChar = false;
            this.textcodigo.IsPlaceholder = false;
            this.textcodigo.Location = new System.Drawing.Point(93, 128);
            this.textcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.textcodigo.Multiline = false;
            this.textcodigo.Name = "textcodigo";
            this.textcodigo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textcodigo.PasswordChar = false;
            this.textcodigo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textcodigo.PlaceholderText = "";
            this.textcodigo.Size = new System.Drawing.Size(92, 31);
            this.textcodigo.TabIndex = 7;
            this.textcodigo.Texts = "";
            this.textcodigo.UnderlinedStyle = true;
            this.textcodigo.Visible = false;
            this.textcodigo._TextChanged += new System.EventHandler(this.textcodigo__TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de cita:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(5)));
            this.label1.Location = new System.Drawing.Point(109, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agendas de citas";
            // 
            // comidin
            // 
            this.comidin.Bordercapstyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.comidin.Bordercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.comidin.Bordercolor2 = System.Drawing.Color.Cyan;
            this.comidin.Borderlinestyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.comidin.Bordersize = 5;
            this.comidin.Gradient = 50F;
            this.comidin.Image = global::CAPA_PRESENTACION.Properties.Resources.medical_42_icon_icons_com_73897;
            this.comidin.Location = new System.Drawing.Point(3, 3);
            this.comidin.Name = "comidin";
            this.comidin.Size = new System.Drawing.Size(100, 106);
            this.comidin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.comidin.TabIndex = 0;
            this.comidin.TabStop = false;
            // 
            // Agendarcitahijo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(832, 612);
            this.Controls.Add(this.panelagenda);
            this.Controls.Add(this.dtacita);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agendarcitahijo";
            this.Text = "Agendarcitahijo";
            this.Load += new System.EventHandler(this.Agendarcitahijo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtacita)).EndInit();
            this.panelagenda.ResumeLayout(false);
            this.panelagenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comidin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Paneldegradado panelagenda;
        private System.Windows.Forms.Label label1;
        private Pictureboxpersonal comidin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Buttonpersolizado buttonpersolizado1;
        private System.Windows.Forms.DataGridView dtacita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cita;
        private System.Windows.Forms.MonthCalendar Calendaragenda;
        public textboxpersonal textapellido;
        public textboxpersonal textnombre;
        public textboxpersonal textcodigo;
        public System.Windows.Forms.Label Fechacita;
    }
}