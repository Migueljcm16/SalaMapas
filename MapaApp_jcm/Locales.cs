using MapaApp_jcm.Models;
using MapaApp_jcm.Repository.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MapaApp_jcm
{
    public partial class Locales : Form
    {
        private Principal frmPrincipal;
        LocalesRepository classLocales = new LocalesRepository();
        BindingList<locales> listaLocalesBinding;
        private bool isBtnMapaPrincipalClicked = false;

        public Locales(Principal frmPrincipal)
        {
            InitializeComponent();
            this.frmPrincipal = frmPrincipal;
            dataGVlocales.EnableHeadersVisualStyles = false;
        }

        private void Locales_Load(object sender, EventArgs e)
        {
            CargarListado();
            cboFiltro.SelectedIndex = 0;
            DataGridViewButtonColumn columnaEliminar = new DataGridViewButtonColumn
            {
                Name = "Eliminar",
                UseColumnTextForButtonValue = true
            };
            dataGVlocales.Columns.Add(columnaEliminar);

            DataGridViewButtonColumn columnaActualizar = new DataGridViewButtonColumn
            {
                Name = "Editar",
                UseColumnTextForButtonValue = true
            };
            dataGVlocales.Columns.Add(columnaActualizar);
        }

        private void CargarListado()
        {
            listaLocalesBinding = new BindingList<locales>(classLocales.ObtenerListado());
            dataGVlocales.DataSource = listaLocalesBinding;
        }

        public void OperacionExitosa()
        {
            CargarListado();
            cboFiltro.SelectedIndex = 0;
            frmPrincipal.rbDefecto.Checked = true;
            frmPrincipal.rbDefecto_CheckedChanged(frmPrincipal.rbDefecto, EventArgs.Empty);
        }

        private void cboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFiltro.SelectedIndex == 0)
            {
                listaLocalesBinding = new BindingList<locales>(listaLocalesBinding.OrderBy(l => l.codigo).ToList());
            }
            else if (cboFiltro.SelectedIndex == 1)
            {
                listaLocalesBinding = new BindingList<locales>(listaLocalesBinding.OrderBy(l => l.nombre).ToList());
            }
            else if (cboFiltro.SelectedIndex == 2)
            {
                listaLocalesBinding = new BindingList<locales>(listaLocalesBinding.OrderBy(l => l.departamento).ToList());
            }
            else if (cboFiltro.SelectedIndex == 3)
            {
                listaLocalesBinding = new BindingList<locales>(listaLocalesBinding.OrderBy(l => l.cad_cantidad_sala).ToList());
            }
            else if (cboFiltro.SelectedIndex == 4)
            {
                listaLocalesBinding = new BindingList<locales>(listaLocalesBinding.OrderBy(l => l.maq_cantidad_sala).ToList());
            }
            dataGVlocales.DataSource = listaLocalesBinding;
        }

        private void dataGVlocales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGVlocales.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este local?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    int codigo = (int)dataGVlocales.Rows[e.RowIndex].Cells["codigo"].Value;

                    classLocales.EliminarLocal(codigo);
                    OperacionExitosa();
                }
            }
            if (e.ColumnIndex == dataGVlocales.Columns["Editar"].Index && e.RowIndex >= 0)
            {
                int codigo = (int)dataGVlocales.Rows[e.RowIndex].Cells["codigo"].Value;
                String nombre = (string)dataGVlocales.Rows[e.RowIndex].Cells["nombre"].Value;
                DateTime evento = (DateTime)dataGVlocales.Rows[e.RowIndex].Cells["ult_evento"].Value;
                DateTime audit = (DateTime)dataGVlocales.Rows[e.RowIndex].Cells["ult_audit"].Value;
                int cad_cantidad = (int)dataGVlocales.Rows[e.RowIndex].Cells["cad_cantidad_sala"].Value;
                int cad_sindatos = (int)dataGVlocales.Rows[e.RowIndex].Cells["cad_sindatos"].Value;
                int maq_cantidad = (int)dataGVlocales.Rows[e.RowIndex].Cells["maq_cantidad_sala"].Value;
                int maq_sindatos = (int)dataGVlocales.Rows[e.RowIndex].Cells["maq_sindatos"].Value;
                String departamento = (string)dataGVlocales.Rows[e.RowIndex].Cells["departamento"].Value;
                String latitud = (string)dataGVlocales.Rows[e.RowIndex].Cells["latitud"].Value;
                String longitud = (string)dataGVlocales.Rows[e.RowIndex].Cells["longitud"].Value;

                Formulario frmFormulario = new Formulario(this, "EDITAR LOCAL", codigo, nombre, evento, audit, cad_cantidad, cad_sindatos, maq_cantidad, maq_sindatos, departamento, latitud, longitud);
                frmFormulario.ShowDialog();
            }
        }

        private void dataGVlocales_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGVlocales.Columns["Eliminar"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var icono = MapaApp.Properties.Resources.basura;
                int iconoAnchoDeseado = 16;

                int iconoAltoDeseado = (int)((double)icono.Height / icono.Width * iconoAnchoDeseado);

                int posX = e.CellBounds.Left + (e.CellBounds.Width - iconoAnchoDeseado) / 2;

                int posY = e.CellBounds.Top + (e.CellBounds.Height - iconoAltoDeseado) / 2;

                var iconoRect = new Rectangle(
                    posX,
                    posY,
                    iconoAnchoDeseado,
                    iconoAltoDeseado);

                e.Graphics.DrawImage(icono, iconoRect);
                e.Handled = true;
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGVlocales.Columns["Editar"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var icono = MapaApp.Properties.Resources.editar;
                int iconoAnchoDeseado = 16;

                int iconoAltoDeseado = (int)((double)icono.Height / icono.Width * iconoAnchoDeseado);

                int posX = e.CellBounds.Left + (e.CellBounds.Width - iconoAnchoDeseado) / 2;

                int posY = e.CellBounds.Top + (e.CellBounds.Height - iconoAltoDeseado) / 2;

                var iconoRect = new Rectangle(
                    posX,
                    posY,
                    iconoAnchoDeseado,
                    iconoAltoDeseado);

                e.Graphics.DrawImage(icono, iconoRect);
                e.Handled = true;
            }
        }

        private void btnMapaPrincipal_Click(object sender, EventArgs e)
        {
            isBtnMapaPrincipalClicked = true;
            this.Close();
            frmPrincipal.Show();
        }

        private void Locales_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !isBtnMapaPrincipalClicked)
            {
                Application.Exit();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Formulario frmFormulario = new Formulario(this, "AGREGAR LOCAL", null, null, null, null, null, null, null, null, null, null, null);
            frmFormulario.ShowDialog();
        }
    }
}
