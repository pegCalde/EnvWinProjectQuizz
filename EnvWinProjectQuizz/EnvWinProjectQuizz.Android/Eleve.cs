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
    class Eleve
    {
        String nom;
        int note;

        public Eleve(String p_nom, int p_note)
        {
            this.nom = p_nom;
            this.note = p_note;
        }

        public String toString()
        {
            return "L'élève " + this.nom + " à reçu la note de " + this.note;
        }
    }
}