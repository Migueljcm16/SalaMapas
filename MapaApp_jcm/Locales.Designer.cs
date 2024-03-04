namespace MapaApp_jcm
{
    partial class Locales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Locales));
            this.dataGVlocales = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnMapaPrincipal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVlocales)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVlocales
            // 
            this.dataGVlocales.AllowUserToAddRows = false;
            this.dataGVlocales.AllowUserToDeleteRows = false;
            this.dataGVlocales.AllowUserToResizeRows = false;
            this.dataGVlocales.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGVlocales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVlocales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGVlocales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVlocales.Location = new System.Drawing.Point(16, 50);
            this.dataGVlocales.MultiSelect = false;
            this.dataGVlocales.Name = "dataGVlocales";
            this.dataGVlocales.ReadOnly = true;
            this.dataGVlocales.Size = new System.Drawing.Size(1138, 509);
            this.dataGVlocales.TabIndex = 0;
            this.dataGVlocales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVlocales_CellContentClick);
            this.dataGVlocales.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGVlocales_CellPainting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "FILTRAR POR";
            // 
            // cboFiltro
            // 
            this.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltro.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Items.AddRange(new object[] {
            "Por defecto",
            "Nombre",
            "Departamento",
            "Cantidad Cad.",
            "Cantidad Maq."});
            this.cboFiltro.Location = new System.Drawing.Point(113, 13);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(143, 26);
            this.cboFiltro.TabIndex = 2;
            this.cboFiltro.SelectedIndexChanged += new System.EventHandler(this.cboFiltro_SelectedIndexChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = global::MapaApp.Properties.Resources.backButton;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.Location = new System.Drawing.Point(1021, 570);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(133, 37);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "NUEVO LOCAL";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnMapaPrincipal
            // 
            this.btnMapaPrincipal.BackgroundImage = global::MapaApp.Properties.Resources.backBlueSky;
            this.btnMapaPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMapaPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMapaPrincipal.FlatAppearance.BorderSize = 0;
            this.btnMapaPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMapaPrincipal.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnMapaPrincipal.Location = new System.Drawing.Point(16, 570);
            this.btnMapaPrincipal.Name = "btnMapaPrincipal";
            this.btnMapaPrincipal.Size = new System.Drawing.Size(133, 37);
            this.btnMapaPrincipal.TabIndex = 3;
            this.btnMapaPrincipal.Text = "VOLVER AL MAPA";
            this.btnMapaPrincipal.UseVisualStyleBackColor = true;
            this.btnMapaPrincipal.Click += new System.EventHandler(this.btnMapaPrincipal_Click);
            // 
            // Locales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 619);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnMapaPrincipal);
            this.Controls.Add(this.cboFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGVlocales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Locales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabla de locales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Locales_FormClosing);
            this.Load += new System.EventHandler(this.Locales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVlocales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVlocales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFiltro;
        private System.Windows.Forms.Button btnMapaPrincipal;
        private System.Windows.Forms.Button btnNuevo;
    }
}