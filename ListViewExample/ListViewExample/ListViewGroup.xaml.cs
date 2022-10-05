using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        private List<FutbolistaList> _listOfFutbolistas;
        public List<FutbolistaList> ListOfFutbolistas { get { return _listOfFutbolistas; } set { _listOfFutbolistas = value; base.OnPropertyChanged(); } }
        public ListViewGroup()
        {
            InitializeComponent();
        }
                protected override void OnAppearing()
            {
                base.OnAppearing();

                var dList = new FutbolistaList()
                {
                    new Futbolista() {FirstName = "Cristiano", LastName = "dos Santos", Dorsal = 7},
                    new Futbolista() {FirstName = "Angel", LastName = "Dimaria", Dorsal = 11},
                    new Futbolista() {FirstName = "Rodrigo", LastName = "De Paul", Dorsal = 8},
                };
                dList.Heading = "D";


                var rList = new FutbolistaList()
                {
                    new Futbolista() {FirstName = "Sergio", LastName = "Ramos", Dorsal = 4},
                };
                rList.Heading = "R";


                var gList = new FutbolistaList()
                {
                    new Futbolista() {FirstName = "Paolo", LastName = "Guerrero", Dorsal = 9},
                };
                gList.Heading = "G";


                var mList = new FutbolistaList()
                {
                    new Futbolista() {FirstName = "Lionel", LastName = "Messi", Dorsal = 10},
                    new Futbolista() {FirstName = "Kilian", LastName = "Mbappe", Dorsal = 7},
                    new Futbolista() {FirstName = "Lautaro", LastName = "Martinez", Dorsal = 9},
                };
                mList.Heading = "M";

                var list = new List<FutbolistaList>()
                {
                    dList,
                    rList,
                    gList,
                    mList,
                };

                ListOfFutbolistas = list;

            }
    }
    
}