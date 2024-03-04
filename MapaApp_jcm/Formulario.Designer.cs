namespace MapaApp_jcm
{
    partial class Formulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            this.gMapView = new GMap.NET.WindowsForms.GMapControl();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtPickerEvento = new System.Windows.Forms.DateTimePicker();
            this.dtPickerAudit = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.nudCadCantidad = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudCadSindatos = new System.Windows.Forms.NumericUpDown();
            this.nudMaqSindatos = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nudMaqCantidad = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLatitud = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.btnBorrarLL = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCadCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCadSindatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaqSindatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaqCantidad)).BeginInit();
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
            this.gMapView.Location = new System.Drawing.Point(22, 21);
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
            this.gMapView.Size = new System.Drawing.Size(477, 478);
            this.gMapView.TabIndex = 0;
            this.gMapView.Zoom = 0D;
            this.gMapView.Load += new System.EventHandler(this.gMapView_Load);
            // 
            // panel1
            // 
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
            this.panel1.Location = new System.Drawing.Point(506, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 162);
            this.panel1.TabIndex = 6;
            // 
            // rbUcayali
            // 
            this.rbUcayali.AutoSize = true;
            this.rbUcayali.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUcayali.Location = new System.Drawing.Point(323, 133);
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
            this.rbTumbes.Location = new System.Drawing.Point(222, 133);
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
            this.rbTacna.Location = new System.Drawing.Point(124, 133);
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
            this.rbSanMartin.Location = new System.Drawing.Point(11, 133);
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
            this.rbPuno.Location = new System.Drawing.Point(323, 109);
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
            this.rbPiura.Location = new System.Drawing.Point(222, 109);
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
            this.rbPasco.Location = new System.Drawing.Point(124, 109);
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
            this.rbMoquegua.Location = new System.Drawing.Point(11, 109);
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
            this.rbMadredeDios.Location = new System.Drawing.Point(323, 85);
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
            this.rbHuancavelica.Location = new System.Drawing.Point(323, 37);
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
            this.rbLoreto.Location = new System.Drawing.Point(222, 85);
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
            this.rbLima.Location = new System.Drawing.Point(124, 85);
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
            this.rbLambayeque.Location = new System.Drawing.Point(11, 85);
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
            this.rbLibertad.Location = new System.Drawing.Point(323, 61);
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
            this.rbJunin.Location = new System.Drawing.Point(222, 61);
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
            this.rbIca.Location = new System.Drawing.Point(124, 61);
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
            this.rbHuanuco.Location = new System.Drawing.Point(11, 61);
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
            this.rbCusco.Location = new System.Drawing.Point(222, 37);
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
            this.rbAyacucho.Location = new System.Drawing.Point(11, 37);
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
            this.rbCajamarca.Location = new System.Drawing.Point(124, 37);
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
            this.rbArequipa.Location = new System.Drawing.Point(323, 13);
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
            this.rbApurimac.Location = new System.Drawing.Point(222, 13);
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
            this.rbAmazonas.Location = new System.Drawing.Point(11, 13);
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
            this.rbAncash.Location = new System.Drawing.Point(124, 13);
            this.rbAncash.Name = "rbAncash";
            this.rbAncash.Size = new System.Drawing.Size(64, 18);
            this.rbAncash.TabIndex = 8;
            this.rbAncash.Text = "Ancash";
            this.rbAncash.UseVisualStyleBackColor = true;
            this.rbAncash.CheckedChanged += new System.EventHandler(this.rbAncash_CheckedChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackgroundImage = global::MapaApp.Properties.Resources.backBlueSky;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(666, 458);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 41);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Visible = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Location = new System.Drawing.Point(500, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 35);
            this.panel2.TabIndex = 14;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(454, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "OPCION LOCAL";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(624, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(304, 23);
            this.txtNombre.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(515, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "NOMBRE :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(515, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "ULTIMO EVENTO :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(515, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "ULTIMO AUDIT.  :";
            // 
            // dtPickerEvento
            // 
            this.dtPickerEvento.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtPickerEvento.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.dtPickerEvento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerEvento.Location = new System.Drawing.Point(624, 103);
            this.dtPickerEvento.Name = "dtPickerEvento";
            this.dtPickerEvento.Size = new System.Drawing.Size(304, 23);
            this.dtPickerEvento.TabIndex = 19;
            this.dtPickerEvento.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // dtPickerAudit
            // 
            this.dtPickerAudit.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtPickerAudit.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.dtPickerAudit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerAudit.Location = new System.Drawing.Point(624, 140);
            this.dtPickerAudit.Name = "dtPickerAudit";
            this.dtPickerAudit.Size = new System.Drawing.Size(304, 23);
            this.dtPickerAudit.TabIndex = 20;
            this.dtPickerAudit.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(515, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "CAD. CANTIDAD :";
            // 
            // nudCadCantidad
            // 
            this.nudCadCantidad.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.nudCadCantidad.Location = new System.Drawing.Point(624, 177);
            this.nudCadCantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCadCantidad.Name = "nudCadCantidad";
            this.nudCadCantidad.Size = new System.Drawing.Size(87, 23);
            this.nudCadCantidad.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(730, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "CAD. SIN DATOS :";
            // 
            // nudCadSindatos
            // 
            this.nudCadSindatos.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.nudCadSindatos.Location = new System.Drawing.Point(841, 177);
            this.nudCadSindatos.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCadSindatos.Name = "nudCadSindatos";
            this.nudCadSindatos.Size = new System.Drawing.Size(87, 23);
            this.nudCadSindatos.TabIndex = 25;
            // 
            // nudMaqSindatos
            // 
            this.nudMaqSindatos.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.nudMaqSindatos.Location = new System.Drawing.Point(841, 214);
            this.nudMaqSindatos.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMaqSindatos.Name = "nudMaqSindatos";
            this.nudMaqSindatos.Size = new System.Drawing.Size(87, 23);
            this.nudMaqSindatos.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(730, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "MAQ. SIN DATOS :";
            // 
            // nudMaqCantidad
            // 
            this.nudMaqCantidad.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.nudMaqCantidad.Location = new System.Drawing.Point(624, 214);
            this.nudMaqCantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMaqCantidad.Name = "nudMaqCantidad";
            this.nudMaqCantidad.Size = new System.Drawing.Size(87, 23);
            this.nudMaqCantidad.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(515, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "MAQ. CANTIDAD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(696, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "LONGITUD :";
            // 
            // txtLatitud
            // 
            this.txtLatitud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLatitud.Cursor = System.Windows.Forms.Cursors.No;
            this.txtLatitud.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLatitud.Location = new System.Drawing.Point(579, 251);
            this.txtLatitud.Name = "txtLatitud";
            this.txtLatitud.ReadOnly = true;
            this.txtLatitud.Size = new System.Drawing.Size(107, 23);
            this.txtLatitud.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(515, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "LATITUD :";
            // 
            // txtLongitud
            // 
            this.txtLongitud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLongitud.Cursor = System.Windows.Forms.Cursors.No;
            this.txtLongitud.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLongitud.Location = new System.Drawing.Point(773, 251);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.ReadOnly = true;
            this.txtLongitud.Size = new System.Drawing.Size(107, 23);
            this.txtLongitud.TabIndex = 33;
            // 
            // btnBorrarLL
            // 
            this.btnBorrarLL.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrarLL.BackgroundImage = global::MapaApp.Properties.Resources.backButton;
            this.btnBorrarLL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrarLL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarLL.FlatAppearance.BorderSize = 0;
            this.btnBorrarLL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarLL.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarLL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrarLL.Location = new System.Drawing.Point(893, 248);
            this.btnBorrarLL.Name = "btnBorrarLL";
            this.btnBorrarLL.Size = new System.Drawing.Size(35, 28);
            this.btnBorrarLL.TabIndex = 34;
            this.btnBorrarLL.Text = "X";
            this.btnBorrarLL.UseVisualStyleBackColor = false;
            this.btnBorrarLL.Click += new System.EventHandler(this.btnBorrarLL_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BackgroundImage = global::MapaApp.Properties.Resources.backBlueSky;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(666, 458);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(121, 41);
            this.btnEditar.TabIndex = 35;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 518);
            this.Controls.Add(this.btnBorrarLL);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLatitud);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudMaqSindatos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudMaqCantidad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nudCadSindatos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudCadCantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtPickerAudit);
            this.Controls.Add(this.dtPickerEvento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gMapView);
            this.Controls.Add(this.btnEditar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Local";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCadCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCadSindatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaqSindatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaqCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbUcayali;
        private System.Windows.Forms.RadioButton rbTumbes;
        private System.Windows.Forms.RadioButton rbTacna;
        private System.Windows.Forms.RadioButton rbSanMartin;
        private System.Windows.Forms.RadioButton rbPuno;
        private System.Windows.Forms.RadioButton rbPiura;
        private System.Windows.Forms.RadioButton rbPasco;
        private System.Windows.Forms.RadioButton rbMoquegua;
        private System.Windows.Forms.RadioButton rbMadredeDios;
        private System.Windows.Forms.RadioButton rbHuancavelica;
        private System.Windows.Forms.RadioButton rbLoreto;
        private System.Windows.Forms.RadioButton rbLima;
        private System.Windows.Forms.RadioButton rbLambayeque;
        private System.Windows.Forms.RadioButton rbLibertad;
        private System.Windows.Forms.RadioButton rbJunin;
        private System.Windows.Forms.RadioButton rbIca;
        private System.Windows.Forms.RadioButton rbHuanuco;
        private System.Windows.Forms.RadioButton rbCusco;
        private System.Windows.Forms.RadioButton rbAyacucho;
        private System.Windows.Forms.RadioButton rbCajamarca;
        private System.Windows.Forms.RadioButton rbArequipa;
        private System.Windows.Forms.RadioButton rbApurimac;
        private System.Windows.Forms.RadioButton rbAmazonas;
        private System.Windows.Forms.RadioButton rbAncash;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtPickerEvento;
        private System.Windows.Forms.DateTimePicker dtPickerAudit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudCadCantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudCadSindatos;
        private System.Windows.Forms.NumericUpDown nudMaqSindatos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudMaqCantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLatitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.Button btnBorrarLL;
        private System.Windows.Forms.Button btnEditar;
    }
}