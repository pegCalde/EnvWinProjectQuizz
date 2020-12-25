using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnvWinProjectQuizz.Droid
{
    class Matiere
    {
        List<Partie> listePartie;

        public Matiere(List<Partie> p_listePartie)
        {
            this.listePartie = p_listePartie;
        }
    }
}