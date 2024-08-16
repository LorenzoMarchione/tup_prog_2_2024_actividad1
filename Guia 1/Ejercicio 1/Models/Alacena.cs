using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class Alacena
    {
        #region Propiedades
        public double Harina  { get; private set; }
        public double Fruta { get; private set; }
        

        #endregion
        #region Metodos
        public void ReponerHarina (double cant)
        {
            Harina += cant;
        }
        public void ReponerFruta (double cant)
        {
            Fruta +=  cant;
        }
        public double TomarHarina (double requerido)
        {
            if (requerido > Harina)
            {
                requerido = Harina;
                Harina = 0;
            }
            else
            {
                Harina -= requerido;
            }
            return requerido;
        }
        public double TomarFruta (double requerido)
        {
            if (requerido > Fruta)
            {
                requerido = Fruta;
                Fruta = 0;
            }
            else
            {
                Fruta -= requerido;
            }
            return requerido;
        }
        #endregion

    }
}
