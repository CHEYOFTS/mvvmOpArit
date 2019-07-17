using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Verdugo.Model;
namespace Verdugo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultadoView : TabbedPage
    {
        public ResultadoView()
        {
            InitializeComponent();
        }
        public ResultadoView(Operacion datos)
        {
            InitializeComponent();
            BindingContext = datos;
        }
    }
}