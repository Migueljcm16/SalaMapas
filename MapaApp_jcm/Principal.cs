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
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using MapaApp_jcm.Models;
using MapaApp_jcm.Repository.Controller;
using GMap.NET.WindowsForms.ToolTips;

namespace MapaApp_jcm
{
    public partial class Principal : Form
    {
        double latInicial = -9.635995;
        double lngInicial = -75.7260814;
        LocalesRepository classLocales = new LocalesRepository();

        Dictionary<string, PointLatLng> coordenadasCapitales = new Dictionary<string, PointLatLng>
        {
            { "Amazonas", new PointLatLng(-5.290594290117586, -78.1011514004033) },
            { "Ancash", new PointLatLng(-9.377636478569583, -77.75015710444285) },
            { "Apurimac", new PointLatLng(-14.115051068843014, -73.0606393656158) },
            { "Arequipa", new PointLatLng(-16.409317822342075, -71.54090103371566) },
            { "Ayacucho", new PointLatLng(-13.164546546074046, -74.22466505058728) },
            { "Cajamarca", new PointLatLng(-6.355778272388235, -78.85956562876913) },
            { "Cusco", new PointLatLng(-13.381970288433727, -72.11439783866757) },
            { "Huancavelica", new PointLatLng(-12.78572835383093, -74.97915780333392) },
            { "Huanuco", new PointLatLng(-9.463213584786596, -76.2611393139877) },
            { "Ica", new PointLatLng(-14.076424521289868, -75.7338083690303) },
            { "Junin", new PointLatLng(-11.15856873127376, -75.99247652974026) },
            { "La Libertad", new PointLatLng(-7.867030395657853, -78.54453936778962) },
            { "Lambayeque", new PointLatLng(-6.66537791459839, -79.89735034824902) },
            { "Lima", new PointLatLng(-12.050620434880484, -77.0345580389218) },
            { "Loreto", new PointLatLng(-3.635414198631669, -73.30026507765757) },
            { "Madre de Dios", new PointLatLng(-11.87042596483807, -70.96432596453815) },
            { "Moquegua", new PointLatLng(-17.15716502793962, -70.9089424146016) },
            { "Pasco", new PointLatLng(-10.605974243570882, -76.27307580520352) },
            { "Piura", new PointLatLng(-5.178036022896842, -80.65719875905201) },
            { "Puno", new PointLatLng(-15.839182629808073, -70.02221018811515) },
            { "San Martin", new PointLatLng(-7.087981941665868, -76.69105082724839) },
            { "Tacna", new PointLatLng(-17.95423063892079, -70.23396598822157) },
            { "Tumbes", new PointLatLng(-3.713867098646401, -80.46201121054963) },
            { "Ucayali", new PointLatLng(-9.681298754185137, -73.720836837303) },
        };

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            gMapView.DragButton = MouseButtons.Left;
            gMapView.CanDragMap = true;
            gMapView.MapProvider = GMapProviders.GoogleMap;
            gMapView.Position = new PointLatLng(latInicial, lngInicial);
            gMapView.MinZoom = 5;
            gMapView.MaxZoom = 5;
            gMapView.Zoom = 5;
            gMapView.ShowCenter = false;
            gMapView.AutoScroll = true;
        } 

        private void gMapView_Load(object sender, EventArgs e)
        {
            CargarMarcadoresMapaDefecto();
            ObtenerTotalFilas();
            CalcularMaqTotales();

            dataGVlocales.EnableHeadersVisualStyles = false;
        }

        private void CargarMarcadoresMapaDefecto()
        {
            try
            {
                List<locales> listaLocales = classLocales.ObtenerListado();
                dataGVlocales.DataSource = listaLocales;

                Dictionary<string, List<string>> localesPorDepartamento = new Dictionary<string, List<string>>();

                foreach (locales local in listaLocales)
                {
                    if (!localesPorDepartamento.ContainsKey(local.departamento))
                    {
                        localesPorDepartamento[local.departamento] = new List<string>();
                    }
                    localesPorDepartamento[local.departamento].Add(local.nombre + ": " + local.maq_sindatos + "/" + local.maq_cantidad_sala);
                }

                GMapOverlay marcadoresDepartamentosOverlay = new GMapOverlay("MarcadoresDepartamentos");

                List<PointLatLng> posicionesMarcadores = new List<PointLatLng>();

                foreach (var departamento in localesPorDepartamento.Keys)
                {
                    int totalMaqSinDatos = 0;

                    if (!coordenadasCapitales.ContainsKey(departamento))
                    {
                        continue;
                    }

                    foreach (locales local in listaLocales)
                    {
                        if (local.departamento == departamento)
                        {
                            totalMaqSinDatos += local.maq_sindatos;
                        }
                    }

                    PointLatLng puntoDepartamento = coordenadasCapitales[departamento];
                    posicionesMarcadores.Add(puntoDepartamento);
                    GMarkerGoogle marcadorDepartamento = new GMarkerGoogle(puntoDepartamento, totalMaqSinDatos <= 5 ? GMarkerGoogleType.green_pushpin : totalMaqSinDatos <= 10 ? GMarkerGoogleType.yellow_pushpin : GMarkerGoogleType.red_pushpin);

                    List<string> nombresLocales = localesPorDepartamento[departamento];
                    string toolTipText = "\n" + departamento + "\n" + string.Join("\n", nombresLocales);
                    marcadorDepartamento.ToolTipText = toolTipText;
                    marcadoresDepartamentosOverlay.Markers.Add(marcadorDepartamento);
                }

                gMapView.Overlays.Add(marcadoresDepartamentosOverlay);

                if (posicionesMarcadores.Count > 0)
                {
                    double promedioLatitud = posicionesMarcadores.Average(p => p.Lat);
                    double promedioLongitud = posicionesMarcadores.Average(p => p.Lng);
                    gMapView.Position = new PointLatLng(promedioLatitud, promedioLongitud);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los marcadores: " + ex.Message, "Error");
            }
        }

        private void CargarMarcadoresPorDepartamento(string departamento)
        {
            EliminarMarcadores();

            List<locales> localesDepartamento = classLocales.ObtenerListadoPorDepartamento(departamento);
            dataGVlocales.DataSource = localesDepartamento;

            GMapOverlay marcadoresOverlay = new GMapOverlay("Marcadores");

            List<PointLatLng> posicionesMarcadores = new List<PointLatLng>();

            foreach (locales local in localesDepartamento)
            {
                if (local.latitud != null && local.longitud != null)
                {
                    PointLatLng puntoLocal = new PointLatLng(Convert.ToDouble(local.latitud), Convert.ToDouble(local.longitud));
                    posicionesMarcadores.Add(puntoLocal);
                    GMarkerGoogle marcadorDepartamento = new GMarkerGoogle(puntoLocal, local.maq_sindatos <= 5 ? GMarkerGoogleType.green_pushpin : local.maq_sindatos <= 10 ? GMarkerGoogleType.yellow_pushpin : GMarkerGoogleType.red_pushpin);
                    marcadorDepartamento.ToolTipText = "\n" + local.nombre + "\nMaq. Cantidad: " + local.maq_cantidad_sala + "\nMaq. sin Datos: " + local.maq_sindatos + "\nLatitud: " + local.latitud + "\nLongitud: " + local.longitud;
                    marcadoresOverlay.Markers.Add(marcadorDepartamento);
                }
            }

            gMapView.Overlays.Add(marcadoresOverlay);

            if (posicionesMarcadores.Count > 0)
            {
                double promedioLatitud = posicionesMarcadores.Average(p => p.Lat);
                double promedioLongitud = posicionesMarcadores.Average(p => p.Lng);
                gMapView.Position = new PointLatLng(promedioLatitud, promedioLongitud);
            }
        }

        private void EliminarMarcadores()
        {
            gMapView.Overlays.Clear();
        }

        private void ObtenerTotalFilas()
        {
            try
            {
                List<locales> listaLocales = classLocales.ObtenerListado();

                txtLocalesTotal.Text = listaLocales.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el número total de filas: " + ex.Message, "Error");
            }
        }

        private void ObtenerTotalFilasDepartamento(string departamento)
        {
            try
            {
                List<locales> listaLocales = classLocales.ObtenerListado();

                int totalFilasDepartamento = listaLocales.Count(local => local.departamento == departamento);

                txtLocalesTotal.Text = totalFilasDepartamento.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el número total de filas para el departamento: " + ex.Message, "Error");
            }
        }

        private void CalcularMaqTotales()
        {
            int totalMaq = 0;
            int totalMaqSinDatos = 0;

            try
            {
                List<locales> listaLocales = classLocales.ObtenerListado();

                foreach (locales local in listaLocales)
                {
                    totalMaq += local.maq_cantidad_sala;
                    totalMaqSinDatos += local.maq_sindatos;
                }

                txtMaqTotal.Text = totalMaq.ToString();
                txtMaqSinDatos.Text = totalMaqSinDatos.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular la suma de las maquinas: " + ex.Message, "Error");
            }
        }

        private void CalcularMaqTotalesDepartamento(String departamento)
        {
            int totalMaq = 0;
            int totalMaqSinDatos = 0;

            try
            {
                List<locales> listaLocales = classLocales.ObtenerListado();

                foreach (locales local in listaLocales)
                {
                    if (local.departamento == departamento)
                    {
                        totalMaq += local.maq_cantidad_sala;
                        totalMaqSinDatos += local.maq_sindatos;
                    }
                }

                txtMaqTotal.Text = totalMaq.ToString();
                txtMaqSinDatos.Text = totalMaqSinDatos.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular la suma de las maquinas por departamento: " + ex.Message, "Error");
            }
        }

        private void CargarUbicacionMP(double lat, double lng)
        {
            gMapView.Position = new PointLatLng(lat, lng);
            gMapView.CanDragMap = true;
            gMapView.MinZoom = 7;
            gMapView.MaxZoom = 16;
            gMapView.Zoom = 7;
        }

        public void rbDefecto_CheckedChanged(object sender, EventArgs e)
        {
            gMapView.Position = new PointLatLng(latInicial, lngInicial);
            gMapView.MinZoom = 5;
            gMapView.MaxZoom = 5;
            gMapView.Zoom = 5;

            EliminarMarcadores();
            CargarMarcadoresMapaDefecto();
            ObtenerTotalFilas();
            CalcularMaqTotales();
        }

        private void rbAmazonas_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-5.0435887, -77.8897181);
            CargarMarcadoresPorDepartamento("Amazonas");
            ObtenerTotalFilasDepartamento("Amazonas");
            CalcularMaqTotalesDepartamento("Amazonas");
        }

        private void rbAncash_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-9.4182822, -77.579869);
            CargarMarcadoresPorDepartamento("Ancash");
            ObtenerTotalFilasDepartamento("Ancash");
            CalcularMaqTotalesDepartamento("Ancash");
        }

        private void rbApurimac_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-14.1336959, -72.8299265);
            CargarMarcadoresPorDepartamento("Apurimac");
            ObtenerTotalFilasDepartamento("Apurimac");
            CalcularMaqTotalesDepartamento("Apurimac");
        }

        private void rbArequipa_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-16.4203011, -71.4617556);
            CargarMarcadoresPorDepartamento("Arequipa");
            ObtenerTotalFilasDepartamento("Arequipa");
            CalcularMaqTotalesDepartamento("Arequipa");
        }

        private void rbAyacucho_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-13.9060789, -73.9995389);
            CargarMarcadoresPorDepartamento("Ayacucho");
            ObtenerTotalFilasDepartamento("Ayacucho");
            CalcularMaqTotalesDepartamento("Ayacucho");
        }

        private void rbCajamarca_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-6.2438484, -78.5189894);
            CargarMarcadoresPorDepartamento("Cajamarca");
            ObtenerTotalFilasDepartamento("Cajamarca");
            CalcularMaqTotalesDepartamento("Cajamarca");
        }

        private void rbCusco_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-13.4300616, -72.1473566);
            CargarMarcadoresPorDepartamento("Cusco");
            ObtenerTotalFilasDepartamento("Cusco");
            CalcularMaqTotalesDepartamento("Cusco");
        }

        private void rbHuancavelica_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-13.0812805, -74.8724792);
            CargarMarcadoresPorDepartamento("Huancavelica");
            ObtenerTotalFilasDepartamento("Huancavelica");
            CalcularMaqTotalesDepartamento("Huancavelica");
        }

        private void rbHuanuco_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-9.4241618, -75.8020598);
            CargarMarcadoresPorDepartamento("Huanuco");
            ObtenerTotalFilasDepartamento("Huanuco");
            CalcularMaqTotalesDepartamento("Huanuco");
        }

        private void rbIca_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-14.251204, -75.4905532);
            CargarMarcadoresPorDepartamento("Ica");
            ObtenerTotalFilasDepartamento("Ica");
            CalcularMaqTotalesDepartamento("Ica");
        }

        private void rbJunin_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-11.6467142, -74.7079383);
            CargarMarcadoresPorDepartamento("Junin");
            ObtenerTotalFilasDepartamento("Junin");
            CalcularMaqTotalesDepartamento("Junin");
        }

        private void rbLibertad_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-8.0166435, -78.0776204);
            CargarMarcadoresPorDepartamento("Libertad");
            ObtenerTotalFilasDepartamento("Libertad");
            CalcularMaqTotalesDepartamento("Libertad");
        }

        private void rbLambayeque_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-6.482567, -79.7380485);
            CargarMarcadoresPorDepartamento("Lambayeque");
            ObtenerTotalFilasDepartamento("Lambayeque");
            CalcularMaqTotalesDepartamento("Lambayeque");
        }

        private void rbLima_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-11.8952056, -76.5663711);
            CargarMarcadoresPorDepartamento("Lima");
            ObtenerTotalFilasDepartamento("Lima");
            CalcularMaqTotalesDepartamento("Lima");
        }

        private void rbLoreto_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-4.7639491, -74.3329797);
            CargarMarcadoresPorDepartamento("Loreto");
            ObtenerTotalFilasDepartamento("Loreto");
            CalcularMaqTotalesDepartamento("Loreto");
        }

        private void rbMadredeDios_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-12.0262763, -70.3600778);
            CargarMarcadoresPorDepartamento("Madre de Dios");
            ObtenerTotalFilasDepartamento("Madre de Dios");
            CalcularMaqTotalesDepartamento("Madre de Dios");
        }

        private void rbMoquegua_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-17.0547869, -70.7111884);
            CargarMarcadoresPorDepartamento("Moquegua");
            ObtenerTotalFilasDepartamento("Moquegua");
            CalcularMaqTotalesDepartamento("Moquegua");
        }

        private void rbPasco_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-10.4898669, -75.2128951);
            CargarMarcadoresPorDepartamento("Pasco");
            ObtenerTotalFilasDepartamento("Pasco");
            CalcularMaqTotalesDepartamento("Pasco");
        }

        private void rbPiura_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-5.3532425, -80.1332288);
            CargarMarcadoresPorDepartamento("Piura");
            ObtenerTotalFilasDepartamento("Piura");
            CalcularMaqTotalesDepartamento("Piura");
        }

        private void rbPuno_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-15.4259035, -69.7628413);
            CargarMarcadoresPorDepartamento("Puno");
            ObtenerTotalFilasDepartamento("Puno");
            CalcularMaqTotalesDepartamento("Puno");
        }

        private void rbSanMartin_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-7.1974505, -76.4619251);
            CargarMarcadoresPorDepartamento("San Martin");
            ObtenerTotalFilasDepartamento("San Martin");
            CalcularMaqTotalesDepartamento("San Martin");
        }

        private void rbTacna_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-17.6744376, -70.2449522);
            CargarMarcadoresPorDepartamento("Tacna");
            ObtenerTotalFilasDepartamento("Tacna");
            CalcularMaqTotalesDepartamento("Tacna");
        }

        private void rbTumbes_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-3.8632287, -80.4977167);
            CargarMarcadoresPorDepartamento("Tumbes");
            ObtenerTotalFilasDepartamento("Tumbes");
            CalcularMaqTotalesDepartamento("Tumbes");
        }

        private void rbUcayali_CheckedChanged(object sender, EventArgs e)
        {
            CargarUbicacionMP(-9.6217292, -73.3473017);
            CargarMarcadoresPorDepartamento("Ucayali");
            ObtenerTotalFilasDepartamento("Ucayali");
            CalcularMaqTotalesDepartamento("Ucayali");
        }

        private void btnVerLista_Click(object sender, EventArgs e)
        {
            this.Hide();
            Locales frmLocales = new Locales(this);
            frmLocales.Show();
        }

        private void dataGVlocales_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGVlocales.CurrentCell != null)
            {
                dataGVlocales.CurrentCell.Selected = false;
            }
        }
    }
}
