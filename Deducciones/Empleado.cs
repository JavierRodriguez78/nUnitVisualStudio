using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deducciones
{
    public class Empleado
    {
         public int Calcular (Boolean conyugue, int ingresos, int ingresos_conyugue, int hijos){

             int deduccion=0;

             if (conyugue == true && ingresos_conyugue<1500)
             {

                 if (hijos == 0)
                 {
                     deduccion= 13300;
                 }
                 else if (hijos == 1)
                 {
                     deduccion =  14700;
                 }
                 else if (hijos >= 2)
                 {
                     deduccion = 16900;
                 }




             } else if (conyugue == true && ingresos_conyugue> 1500)
             {
                 if (hijos == 0)
                 {
                     deduccion= 11100;
                 }
                 else if (hijos == 1)
                 {
                     deduccion =  11880;
                 }
                 else if (hijos >= 2)
                 {
                     deduccion = 12519;
                 }
             } else if (conyugue == false)
             {
                 if (hijos == 0)
                 {
                     deduccion = 0;
                 }
                 else if (hijos == 1)
                 {
                     deduccion = 13600;
                 }
                 else if (hijos >= 2)
                 {
                     deduccion = 15600;
                 }
             }


                 return deduccion;
        }
    }

   

}
