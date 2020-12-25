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
    class Question
    {
        String enonce;
        List<Reponse> reponsesPossibles;
        List<int> correction;

        public Question(String p_enonce, List<Reponse> p_reponsesPossibles, List<int> p_correction)
        {
            this.enonce = p_enonce;
            this.reponsesPossibles = p_reponsesPossibles;
            this.correction = correction;
        }
    }
}