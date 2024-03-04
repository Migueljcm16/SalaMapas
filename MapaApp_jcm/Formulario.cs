using GMap.NET.MapProviders;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GMap.NET.Entity.OpenStreetMapRouteEntity;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using MapaApp_jcm.Repository.Controller;
using MapaApp_jcm.Models;
using System.Globalization;

namespace MapaApp_jcm
{
    public partial class Formulario : Form
    {
        private Locales frmlocales;
        double latInicial = -9.635995;
        double lngInicial = -75.7260814;
        int codigo;
        double latEdit;
        double lngEdit;
        private string departamento = null;
        private GMapMarker marcador;
        private GMapOverlay markerOverlay;
        LocalesRepository classLocales = new LocalesRepository();

        public Formulario(Locales frmlocales, String opcion, int? codigo, String nombre, DateTime? evento, DateTime? audit, int? cad_cantidad, int? cad_sinDatos, int? maq_cantidad, int? maq_sinDatos, String departamento, String latitud, String longitud)
        {
            InitializeComponent();
            this.frmlocales = frmlocales;

            if(opcion == "AGREGAR LOCAL")
            {
                btnAgregar.Visible = true;
                lblTitulo.Text = "AGREGAR LOCAL";
                UbicacionDefecto();
            } 
            else if(opcion == "EDITAR LOCAL")
            {
                btnEditar.Visible = true;
                lblTitulo.Text = "EDITAR LOCAL";

                this.codigo = (int)codigo;
                txtNombre.Text = nombre;
                dtPickerEvento.Text = evento.ToString();
                dtPickerAudit.Text = audit.ToString();
                nudCadCantidad.Value = (decimal)cad_cantidad;
                nudCadSindatos.Value = (decimal)cad_sinDatos;
                nudMaqCantidad.Value = (decimal)maq_cantidad;
                nudMaqSindatos.Value = (decimal)maq_sinDatos;
                txtLatitud.Text = latitud;
                txtLongitud.Text = longitud;


                if(latitud != null && longitud != null)
                {
                    latEdit = Convert.ToDouble(latitud);
                    lngEdit = Convert.ToDouble(longitud);
                }

                foreach (Control control in panel1.Controls)
                {
                    if (control is RadioButton radioButton)
                    {
                        if (radioButton.Text == departamento)
                        {
                            radioButton.Checked = true;
                            radioButton.PerformClick();
                            this.departamento = departamento;

                            break;
                        }
                    }
                }
            }
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            gMapView.DragButton = MouseButtons.Left;
            gMapView.CanDragMap = true;
            gMapView.MapProvider = GMapProviders.GoogleMap;
            gMapView.ShowCenter = false;
            gMapView.AutoScroll = true;
        }

        private void UbicacionDefecto()
        {
            gMapView.Position = new PointLatLng(latInicial, lngInicial);
            gMapView.MinZoom = 5;
            gMapView.MaxZoom = 5;
            gMapView.Zoom = 5;
        }

        private void CargarUbicacionMP(double lat, double lng)
        {
            gMapView.Position = new PointLatLng(lat, lng);
            gMapView.CanDragMap = true;
            gMapView.MinZoom = 7;
            gMapView.MaxZoom = 16;
            gMapView.Zoom = 7;

            gMapView.MouseDoubleClick += gMapView_MouseDoubleClick;
        }

        private void gMapView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double latitud = gMapView.FromLocalToLatLng(e.X, e.Y).Lat;
            double longitud = gMapView.FromLocalToLatLng(e.X, e.Y).Lng;

            txtLatitud.Text = latitud.ToString();
            txtLongitud.Text = longitud.ToString();

            marcador.Position = new PointLatLng(latitud, longitud);

            marcador.IsVisible = true;
        }

        private void rbAmazonas_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-5.0435887, -77.8897181);
            departamento = "Amazonas";
        }

        private void rbAncash_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-9.4182822, -77.579869);
            departamento = "Ancash";
        }

        private void rbApurimac_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-14.1336959, -72.8299265);
            departamento = "Apurimac";
        }

        private void rbArequipa_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-16.4203011, -71.4617556);
            departamento = "Arequipa";
        }

        private void rbUcayali_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-9.6217292, -73.3473017);
            departamento = "Ucayali";
        }

        private void rbCajamarca_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-6.2438484, -78.5189894);
            departamento = "Cajamarca";
        }

        private void rbCusco_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-13.4300616, -72.1473566);
            departamento = "Cusco";
        }

        private void rbHuancavelica_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-13.0812805, -74.8724792);
            departamento = "Huancavelica";
        }

        private void rbHuanuco_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-9.4241618, -75.8020598);
            departamento = "Huanuco";
        }

        private void rbIca_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-14.251204, -75.4905532);
            departamento = "Ica";
        }

        private void rbJunin_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-11.6467142, -74.7079383);
            departamento = "Junin";
        }

        private void rbLibertad_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-8.0166435, -78.0776204);
            departamento = "La Libertad";
        }

        private void rbLambayeque_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-6.482567, -79.7380485);
            departamento = "Lambayeque";
        }

        private void rbLima_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-11.8952056, -76.5663711);
            departamento = "Lima";
        }

        private void rbLoreto_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-4.7639491, -74.3329797);
            departamento = "Loreto";
        }

        private void rbMadredeDios_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-12.0262763, -70.3600778);
            departamento = "Madre de Dios";
        }

        private void rbMoquegua_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-17.0547869, -70.7111884);
            departamento = "Moquegua";
        }

        private void rbPasco_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-10.4898669, -75.2128951);
            departamento = "Pasco";
        }

        private void rbPiura_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-5.3532425, -80.1332288);
            departamento = "Piura";
        }

        private void rbPuno_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-15.4259035, -69.7628413);
            departamento = "Puno";
        }

        private void rbSanMartin_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-7.1974505, -76.4619251);
            departamento = "San Martin";
        }

        private void rbTacna_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-17.6744376, -70.2449522);
            departamento = "Tacna";
        }

        private void rbTumbes_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-3.8632287, -80.4977167);
            departamento = "Tumbes";
        }

        private void rbAyacucho_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-13.9060789, -73.9995389);
            departamento = "Ayacucho";
        }

        private void gMapView_Load(object sender, EventArgs e)
        {
            marcador = new GMarkerGoogle(new PointLatLng(-90, 0), GMarkerGoogleType.lightblue);
            markerOverlay = new GMapOverlay("Marcador");
            markerOverlay.Markers.Add(marcador);
            gMapView.Overlays.Add(markerOverlay);
            marcador.IsVisible = false;

            if (!double.IsNaN(latEdit) && !double.IsNaN(lngEdit))
            {
                marcador.Position = new PointLatLng(latEdit, lngEdit);
                marcador.IsVisible = true;
            }
        }

        private void btnBorrarLL_Click(object sender, EventArgs e)
        {
            marcador.IsVisible = false;
            txtLatitud.Text = "";
            txtLongitud.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime ult_evento = dtPickerEvento.Value;
            DateTime ult_audit = dtPickerAudit.Value;
            int cad_cantidad = (int)nudCadCantidad.Value;
            int cad_sindatos = (int)nudCadSindatos.Value;
            int maq_cantidad = (int)nudMaqCantidad.Value;
            int maq_sindatos = (int)nudMaqSindatos.Value;
            string latitud = txtLatitud.Text;
            string longitud = txtLongitud.Text;

            if (string.IsNullOrEmpty(latitud))
            {
                latitud = null;
            }

            if (string.IsNullOrEmpty(longitud))
            {
                longitud = null;
            }

            if (!string.IsNullOrEmpty(nombre) &&
                ult_evento != DateTime.MinValue &&
                ult_audit != DateTime.MinValue &&
                cad_cantidad >= 0 &&
                cad_sindatos >= 0 &&
                maq_cantidad >= 0 &&
                maq_sindatos >= 0 &&
                !string.IsNullOrEmpty(departamento))
            {
                locales local = new locales
                {
                    nombre = nombre,
                    ult_evento = ult_evento,
                    ult_audit = ult_audit,
                    cad_cantidad_sala = cad_cantidad,
                    cad_sindatos = cad_sindatos,
                    maq_cantidad_sala = maq_cantidad,
                    maq_sindatos = maq_sindatos,
                    departamento = departamento,
                    latitud = latitud,
                    longitud = longitud
                };
                classLocales.CrearLocal(local);
                frmlocales.OperacionExitosa();
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.", "Error");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime ult_evento = dtPickerEvento.Value;
            DateTime ult_audit = dtPickerAudit.Value;
            int cad_cantidad = (int)nudCadCantidad.Value;
            int cad_sindatos = (int)nudCadSindatos.Value;
            int maq_cantidad = (int)nudMaqCantidad.Value;
            int maq_sindatos = (int)nudMaqSindatos.Value;
            string latitud = txtLatitud.Text;
            string longitud = txtLongitud.Text;

            if (string.IsNullOrEmpty(latitud))
            {
                latitud = null;
            }

            if (string.IsNullOrEmpty(longitud))
            {
                longitud = null;
            }

            if (!string.IsNullOrEmpty(nombre) &&
                ult_evento != DateTime.MinValue &&
                ult_audit != DateTime.MinValue &&
                cad_cantidad >= 0 &&
                cad_sindatos >= 0 &&
                maq_cantidad >= 0 &&
                maq_sindatos >= 0 &&
                !string.IsNullOrEmpty(departamento))
            {
                locales local = new locales
                {
                    codigo = codigo,
                    nombre = nombre,
                    ult_evento = ult_evento,
                    ult_audit = ult_audit,
                    cad_cantidad_sala = cad_cantidad,
                    cad_sindatos = cad_sindatos,
                    maq_cantidad_sala = maq_cantidad,
                    maq_sindatos = maq_sindatos,
                    departamento = departamento,
                    latitud = latitud,
                    longitud = longitud
                };
                classLocales.ActualizarLocal(local);
                frmlocales.OperacionExitosa();
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.", "Error");
            }
        }
    }
}
