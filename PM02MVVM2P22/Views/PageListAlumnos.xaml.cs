using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM02MVVM2P22.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListAlumnos : ContentPage
    {
        public PageListAlumnos()
        {
            InitializeComponent();
            BindingContext = new ViewModels.ListAlumnViewModels(Navigation);
        }
    }
}