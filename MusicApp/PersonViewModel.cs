using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp
{
   public class PersonViewModel
    {
        public List<Personal> Personals { get; set; }
        public List<Personal_2> Personal_2s { get; set; }
        public PersonViewModel()
        {
            Personals = new PersonalService().GetPersonals();
            Personal_2s = new PersonalService().GetPersonal_2s();
        }
    }
}
