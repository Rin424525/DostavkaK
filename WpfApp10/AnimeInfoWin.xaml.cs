using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp10
{
 
    public partial class AnimeInfoWin : Window, INotifyPropertyChanged
    {
        private Adres selectedAnimeInfo;

        public Adres SelectedAnimeInfo
        {
            get => selectedAnimeInfo;
            set
            {
                selectedAnimeInfo = value;
                Signal();
            }
        }
        public ObservableCollection<Adres> AnimeInfos
        {
            get => Data.AnimeInfos;
        }
        public ObservableCollection<Serianomer> Serias
        {
            get => Data.Serias;
        }
        public ObservableCollection<TipTovara> Seasons
        {
            get => Data.Seasons;
        }
        public AnimeInfoWin()
        {
            InitializeComponent();
            DataContext = this;
        }

        void Signal([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this,
                      new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void AddAnimeInfo(object sender, RoutedEventArgs e)
        {
            AnimeInfos.Add(new Adres { Title = "Новая страна производства" });
        }

        private void DeleteAnimeInfo(object sender, RoutedEventArgs e)
        {
            if (SelectedAnimeInfo == null)
                return;
            if (MessageBox.Show("Действительно удалить выбранную страну?",
                "Предупреждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                AnimeInfos.Remove(SelectedAnimeInfo);
            }
        }

    }
}
