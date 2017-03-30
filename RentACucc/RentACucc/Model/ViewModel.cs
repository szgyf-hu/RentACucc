﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACucc.Model
{
    class ViewModel
    {
        public ObservableCollection<Cucc> CuccLista { get; } =
            new ObservableCollection<Cucc>();
        public ObservableCollection<Juzer> JuzerLista { get; } =
            new ObservableCollection<Juzer>();
        public ObservableCollection<Kolcsonzes> KolcsonzesLista { get; } =
            new ObservableCollection<Kolcsonzes>();

        DB db = new DB();

        private ViewModel()
        {
            CuccLista = new ObservableCollection<Cucc>(db.getList<Cucc>());
            JuzerLista = new ObservableCollection<Juzer>(db.getList<Juzer>());
            KolcsonzesLista = new ObservableCollection<Kolcsonzes>(db.getList<Kolcsonzes>());
        }

        //Singleton minta
        //public static ViewModel egykePeldany { get; } = new ViewModel();

        private static ViewModel _EgykePeldany = new ViewModel();
        public static ViewModel getEgykePeldany()
        {
            return _EgykePeldany;
        }

        public void saveCucc(Cucc cucc)
        {
            db.
        }
    }
}