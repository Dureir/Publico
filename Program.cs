using System;
using System.Collections;
using System.Linq;

namespace Proyecto_integrador
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se crean instancias del votante, la lista de votantes y el formulario.
            SortedList nombres = new SortedList();
            Votante v = new Votante();
            Formulario F = new Formulario();
            //Se declaran las variables para el numero de votantes, número de votos y la letra de cierre manual del programa.
            string cierre = " ";
            int padron = 0;
            int voto = 0;
            bool arreglo = true;
            while (cierre != "x") //El código principal se encierra en un while loop que ejecuta el código en un ciclo, hasta cumplir con una condición específica.
            {



                Console.WriteLine(" ..........Formulario de votación..........");
                Console.WriteLine("Información del votante:");


                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("Nombre completo:");
                v.Nombre = Console.ReadLine();

                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("Edad:");
                string edad = Console.ReadLine();//Variable edad que ingresa el usuario.

                if (!int.TryParse(edad, out v.Edad))//Esta linea de código nos convierte el string de edad ingresado por el usuario en un int que podemos utilizar.
                {
                }
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("Nacionalidad:");
                v.Nacionalidad = Console.ReadLine();


                string[] ValoresValidos = new string[] { "Mexicana", "mexicana", "Mexico", "mexico" };//Se definieron las formas en las que es válido escribir la nacionalidad.



                if (ValoresValidos.Contains(v.Nacionalidad) & v.Edad >= 18)//Se realiza una prueba de edad o nacionalidad.

                {
                    Console.Clear();//Estos comandos limpian la consola de texto para evitar una pantalla muy llena.
                    Console.WriteLine("..........Lista de candidatos..........");
                    Console.WriteLine("Juan #1");
                    Console.WriteLine("Pablo #2");
                    Console.WriteLine("Jesus #3");
                    Console.WriteLine("Paco #4");

                    Console.WriteLine("..Escriba el numero del candidato por el que quiere votar");

                    string strvoto = Console.ReadLine();
                    if (!int.TryParse(strvoto, out voto))//Se recive un valor string del usuario, que se convierte en int para poder ser utilizado.
                    {
                    }

                    if (v.Nombre != " ")
                    {
                        padron += 1;
                    }



                    Console.Clear();

                }

                else
                {
                    arreglo = false;

                    Console.Clear();
                    Console.WriteLine("No calificas para la votación debido a tu nacionalidad o por ser menor de edad");
                    Console.WriteLine("Escriba la letra (x) para concluir la votación, presione enter para que vote otra persona.");//El programa detiene su ejecución si el usuario no pasa las pruebas de edad o nacionalidad.
                    cierre = Console.ReadLine();
                    Console.Clear();
                }






                if (arreglo == true)
                {


                    //Se determina a quien se le dará el voto y se le informa al usuario, dependiendo el número ingresado.
                    if (voto == 1)
                    {
                        F.Juan = F.Juan + 1;
                        Console.WriteLine("Usted votó por Juan.");
                    }

                    else if (voto == 2)
                    {
                        F.Pablo = F.Pablo + 1;
                        Console.WriteLine("Usted votó por Pablo.");
                    }

                    else if (voto == 3)
                    {
                        F.Jesus = F.Jesus + 1;
                        Console.WriteLine("Usted votó por Jesus.");
                    }

                    else if (voto == 4)
                    {
                        F.Paco = F.Paco + 1;
                        Console.WriteLine("Usted votó por Paco.");
                    }

                                
                    //Si se ingresa cualquier cosa que no sean números enteros entre 1 y 4, se informa que no es válido y se da la opción de cerrar o reiniciar el proceso.  
                    else if (voto >= 5)
                    {
                        Console.WriteLine("Opción inválida, intente de nuevo.");
                                               
                    }
                   
                    Console.WriteLine("Escriba la letra (x) para concluir la votación, presione enter para que vote otra persona.");
                    cierre = Console.ReadLine();
                    Console.Clear();
                    
                }

                if (voto < 5 & arreglo == true)
                {
                    nombres.Add(v.Nombre, v.Edad);//Se agrega la información del votante a la lista.
                }
                //Se comprueba si se alcanzó el número de votantes del padrón y en caso de ser así, se cierra la votación de forma automática.
                if (padron == 10)
                {
                    cierre = "x";
                }


               


            }



            
               //Ya cerrada la votación, se muestran cuantos votos tiene cada candidato, se suman el número de votos totales y se muestra la lista de votantes y sus edades.
                F.votos = F.Juan + F.Pablo + F.Jesus + F.Paco;

                Console.WriteLine("El número de votos final para cada candidato es:");
                Console.WriteLine(F.Juan + " Juan, " + F.Pablo + " Pablo, " + F.Jesus + " Jesus, " + F.Paco + " Paco.");
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("Total de votos:" + F.votos);

                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("Nombre y edad de los votantes:");
                foreach (object clave in nombres.Keys)
                {

                    Console.WriteLine("{0} - {1}", clave.ToString(), nombres[clave].ToString());
                }
            














        }


    }
}
