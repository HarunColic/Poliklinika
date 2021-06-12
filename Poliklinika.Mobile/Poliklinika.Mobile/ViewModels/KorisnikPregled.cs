﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Poliklinika.Mobile.ViewModels
{
    public class KorisnikPregled : BaseViewModel
    {
        private readonly APIService _pregled = new APIService("Pregled");
        private readonly APIService _odjel = new APIService("Odjel");
        public KorisnikPregled()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<PreglediVM> PreglediLista { get; set; } = new ObservableCollection<PreglediVM>();
        public ICommand InitCommand { get; }


        public async Task Init()
        {

            var list = await _pregled.Get<IEnumerable<PreglediVM>>(null);
            PreglediLista.Clear();

            foreach (var pregledi in list)
            {
                if (pregledi.KorisnikID == CurrentUser.User.Id)
                {
                    pregledi.odjel = await _odjel.GetById<Odjel>(pregledi.OdjelID);
                    PreglediLista.Add(pregledi);
                }
            }
        }
        public class PreglediVM
        {
            public int ID { get; set; }
            public int KorisnikID { get; set; }
            public DateTime Datum { get; set; }
            public int OdjelID { get; set; }
            public Odjel odjel { get; set; }

        }
        public class Odjel
        {
            public int ID { get; set; }
            public string Naziv { get; set; }
        }
    }
}
