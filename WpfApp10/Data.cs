using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WpfApp10
{
    
    static class Data
    {
        public static ObservableCollection<Serianomer> Serias = new ObservableCollection<Serianomer>();
        public static ObservableCollection<VremaDostavki> Osnovaanimes = new ObservableCollection<VremaDostavki>();
        public static ObservableCollection<Adres> AnimeInfos = new ObservableCollection<Adres>();
        public static ObservableCollection<TipTovara> Seasons = new ObservableCollection<TipTovara>();
    }
}
