using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTestOrdering.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectItems : ContentPage
    {
        public SelectItems()
        {
            InitializeComponent();
            BindingContext = ViewModels.ItemsVM.Current;
        }
    }
}