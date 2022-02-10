using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTestOrdering.Views.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MonkeyListTemplate : Frame
    {
        public MonkeyListTemplate()
        {
            InitializeComponent();
        }
    }
}