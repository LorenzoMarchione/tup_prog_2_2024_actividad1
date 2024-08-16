using Ejercicio_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Cocinar : Form
    {
        public Cocinar()
        {
            InitializeComponent();
        }
        Cocina cocinaDeAna;
        private void bTcocina_Click(object sender, EventArgs e)
        {
            Alacena alacena = new Alacena();
            Amasador amasador = new Amasador();
            Cocinera cocineraACargo = new Cocinera("Ana");

            cocinaDeAna = new Cocina(alacena, amasador, cocineraACargo);
        }

        private void bTreponer_Click(object sender, EventArgs e)
        {
            Alacena a = cocinaDeAna.Alacena;
            a.ReponerHarina(50);
            a.ReponerFruta(50);
            cocinaDeAna.Cocinera.Reponer();
            lBconversacion.Items.Add("Misterio - Ana, reportate?");
            lBconversacion.Items.Add($"Ana - {cocinaDeAna.Cocinera.ContestarEnQueEtapaEsta()}");

        }

        private void bTcocinar_Click(object sender, EventArgs e)
        {
            Alacena a = cocinaDeAna.Alacena;
            double cantHarina = a.TomarHarina(5);
            double cantFruta = a.TomarFruta(5);
            Amasador am = cocinaDeAna.Amasador;
            double masaProducida = am.Amasar(cantHarina);

            Cocinera ana = cocinaDeAna.Cocinera;

            lBconversacion.Items.Add("Misterio - Ana, reportate?");
            lBconversacion.Items.Add($"Ana - {cocinaDeAna.Cocinera.ContestarEnQueEtapaEsta()}");

            ana.CortaLaMasa();
            lBconversacion.Items.Add("Misterio - Ana, reportate?");
            lBconversacion.Items.Add($"Ana - {cocinaDeAna.Cocinera.ContestarEnQueEtapaEsta()}");

            ana.FormaLaMasa();
            lBconversacion.Items.Add("Misterio - Ana, reportate?");
            lBconversacion.Items.Add($"Ana - {cocinaDeAna.Cocinera.ContestarEnQueEtapaEsta()}");

            ana.Hornea();
            lBconversacion.Items.Add("Misterio - Ana, reportate?");
            lBconversacion.Items.Add($"Ana - {cocinaDeAna.Cocinera.ContestarEnQueEtapaEsta()}");

        }
    }
}
