using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EnvWinProjectQuizz.ViewModel
{
    class EleveViewModel
    {
        public IList<Eleve> EleveList { get; set; }

        public EleveViewModel()
        {
            EleveList = new ObservableCollection<Eleve>();

            EleveList.Add(new Eleve
            {
                Name = "Illidan"
            });
            EleveList.Add(new Eleve
            {
                Name = "Jaina"
            });
            EleveList.Add(new Eleve
            {
                Name = "Anduin"
            });
            EleveList.Add(new Eleve
            {
                Name = "Varian"
            });
            EleveList.Add(new Eleve
            {
                Name = "Thrall"
            });
        }
    }
}
