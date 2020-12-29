using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EnvWinProjectQuizz.Model
{
    class TestDropdownViewModel
    {
        public IList<TestDropdown> CityList { get; set; }

        public TestDropdownViewModel()
        {
            try
            {
                CityList = new ObservableCollection<TestDropdown>();

                CityList.Add(new TestDropdown
                {
                    IdCity = 1,
                    NameCity = "Illidan"
                });
                CityList.Add(new TestDropdown
                {
                    IdCity = 2,
                    NameCity = "Jaina"
                });
                CityList.Add(new TestDropdown
                {
                    IdCity = 3,
                    NameCity = "Anduin"
                });
                CityList.Add(new TestDropdown
                {
                    IdCity = 4,
                    NameCity = "Varian"
                });
                CityList.Add(new TestDropdown
                {
                    IdCity = 5,
                    NameCity = "Thrall"
                });
            }
            catch (Exception e)
            {

            }

        }
    }
}
