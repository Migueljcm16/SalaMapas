using MapaApp_jcm.Models;
using MapaApp_jcm.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaApp_jcm.Repository.Controller
{
    internal class LocalesRepository : ILocalesRepository
    {
        public List<locales> ObtenerListado()
        {
            using (var contexto = new Models.Context())
            {
                try
                {
                    return contexto.locales.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener listado: " + ex.Message, "Error");
                    return new List<locales>();
                }
            }
        }

        public List<locales> ObtenerListadoPorDepartamento(string departamento)
        {
            using (var contexto = new Models.Context())
            {
                try
                {
                    return contexto.locales.Where(local => local.departamento == departamento).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener listado por departamento: " + ex.Message, "Error");
                    return new List<locales>();
                }
            }
        }

        public void CrearLocal(locales nuevoLocal)
        {
            try
            {
                using (var contexto = new Models.Context())
                {
                    contexto.locales.Add(nuevoLocal);
                    contexto.SaveChanges();
                    MessageBox.Show("Local creado con éxito", "Éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear local: " + ex.Message, "Error");
            }
        }

        public void ActualizarLocal(locales localActualizado)
        {
            try
            {
                using (var contexto = new Models.Context())
                {

                    var localEnBD = contexto.locales.Find(localActualizado.codigo);

                    if (localEnBD != null)
                    {
                        localEnBD.nombre = localActualizado.nombre;
                        localEnBD.ult_evento = localActualizado.ult_evento;
                        localEnBD.ult_audit = localActualizado.ult_audit;
                        localEnBD.cad_cantidad_sala = localActualizado.cad_cantidad_sala;
                        localEnBD.cad_sindatos = localActualizado.cad_sindatos;
                        localEnBD.maq_cantidad_sala = localActualizado.maq_cantidad_sala;
                        localEnBD.maq_sindatos = localActualizado.maq_sindatos;
                        localEnBD.departamento = localActualizado.departamento;
                        localEnBD.latitud = localActualizado.latitud;
                        localEnBD.longitud = localActualizado.longitud;

                        contexto.SaveChanges();
                        MessageBox.Show("Local actualizado con éxito", "Éxito");
                    }
                    else
                    {
                        MessageBox.Show("Local no encontrado", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar local: " + ex.Message, "Error");
            }
        }

        public void EliminarLocal(int codigo)
        {
            try
            {
                using (var contexto = new Models.Context())
                {
                    var localEncontrado = contexto.locales.Find(codigo);

                    if (localEncontrado != null)
                    {
                        contexto.locales.Remove(localEncontrado);
                        contexto.SaveChanges();
                        MessageBox.Show("Local eliminado con éxito", "Éxito");
                    }
                    else
                    {
                        MessageBox.Show("Local no encontrado", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar local: " + ex.Message, "Error");
            }
        }
    }
}
