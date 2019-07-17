using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verdugo.Model;
using Verdugo.ModelView;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Verdugo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaPrincipal : ContentPage
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void Calcular_Clicked(object sender, EventArgs e)
        {

            //realizamos un objeto para la clase Operacion que hemos creado en Models..
            Operacion op = new Operacion();
            op.Numero1 = Convert.ToDouble(num1.Text);
            op.Numero2 = Convert.ToDouble(num2.Text);
            op.Numero3 = Convert.ToDouble(num3.Text);

            //aqui creamos un objeto de la clase donde tenemos las operaciones matematicas...
            RealizarOperaciones ObjRealizarOp = new RealizarOperaciones();
            op.TotalSuma = ObjRealizarOp.suma(op.Numero1, op.Numero2, op.Numero3);
            op.TotalResta = ObjRealizarOp.resta(op.Numero1, op.Numero2, op.Numero3);
            op.TotalMultiplicacion = ObjRealizarOp.Multiplicacion(op.Numero1, op.Numero2, op.Numero3);
            op.TotalDivision = ObjRealizarOp.Division(op.Numero1, op.Numero2, op.Numero3);

            
             
            //CREAMOS UN OBJETO de la pagina a la que vamos a ir
            ResultadoView pagina = new ResultadoView();

            //binding context propiedad que permite acceder a los datos del objeto que le pasamos..
            //en este caso es op, el objeto
            pagina.BindingContext = op;

            //con navigation redirigimos a la nueva pagina...
            Navigation.PushAsync(pagina);


//            Navigation.PushAsync(new ResultadoView(op));


              

                
        }
    }
}