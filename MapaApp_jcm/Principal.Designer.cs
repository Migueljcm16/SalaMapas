namespace MapaApp_jcm
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.gMapView = new GMap.NET.WindowsForms.GMapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbDefecto = new System.Windows.Forms.RadioButton();
            this.rbUcayali = new System.Windows.Forms.RadioButton();
            this.rbTumbes = new System.Windows.Forms.RadioButton();
            this.rbTacna = new System.Windows.Forms.RadioButton();
            this.rbSanMartin = new System.Windows.Forms.RadioButton();
            this.rbPuno = new System.Windows.Forms.RadioButton();
            this.rbPiura = new System.Windows.Forms.RadioButton();
            this.rbPasco = new System.Windows.Forms.RadioButton();
            this.rbMoquegua = new System.Windows.Forms.RadioButton();
            this.rbMadredeDios = new System.Windows.Forms.RadioButton();
            this.rbHuancavelica = new System.Windows.Forms.RadioButton();
            this.rbLoreto = new System.Windows.Forms.RadioButton();
            this.rbLima = new System.Windows.Forms.RadioButton();
            this.rbLambayeque = new System.Windows.Forms.RadioButton();
            this.rbLibertad = new System.Windows.Forms.RadioButton();
            this.rbJunin = new System.Windows.Forms.RadioButton();
            this.rbIca = new System.Windows.Forms.RadioButton();
            this.rbHuanuco = new System.Windows.Forms.RadioButton();
            this.rbCusco = new System.Windows.Forms.RadioButton();
            this.rbAyacucho = new System.Windows.Forms.RadioButton();
            this.rbCajamarca = new System.Windows.Forms.RadioButton();
            this.rbArequipa = new System.Windows.Forms.RadioButton();
            this.rbApurimac = new System.Windows.Forms.RadioButton();
            this.rbAmazonas = new System.Windows.Forms.RadioButton();
            this.rbAncash = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaqSinDatos = new System.Windows.Forms.TextBox();
            this.txtMaqTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLocalesTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGVlocales = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnVerLista = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVlocales)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapView
            // 
            this.gMapView.Bearing = 0F;
            this.gMapView.CanDragMap = true;
            this.gMapView.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapView.GrayScaleMode = false;
            this.gMapView.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapView.LevelsKeepInMemory = 5;
            this.gMapView.Location = new System.Drawing.Point(22, 22);
            this.gMapView.MarkersEnabled = true;
            this.gMapView.MaxZoom = 2;
            this.gMapView.MinZoom = 2;
            this.gMapView.MouseWheelZoomEnabled = true;
            this.gMapView.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapView.Name = "gMapView";
            this.gMapView.NegativeMode = false;
            this.gMapView.PolygonsEnabled = true;
            this.gMapView.RetryLoadTile = 0;
            this.gMapView.RoutesEnabled = true;
            this.gMapView.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapView.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapView.ShowTileGridLines = false;
            this.gMapView.Size = new System.Drawing.Size(538, 573);
            this.gMapView.TabIndex = 1;
            this.gMapView.Zoom = 0D;
            this.gMapView.Load += new System.EventHandler(this.gMapView_Load);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbDefecto);
            this.panel1.Controls.Add(this.rbUcayali);
            this.panel1.Controls.Add(this.rbTumbes);
            this.panel1.Controls.Add(this.rbTacna);
            this.panel1.Controls.Add(this.rbSanMartin);
            this.panel1.Controls.Add(this.rbPuno);
            this.panel1.Controls.Add(this.rbPiura);
            this.panel1.Controls.Add(this.rbPasco);
            this.panel1.Controls.Add(this.rbMoquegua);
            this.panel1.Controls.Add(this.rbMadredeDios);
            this.panel1.Controls.Add(this.rbHuancavelica);
            this.panel1.Controls.Add(this.rbLoreto);
            this.panel1.Controls.Add(this.rbLima);
            this.panel1.Controls.Add(this.rbLambayeque);
            this.panel1.Controls.Add(this.rbLibertad);
            this.panel1.Controls.Add(this.rbJunin);
            this.panel1.Controls.Add(this.rbIca);
            this.panel1.Controls.Add(this.rbHuanuco);
            this.panel1.Controls.Add(this.rbCusco);
            this.panel1.Controls.Add(this.rbAyacucho);
            this.panel1.Controls.Add(this.rbCajamarca);
            this.panel1.Controls.Add(this.rbArequipa);
            this.panel1.Controls.Add(this.rbApurimac);
            this.panel1.Controls.Add(this.rbAmazonas);
            this.panel1.Controls.Add(this.rbAncash);
            this.panel1.Location = new System.Drawing.Point(579, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 141);
            this.panel1.TabIndex = 4;
            // 
            // rbDefecto
            // 
            this.rbDefecto.AutoSize = true;
            this.rbDefecto.Checked = true;
            this.rbDefecto.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDefecto.Location = new System.Drawing.Point(11, 13);
            this.rbDefecto.Name = "rbDefecto";
            this.rbDefecto.Size = new System.Drawing.Size(86, 18);
            this.rbDefecto.TabIndex = 11;
            this.rbDefecto.TabStop = true;
            this.rbDefecto.Text = "Por defecto";
            this.rbDefecto.UseVisualStyleBackColor = true;
            this.rbDefecto.CheckedChanged += new System.EventHandler(this.rbDefecto_CheckedChanged);
            // 
            // rbUcayali
            // 
            this.rbUcayali.AutoSize = true;
            this.rbUcayali.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUcayali.Location = new System.Drawing.Point(477, 109);
            this.rbUcayali.Name = "rbUcayali";
            this.rbUcayali.Size = new System.Drawing.Size(65, 18);
            this.rbUcayali.TabIndex = 12;
            this.rbUcayali.Text = "Ucayali";
            this.rbUcayali.UseVisualStyleBackColor = true;
            this.rbUcayali.CheckedChanged += new System.EventHandler(this.rbUcayali_CheckedChanged);
            // 
            // rbTumbes
            // 
            this.rbTumbes.AutoSize = true;
            this.rbTumbes.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTumbes.Location = new System.Drawing.Point(352, 109);
            this.rbTumbes.Name = "rbTumbes";
            this.rbTumbes.Size = new System.Drawing.Size(67, 18);
            this.rbTumbes.TabIndex = 13;
            this.rbTumbes.Text = "Tumbes";
            this.rbTumbes.UseVisualStyleBackColor = true;
            this.rbTumbes.CheckedChanged += new System.EventHandler(this.rbTumbes_CheckedChanged);
            // 
            // rbTacna
            // 
            this.rbTacna.AutoSize = true;
            this.rbTacna.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTacna.Location = new System.Drawing.Point(243, 109);
            this.rbTacna.Name = "rbTacna";
            this.rbTacna.Size = new System.Drawing.Size(56, 18);
            this.rbTacna.TabIndex = 14;
            this.rbTacna.Text = "Tacna";
            this.rbTacna.UseVisualStyleBackColor = true;
            this.rbTacna.CheckedChanged += new System.EventHandler(this.rbTacna_CheckedChanged);
            // 
            // rbSanMartin
            // 
            this.rbSanMartin.AutoSize = true;
            this.rbSanMartin.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSanMartin.Location = new System.Drawing.Point(114, 109);
            this.rbSanMartin.Name = "rbSanMartin";
            this.rbSanMartin.Size = new System.Drawing.Size(83, 18);
            this.rbSanMartin.TabIndex = 15;
            this.rbSanMartin.Text = "San Martín";
            this.rbSanMartin.UseVisualStyleBackColor = true;
            this.rbSanMartin.CheckedChanged += new System.EventHandler(this.rbSanMartin_CheckedChanged);
            // 
            // rbPuno
            // 
            this.rbPuno.AutoSize = true;
            this.rbPuno.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPuno.Location = new System.Drawing.Point(11, 109);
            this.rbPuno.Name = "rbPuno";
            this.rbPuno.Size = new System.Drawing.Size(52, 18);
            this.rbPuno.TabIndex = 16;
            this.rbPuno.Text = "Puno";
            this.rbPuno.UseVisualStyleBackColor = true;
            this.rbPuno.CheckedChanged += new System.EventHandler(this.rbPuno_CheckedChanged);
            // 
            // rbPiura
            // 
            this.rbPiura.AutoSize = true;
            this.rbPiura.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPiura.Location = new System.Drawing.Point(477, 85);
            this.rbPiura.Name = "rbPiura";
            this.rbPiura.Size = new System.Drawing.Size(53, 18);
            this.rbPiura.TabIndex = 17;
            this.rbPiura.Text = "Piura";
            this.rbPiura.UseVisualStyleBackColor = true;
            this.rbPiura.CheckedChanged += new System.EventHandler(this.rbPiura_CheckedChanged);
            // 
            // rbPasco
            // 
            this.rbPasco.AutoSize = true;
            this.rbPasco.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPasco.Location = new System.Drawing.Point(352, 85);
            this.rbPasco.Name = "rbPasco";
            this.rbPasco.Size = new System.Drawing.Size(56, 18);
            this.rbPasco.TabIndex = 18;
            this.rbPasco.Text = "Pasco";
            this.rbPasco.UseVisualStyleBackColor = true;
            this.rbPasco.CheckedChanged += new System.EventHandler(this.rbPasco_CheckedChanged);
            // 
            // rbMoquegua
            // 
            this.rbMoquegua.AutoSize = true;
            this.rbMoquegua.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMoquegua.Location = new System.Drawing.Point(243, 85);
            this.rbMoquegua.Name = "rbMoquegua";
            this.rbMoquegua.Size = new System.Drawing.Size(83, 18);
            this.rbMoquegua.TabIndex = 19;
            this.rbMoquegua.Text = "Moquegua";
            this.rbMoquegua.UseVisualStyleBackColor = true;
            this.rbMoquegua.CheckedChanged += new System.EventHandler(this.rbMoquegua_CheckedChanged);
            // 
            // rbMadredeDios
            // 
            this.rbMadredeDios.AutoSize = true;
            this.rbMadredeDios.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMadredeDios.Location = new System.Drawing.Point(114, 85);
            this.rbMadredeDios.Name = "rbMadredeDios";
            this.rbMadredeDios.Size = new System.Drawing.Size(105, 18);
            this.rbMadredeDios.TabIndex = 6;
            this.rbMadredeDios.Text = "Madre de Dios";
            this.rbMadredeDios.UseVisualStyleBackColor = true;
            this.rbMadredeDios.CheckedChanged += new System.EventHandler(this.rbMadredeDios_CheckedChanged);
            // 
            // rbHuancavelica
            // 
            this.rbHuancavelica.AutoSize = true;
            this.rbHuancavelica.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHuancavelica.Location = new System.Drawing.Point(352, 37);
            this.rbHuancavelica.Name = "rbHuancavelica";
            this.rbHuancavelica.Size = new System.Drawing.Size(98, 18);
            this.rbHuancavelica.TabIndex = 5;
            this.rbHuancavelica.Text = "Huancavelica";
            this.rbHuancavelica.UseVisualStyleBackColor = true;
            this.rbHuancavelica.CheckedChanged += new System.EventHandler(this.rbHuancavelica_CheckedChanged);
            // 
            // rbLoreto
            // 
            this.rbLoreto.AutoSize = true;
            this.rbLoreto.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLoreto.Location = new System.Drawing.Point(11, 85);
            this.rbLoreto.Name = "rbLoreto";
            this.rbLoreto.Size = new System.Drawing.Size(59, 18);
            this.rbLoreto.TabIndex = 20;
            this.rbLoreto.Text = "Loreto";
            this.rbLoreto.UseVisualStyleBackColor = true;
            this.rbLoreto.CheckedChanged += new System.EventHandler(this.rbLoreto_CheckedChanged);
            // 
            // rbLima
            // 
            this.rbLima.AutoSize = true;
            this.rbLima.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLima.Location = new System.Drawing.Point(477, 61);
            this.rbLima.Name = "rbLima";
            this.rbLima.Size = new System.Drawing.Size(51, 18);
            this.rbLima.TabIndex = 21;
            this.rbLima.Text = "Lima";
            this.rbLima.UseVisualStyleBackColor = true;
            this.rbLima.CheckedChanged += new System.EventHandler(this.rbLima_CheckedChanged);
            // 
            // rbLambayeque
            // 
            this.rbLambayeque.AutoSize = true;
            this.rbLambayeque.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLambayeque.Location = new System.Drawing.Point(352, 61);
            this.rbLambayeque.Name = "rbLambayeque";
            this.rbLambayeque.Size = new System.Drawing.Size(94, 18);
            this.rbLambayeque.TabIndex = 22;
            this.rbLambayeque.Text = "Lambayeque";
            this.rbLambayeque.UseVisualStyleBackColor = true;
            this.rbLambayeque.CheckedChanged += new System.EventHandler(this.rbLambayeque_CheckedChanged);
            // 
            // rbLibertad
            // 
            this.rbLibertad.AutoSize = true;
            this.rbLibertad.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLibertad.Location = new System.Drawing.Point(243, 61);
            this.rbLibertad.Name = "rbLibertad";
            this.rbLibertad.Size = new System.Drawing.Size(85, 18);
            this.rbLibertad.TabIndex = 23;
            this.rbLibertad.Text = "La Libertad";
            this.rbLibertad.UseVisualStyleBackColor = true;
            this.rbLibertad.CheckedChanged += new System.EventHandler(this.rbLibertad_CheckedChanged);
            // 
            // rbJunin
            // 
            this.rbJunin.AutoSize = true;
            this.rbJunin.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJunin.Location = new System.Drawing.Point(114, 61);
            this.rbJunin.Name = "rbJunin";
            this.rbJunin.Size = new System.Drawing.Size(53, 18);
            this.rbJunin.TabIndex = 24;
            this.rbJunin.Text = "Junín";
            this.rbJunin.UseVisualStyleBackColor = true;
            this.rbJunin.CheckedChanged += new System.EventHandler(this.rbJunin_CheckedChanged);
            // 
            // rbIca
            // 
            this.rbIca.AutoSize = true;
            this.rbIca.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIca.Location = new System.Drawing.Point(10, 61);
            this.rbIca.Name = "rbIca";
            this.rbIca.Size = new System.Drawing.Size(41, 18);
            this.rbIca.TabIndex = 25;
            this.rbIca.Text = "Ica";
            this.rbIca.UseVisualStyleBackColor = true;
            this.rbIca.CheckedChanged += new System.EventHandler(this.rbIca_CheckedChanged);
            // 
            // rbHuanuco
            // 
            this.rbHuanuco.AutoSize = true;
            this.rbHuanuco.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHuanuco.Location = new System.Drawing.Point(477, 37);
            this.rbHuanuco.Name = "rbHuanuco";
            this.rbHuanuco.Size = new System.Drawing.Size(73, 18);
            this.rbHuanuco.TabIndex = 26;
            this.rbHuanuco.Text = "Huánuco";
            this.rbHuanuco.UseVisualStyleBackColor = true;
            this.rbHuanuco.CheckedChanged += new System.EventHandler(this.rbHuanuco_CheckedChanged);
            // 
            // rbCusco
            // 
            this.rbCusco.AutoSize = true;
            this.rbCusco.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCusco.Location = new System.Drawing.Point(243, 37);
            this.rbCusco.Name = "rbCusco";
            this.rbCusco.Size = new System.Drawing.Size(56, 18);
            this.rbCusco.TabIndex = 27;
            this.rbCusco.Text = "Cusco";
            this.rbCusco.UseVisualStyleBackColor = true;
            this.rbCusco.CheckedChanged += new System.EventHandler(this.rbCusco_CheckedChanged);
            // 
            // rbAyacucho
            // 
            this.rbAyacucho.AutoSize = true;
            this.rbAyacucho.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAyacucho.Location = new System.Drawing.Point(10, 37);
            this.rbAyacucho.Name = "rbAyacucho";
            this.rbAyacucho.Size = new System.Drawing.Size(75, 18);
            this.rbAyacucho.TabIndex = 29;
            this.rbAyacucho.Text = "Ayacucho";
            this.rbAyacucho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbAyacucho.UseVisualStyleBackColor = true;
            this.rbAyacucho.CheckedChanged += new System.EventHandler(this.rbAyacucho_CheckedChanged);
            // 
            // rbCajamarca
            // 
            this.rbCajamarca.AutoSize = true;
            this.rbCajamarca.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCajamarca.Location = new System.Drawing.Point(114, 37);
            this.rbCajamarca.Name = "rbCajamarca";
            this.rbCajamarca.Size = new System.Drawing.Size(81, 18);
            this.rbCajamarca.TabIndex = 28;
            this.rbCajamarca.Text = "Cajamarca";
            this.rbCajamarca.UseVisualStyleBackColor = true;
            this.rbCajamarca.CheckedChanged += new System.EventHandler(this.rbCajamarca_CheckedChanged);
            // 
            // rbArequipa
            // 
            this.rbArequipa.AutoSize = true;
            this.rbArequipa.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbArequipa.Location = new System.Drawing.Point(477, 13);
            this.rbArequipa.Name = "rbArequipa";
            this.rbArequipa.Size = new System.Drawing.Size(75, 18);
            this.rbArequipa.TabIndex = 30;
            this.rbArequipa.Text = "Arequipa";
            this.rbArequipa.UseVisualStyleBackColor = true;
            this.rbArequipa.CheckedChanged += new System.EventHandler(this.rbArequipa_CheckedChanged);
            // 
            // rbApurimac
            // 
            this.rbApurimac.AutoSize = true;
            this.rbApurimac.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbApurimac.Location = new System.Drawing.Point(352, 13);
            this.rbApurimac.Name = "rbApurimac";
            this.rbApurimac.Size = new System.Drawing.Size(75, 18);
            this.rbApurimac.TabIndex = 31;
            this.rbApurimac.Text = "Apurímac";
            this.rbApurimac.UseVisualStyleBackColor = true;
            this.rbApurimac.CheckedChanged += new System.EventHandler(this.rbApurimac_CheckedChanged);
            // 
            // rbAmazonas
            // 
            this.rbAmazonas.AutoSize = true;
            this.rbAmazonas.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAmazonas.Location = new System.Drawing.Point(114, 13);
            this.rbAmazonas.Name = "rbAmazonas";
            this.rbAmazonas.Size = new System.Drawing.Size(81, 18);
            this.rbAmazonas.TabIndex = 7;
            this.rbAmazonas.Text = "Amazonas";
            this.rbAmazonas.UseVisualStyleBackColor = true;
            this.rbAmazonas.CheckedChanged += new System.EventHandler(this.rbAmazonas_CheckedChanged);
            // 
            // rbAncash
            // 
            this.rbAncash.AutoSize = true;
            this.rbAncash.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAncash.Location = new System.Drawing.Point(243, 13);
            this.rbAncash.Name = "rbAncash";
            this.rbAncash.Size = new System.Drawing.Size(64, 18);
            this.rbAncash.TabIndex = 8;
            this.rbAncash.Text = "Ancash";
            this.rbAncash.UseVisualStyleBackColor = true;
            this.rbAncash.CheckedChanged += new System.EventHandler(this.rbAncash_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(587, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "UBICACIONES";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtMaqSinDatos);
            this.panel2.Controls.Add(this.txtMaqTotal);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtLocalesTotal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(579, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 45);
            this.panel2.TabIndex = 5;
            // 
            // txtMaqSinDatos
            // 
            this.txtMaqSinDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaqSinDatos.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaqSinDatos.Location = new System.Drawing.Point(483, 10);
            this.txtMaqSinDatos.Name = "txtMaqSinDatos";
            this.txtMaqSinDatos.ReadOnly = true;
            this.txtMaqSinDatos.Size = new System.Drawing.Size(69, 22);
            this.txtMaqSinDatos.TabIndex = 20;
            this.txtMaqSinDatos.Text = "00000";
            this.txtMaqSinDatos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaqTotal
            // 
            this.txtMaqTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaqTotal.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaqTotal.Location = new System.Drawing.Point(289, 10);
            this.txtMaqTotal.Name = "txtMaqTotal";
            this.txtMaqTotal.ReadOnly = true;
            this.txtMaqTotal.Size = new System.Drawing.Size(69, 22);
            this.txtMaqTotal.TabIndex = 19;
            this.txtMaqTotal.Text = "00000";
            this.txtMaqTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Maq. sin Datos :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(201, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Maq. Totales :";
            // 
            // txtLocalesTotal
            // 
            this.txtLocalesTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocalesTotal.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalesTotal.Location = new System.Drawing.Point(108, 10);
            this.txtLocalesTotal.Name = "txtLocalesTotal";
            this.txtLocalesTotal.ReadOnly = true;
            this.txtLocalesTotal.Size = new System.Drawing.Size(69, 22);
            this.txtLocalesTotal.TabIndex = 7;
            this.txtLocalesTotal.Text = "00000";
            this.txtLocalesTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Locales Totales :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(587, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "DATOS DE UBICACION";
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVlocales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGVlocales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVlocales.Location = new System.Drawing.Point(578, 238);
            this.dataGVlocales.Name = "dataGVlocales";
            this.dataGVlocales.ReadOnly = true;
            this.dataGVlocales.Size = new System.Drawing.Size(568, 298);
            this.dataGVlocales.TabIndex = 7;
            this.dataGVlocales.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGVlocales_DataBindingComplete);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::MapaApp.Properties.Resources.Info;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(22, 432);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 131);
            this.panel3.TabIndex = 9;
            // 
            // btnVerLista
            // 
            this.btnVerLista.BackColor = System.Drawing.Color.Transparent;
            this.btnVerLista.BackgroundImage = global::MapaApp.Properties.Resources.backGreenExcel;
            this.btnVerLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerLista.FlatAppearance.BorderSize = 0;
            this.btnVerLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerLista.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerLista.Image = global::MapaApp.Properties.Resources.lista;
            this.btnVerLista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerLista.Location = new System.Drawing.Point(802, 554);
            this.btnVerLista.Name = "btnVerLista";
            this.btnVerLista.Padding = new System.Windows.Forms.Padding(7, 0, 5, 0);
            this.btnVerLista.Size = new System.Drawing.Size(121, 41);
            this.btnVerLista.TabIndex = 8;
            this.btnVerLista.Text = "VER LISTA";
            this.btnVerLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerLista.UseVisualStyleBackColor = false;
            this.btnVerLista.Click += new System.EventHandler(this.btnVerLista_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 619);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnVerLista);
            this.Controls.Add(this.dataGVlocales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gMapView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mapa Locales - JCM";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVlocales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbHuancavelica;
        private System.Windows.Forms.RadioButton rbApurimac;
        private System.Windows.Forms.RadioButton rbAmazonas;
        private System.Windows.Forms.RadioButton rbMadredeDios;
        private System.Windows.Forms.RadioButton rbAncash;
        private System.Windows.Forms.RadioButton rbUcayali;
        private System.Windows.Forms.RadioButton rbTumbes;
        private System.Windows.Forms.RadioButton rbTacna;
        private System.Windows.Forms.RadioButton rbSanMartin;
        private System.Windows.Forms.RadioButton rbPuno;
        private System.Windows.Forms.RadioButton rbPiura;
        private System.Windows.Forms.RadioButton rbPasco;
        private System.Windows.Forms.RadioButton rbMoquegua;
        private System.Windows.Forms.RadioButton rbLoreto;
        private System.Windows.Forms.RadioButton rbLima;
        private System.Windows.Forms.RadioButton rbLambayeque;
        private System.Windows.Forms.RadioButton rbLibertad;
        private System.Windows.Forms.RadioButton rbJunin;
        private System.Windows.Forms.RadioButton rbIca;
        private System.Windows.Forms.RadioButton rbHuanuco;
        private System.Windows.Forms.RadioButton rbCusco;
        private System.Windows.Forms.RadioButton rbCajamarca;
        private System.Windows.Forms.RadioButton rbAyacucho;
        private System.Windows.Forms.RadioButton rbArequipa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLocalesTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaqSinDatos;
        private System.Windows.Forms.TextBox txtMaqTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGVlocales;
        private System.Windows.Forms.Button btnVerLista;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.RadioButton rbDefecto;
    }
}

