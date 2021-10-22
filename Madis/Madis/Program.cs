using System; 

namespace Madis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Conjunción, Disyunción, Negación y Condicional y Bicondicional*/

            //variables
            int nElementos, conteo = 0, resultado = 0;
            int salir = 0;

            //esta variables se utilizo para la negacion para obtener valores contrarios
            bool comprobacion;

            Console.WriteLine("Dijite cuantas calificaciones desea ingresar");
            nElementos = int.Parse(Console.In.ReadLine());

            /*conjuncion*/
            //conjuncion porque su elementos = 0 no se cumple, se debe cumplir una
            //para que se cumpla el array y asi las dos sean verdadero = 1.
            int[] calificaciones = new int[nElementos];

            for(int i = 0; i < nElementos; i++)
            {
                Console.WriteLine((i + 1)+ "Dijite las calificaciones");
                calificaciones[i] = int.Parse(Console.In.ReadLine());

                conteo += calificaciones[i];
                //Conjuncion
                //si esta propocicion no cumple no pasa al siguiente proceso
                 resultado = conteo / calificaciones[i];
               
            }
            do
            {

                /*Disyuncion*/
                //si cualquiera de ellas se cumple se vuelve verdadera.
                switch (resultado)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:Console.WriteLine("La calificacion no es aporvatoria: " + resultado + " ");
                        break;

                    case 7:
                    case 8:Console.WriteLine("La calificacion es aprobatoria: " + resultado + " ");
                        break;

                    case 9:
                    case 10:Console.WriteLine("Calificacion con aprovechamiento: " + resultado + " ");
                        break;

                    /*Disyuncion*/ 
                    //donde todos los casos son (F) ya que si no se cumple no puede procesar la informacion
                    default:
                    Console.WriteLine("Lo sentimos no podemos procesar la informacion");
                    break;

                }
                /*Bicondicional*/
                //si en switch no se cumple no entra a esta condicion
                if (resultado >= 9 && resultado <= 10)
                {
                    Console.WriteLine("El alumno obtiene el primer lugar de aprovechamiento: " + resultado + " ");
                }
                else if (resultado >= 7 && resultado <= 8)
                {
                    Console.WriteLine("El alumno necesita asesorias: " + resultado + " ");
                }
                else if (resultado >= 1 && resultado <= 6)
                {
                    Console.WriteLine("Lo sentimos el alumno va a segunda oportunidad: " + resultado + " ");
                }

                 /*Negacion*/
                 //porque es negacion, si al comprobar los valores son iguales sera true pero si son diferentes dara false 
                 //con el operador ! direfente esto nos ayuda con errores logicos
                comprobacion = resultado == conteo || !(resultado == conteo);

                Console.WriteLine("Comprobacion de valores = " + comprobacion + "");

                /*Condicional*/
                // de comprobacion ya que si los valores los detecta falsos hay que llamar al programador ya que tiene errore
                if (comprobacion == true)
                {
                    Console.WriteLine("El orden es correcto ");
                }
                else
                {
                    Console.WriteLine("LLamar al programador");
                }
               
                Console.WriteLine("Si desea salir dijite (0) para cotinuar dijite (1)");
                salir = int.Parse(Console.In.ReadLine());

                Console.Out.WriteLine("Cerrando el programa enter para salir:");
                Console.In.ReadLine();

            } while (salir != 0); 
        }
    }
}
