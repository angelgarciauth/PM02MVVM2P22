using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PM02MVVM2P22.ViewModels
{
    public class ListAlumnViewModels : BaseViewModels
    {
        private ObservableCollection<Models.Alumnos> _listaAlumnos;
        private Models.Alumnos _alumno;
        public ObservableCollection<Models.Alumnos> GetListAlumnos
        {

            get { return _listaAlumnos; }
            set { _listaAlumnos = value; OnPropertyChanged(); }
        }
        public Models.Alumnos GetAlumno
        {
            get { return _alumno; }
            set { _alumno = value; OnPropertyChanged(); }
        }

        //Comandos y Objetos

        public ICommand DetallesCommand { set; get; }

        public INavigation Navigation {set; get;}


        //Constructor de clase
        public ListAlumnViewModels(INavigation navigation)
        {
            Navigation = navigation;
            DetallesCommand = new Command<Type>(async (pageType) => await llenarDetalle(pageType));

            //ir a consultar una bd en sql o restApi para consumirlo

            GetListAlumnos = new ObservableCollection<Models.Alumnos>();
            GetListAlumnos.Add(new Models.Alumnos()
            {
                id = 1,
                nombres = "Angel",
                apellidos = "Garcia",
                direccion = "YORO",
                genero = "M"
            });
        }

        async Task llenarDetalle(Type pageType)
        {
            if (GetAlumno != null)
            {
                var pagina = (Page)Activator.CreateInstance(pageType);
                pagina.BindingContext = new AlumnosViewModels()
                {
                    id = GetAlumno.id,
                    nombres = GetAlumno.nombres,
                    apellidos = GetAlumno.apellidos,
                    genero = GetAlumno.genero,
                    direccion = GetAlumno.direccion
                };

                await Navigation.PushAsync(pagina);
            }
           
        }
    }
}
