using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PM02MVVM2P22.ViewModels
{
    public class AlumnosViewModels : BaseViewModels
    {
        private int _id;
        private string _nombres;
        private string _apellidos;
        private string _genero;
        private string _direccion;

        public int id
        {
            get { return this.id; }
            set { this.id = value; OnPropertyChanged(); }
            
        }


        public string nombres
        {
            get { return this.nombres; }
            set { this.nombres = value; OnPropertyChanged(); }
        }

        public string apellidos
        {
            get { return this.apellidos; }
            set { this.apellidos = value; OnPropertyChanged(); }
        }
        public string genero
        {
            get { return this.genero; }
            set { this.genero = value; OnPropertyChanged(); }
        }

        public string direccion
        {
            get { return this.direccion; }
            set { this.direccion = value; OnPropertyChanged(); }
        }

        public ICommand CleanCommand { get; set; }

        public ICommand AddCommand { get; set; }

        public ICommand UpdateCommand { get; set; }

        void limpiar()
        {
            id = 0;
            nombres = String.Empty;
            apellidos = String.Empty;
            genero = String.Empty;
            direccion = String.Empty;
        }

         void AddAlum()
        {

        }

        async Task UpdateAlum()
        {

        }

        public  AlumnosViewModels()
        {
            CleanCommand = new Command(() => limpiar());
            AddCommand = new Command(() => AddAlum());
            UpdateCommand = new Command(async () => await UpdateAlum());
        }
    }
}
