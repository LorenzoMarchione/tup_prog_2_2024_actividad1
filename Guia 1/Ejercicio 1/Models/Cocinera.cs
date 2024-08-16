using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class Cocinera
    {
        #region Atributos
        public string Nombre { get; private set; }
        string estadoTareas;
        #endregion
        #region Metodos
        public Cocinera (string nombre)
        {
            Nombre = nombre;
        }
        public void CortaLaMasa()
        {
            estadoTareas = "Cortando la masa";
        }
        public void FormaLaMasa()
        {
            estadoTareas = "Formando la masa";
        }
        public void Hornea()
        {
            estadoTareas = "Horneando";
        }
        public void Reponer()
        {
            estadoTareas = "Reponiendo";
        }
        public string ContestarEnQueEtapaEsta()
        {
            return estadoTareas;
        }
        #endregion
    }
}
