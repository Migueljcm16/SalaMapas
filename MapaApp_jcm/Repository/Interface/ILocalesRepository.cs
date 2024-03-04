using MapaApp_jcm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaApp_jcm.Repository.Interface
{
    internal interface ILocalesRepository
    {
        List<locales> ObtenerListado();
        List<locales> ObtenerListadoPorDepartamento(String departamento);
        void CrearLocal(locales nuevoLocal);
        void ActualizarLocal(locales localActualizado);
        void EliminarLocal(int codigo);
    }
}
