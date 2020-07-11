using System;

namespace Hola_mundo
{
   class Program
    {
        static void Main(string[] args)
        {
            
            /*  INGRESO Y CONVERCION DE DATOS INGRESADOS POR TECLADO.Parse
                -----------------------------------------------------
            
            PRUEBA:
            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola "+nombre);           
            Console.WriteLine("A continuacion, ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Por ultimo,ingrese su altura:");
            double altura = double.Parse(Console.ReadLine());
            
            EJERCICIO:            
            Console.WriteLine("PROMEDIO DE TRES EMPLEADOS");
            Console.WriteLine("Ingrese el nombre del primer empleado:");
            string nombre1 = Console.ReadLine();
            Console.WriteLine("A continuación,ingrese su salario:");
            double salario1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del segundo empleado:");
            string nombre2 = Console.ReadLine();
            Console.WriteLine("A continuación,ingrese su salario: ");
            double salario2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del tercer empleado:");
            string nombre3 = Console.ReadLine();
            Console.WriteLine("A continuación, ingrese su salario:");
            double salario3 = double.Parse(Console.ReadLine());

            double promedio = (salario1 + salario2 + salario3)/3;
            Console.WriteLine("El promedio salarial de los trabajadores es: "+promedio);
            */
             

             /* ESTRUCTURAS DE CONTROL "IF/ELSE"
                -------------------------------

            PRUEBA:
            Console.WriteLine("Ingrese su Nombre");
            string nombre =Console.ReadLine();
            Console.WriteLine("Ingrese su edad:");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Usted es mayor de edad.");
            }
            else
            {
                Console.WriteLine("Acceso denegado.");
            }
            
            EJERCICIO:
            Console.WriteLine("Ingrese el primer número entero:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número entero:");
            int n2 = int.Parse(Console.ReadLine());

            if(n1<n2)
            {
                Console.WriteLine("El número mayor es: "+ n2);
            }
            else{
                Console.WriteLine("El número mayor es: "+n1);
            }
            */


            /*  SENTENCIA SWITCH
                ----------------
            PRUEBA:
            Console.WriteLine("Ingrese un número del 1 al 7:");
            int num = int.Parse(Console.ReadLine());
            
            switch(num)
            {
                case 1:{Console.WriteLine("El número corresponde al día Lunes.");break;}
                case 2:{Console.WriteLine("El número corresponde al día Martes.");break;}
                case 3:{Console.WriteLine("El número corresponde al día Miercoles");break;}
                case 4:{Console.WriteLine("El número corresponde al día Jueves");break;}
                case 5:{Console.WriteLine("El número corresponde al día Viernes");break;}
                case 6:{Console.WriteLine("El número corresponde al día Sabado");break;}
                case 7:{Console.WriteLine("El número corresponde al día Domingo");break;}
            }
            */

            /*       SENTENCIA WHILE-(MIENTRAS)
                     --------------------------


            Console.WriteLine("Ingrese nombre de USUARIO:");
            string usuario = Console.ReadLine();
            
            while (usuario != "daniel")
            {
                Console.WriteLine("Nombre de usuario incorrecto...");
                Console.WriteLine("Por favor, vuelva ingresar el nombre de usuario");
                usuario = Console.ReadLine();
            }
            
            Console.WriteLine("Bienvenido administrador");
            */

            /*  SENTENCIA DO-WHILE (HACER-MIENTRAS)
                -----------------------------------

            string usuario;
            string contras;

            do{
                Console.WriteLine("Ingrese nombre de usuario: ");
                usuario = Console.ReadLine();
                Console.WriteLine("Ingrese contraseña");
                contras = Console.ReadLine();
            
            }while(usuario!= "administrador"|| contras!="dani");
            Console.WriteLine("Bienvenido administrador...");
            */

            /*  CAJERO AUTOMATICO
                ------------------

            Datos: USUARIO: administrador  CONTRASEÑA: 123456  SALDO: $1000

            int saldo = 1000;

            Console.WriteLine("Bienvenido a su cajero automático virtual");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Ingrese nombre de USUARIO: ");
            string usuario = Console.ReadLine();
            Console.WriteLine("Ingrese CONTRASEÑA: ");
            string contr = Console.ReadLine();

            do{
                Console.WriteLine("USUARIO y/o CONTRASEÑA incorrectos.");
                Console.WriteLine("Porfavor,ingrese nuevamente USUARIO:");
                usuario = Console.ReadLine();
                Console.WriteLine("Ingrese CONTRASEÑA:");
                contr = Console.ReadLine();

            }while(usuario != "administrador" || contr != "123456");
            Console.WriteLine("Bienveniodo administrador!");
            
            Console.WriteLine(" Eliga una opción del menú:");
            Console.WriteLine("1. DEPÓSITO                2. EXTRACCIÓN");
            Console.WriteLine("3. VER SALDO EN CUENTA     4. SALIR");
            int opcion = int.Parse(Console.ReadLine());

            switch(opcion){

                case 1:{Console.WriteLine("Digite el monto a depositar");
                int dep = int.Parse(Console.ReadLine());

                 dep =   dep+ saldo;
                Console.WriteLine("Su saldo disponible es: "+ dep);
                Console.WriteLine("");
                Console.WriteLine("Desea realizar otra operación");
                Console.WriteLine("1. Si                2. No    ");
                opcion = int.Parse(Console.ReadLine());break;}

                case 2:{Console.WriteLine("Indique el monto que desea retirar: ");
                int monto = int.Parse (Console.ReadLine());
                
                if(monto<= saldo){
                    saldo = saldo-monto;
                    Console.WriteLine("Su saldo actual es :"+saldo);
                    }
                
                else{
                    Console.WriteLine("Saldo insuficiente.Intenete nuevamente");
                }
                 break;}
                
                case 3:{Console.WriteLine("Su saldo actual es de:"+saldo);break;}
                case 4:{Console.WriteLine("Gracias por utilizar nuestros servicios!");break;}
               
           */

                
            /*            CICLO FOR
                          ---------           
                
                int suma=0;
                int cont=0;
                
                for(int i=1;i<=5;i++)
                {
                    Console.WriteLine(i);
                    cont++;
                    suma+=i;
                }
              
                Console.WriteLine("El total de números es:"+cont);
                Console.WriteLine("La suma de los numeros es:"+suma);
            /*   
             
            /*   TABLAS DE MULTIPLICAR

           

            for(int i=1; i<=10; i++)
            {
                Console.WriteLine();
            for(int j=1; j<=10; j++)
            {
                Console.WriteLine(i+"X"+j+"="+(i*j));

            }
          
                
            }*/

            /*EJERCICIO DE PRUEBA 
            -----------------------
            
            string usuar,contr;
            int cont=0, tabla=0, tecla=0, opcion=0;
            
            Console.WriteLine("EJERCICIO:");
            Console.WriteLine("BIENVENIDO AL PROGRAMA");
            Console.WriteLine("----------------------");
            Console.WriteLine("");

            // USUARIO: Administrador  /  CONTRACEÑA:Linux 

            Console.WriteLine("Ingrese nombre de usuario:");
            usuar = Console.ReadLine();
            Console.WriteLine("Ingrese contraceña: ");
            contr = Console.ReadLine();
            Console.WriteLine("");
            
            do{
                Console.WriteLine("El nombre de usuario y/o contraseña son incorrectos! ");
                Console.WriteLine("Por favor, presione 1 para volver a intentar o 2 para salir.");
                 opcion = int.Parse(Console.ReadLine());
           

                if(opcion ==1)
                {  
                    Console.WriteLine("Ingrese nombre de usuario:");
                    usuar = Console.ReadLine();
                    Console.WriteLine("Ingrese contraceña: ");
                    contr = Console.ReadLine();
                    Console.WriteLine("");
                }
            

            }while (usuar!="Administrador"||contr!="Linux");
            Console.WriteLine("Bienvenido administrador!");
            Console.WriteLine("");
            Console.WriteLine("A continuación,digite la opción que desea realizar:");
            Console.WriteLine("");
            Console.WriteLine("1.VER NÚMEROS PARES QUE VAN DEL 1 AL 100");
            Console.WriteLine("2.VER TABLA DE MULTIPLICAR DE UN NÚMERO DADO");
            Console.WriteLine("3.VER TODAS LAS TABLAS DE MULTIPLICAR");
            tecla = int.Parse(Console.ReadLine());
            
            switch(tecla)
            {
                case 1:{ Console.WriteLine("Los números pares son:"); 
                
                    for(int i=2;i<100;i=i+2)
                {   
                    cont++;
                    
                    Console.WriteLine(+i);
                }

                  Console.WriteLine("Y en total son"+cont+"números.");

                break;}

                case 2:
                { 
                    Console.WriteLine("2.VER TABLA DE MULTIPLICAR DE UN NÚMERO DADO");
                    Console.WriteLine("Por favor,digite un número del 1 al 10");
                    tabla= int.Parse(Console.ReadLine());

                    for(int i=1;i<=10;i++)
                    {
                        Console.WriteLine(tabla+"X"+i+"="+(tabla*i));
                    }
                }
                break;

                case 3:
                {    Console.WriteLine("3.VER TODAS LAS TABLAS DE MULTIPLICAR");
                        Console.WriteLine("");
                          Console.WriteLine("Las tablas son:");
                    for(int i=1; i<=10; i++)
                    {
                       Console.WriteLine("");
                        for(int j=1; j<=10;j++)
                        {
                            Console.WriteLine(+i+"X"+j+"="+(i*j));
                        }
                        

                    };break;
                }
            }*/

           /* // Arrays 
                ---------
            // Almacenan varios elementos de un mismo tipo.

            string[] nombres = {"Pepito","Fulano","Detal","Juan"};
            string[] empleados = new string[10];
           
           Console.WriteLine(nombres[2]);
           Console.WriteLine("ingrese 10 nombres:");

           for(int i=1; i<=10; i++)
           {
               empleados[i]=Console.ReadLine(); 
               Console.WriteLine();
           }
           Console.ReadKey();
           */
           /*

            int[] numeros = new int[10];
            int n1 =0;

            Console.WriteLine("Ingrese 10 números enteros:");
            
            for(int i=0; i<=9; i++)
            {
                
                numeros[i]= int.Parse(Console.ReadLine());
             
            }
        
            Console.WriteLine("Ingrese un ultimo número:");
            n1= int.Parse(Console.ReadLine());
            numeros[1]= n1;

            Console.WriteLine("El número ingresado en la posicion 1 es:"+n1); 

            Console.WriteLine("La informacion ingresada es:");
            for(int i=0; i<=9; i++)
            {
                Console.WriteLine(+numeros[i]);
            }

            //Arrays.sort(nombre del arreglo);------->>   ORDENA LOS NUMEROS DEL ARRAYS DE <
            //Arrays.reverse(nombre del arreglo);---->>   MUESTRA EL ARRAYS DE FORMA INVERTIDA    
            
            //  string[] nombres = new string[10];                         -------- 
            //  int[] numeros = new int[5];                                         |__          ARRAYS
            //  double numeros = new double[100];                                   |__ -->   UNIMENCIONALES
            //  char letras = new char[2];                                          |
            //  string[] nombres = {"Pepito","Fulano","Detal","Juan"};     --------
                                       0        1        2       3

            // int[][] numeros;                         -------
            // numeros = new int[2][];                         |__-->      ARRAYS
            // numeros[0]= new int[4];                         |       BIDIMENCIONALES
            // numeros[1]= new int[10];                 ------- 

            */


          
          

            string nombre ;
            string[] materia = new string[3];
            int[] nota = new int[3];

            Console.WriteLine("BIENVENIDO AL PROGRAMA");
            Console.WriteLine();
            Console.WriteLine("Ingrese nombre del alumno:");
            nombre= Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("A continuación ingrese 3 materias:");
            
            for(int i=0; i<=2; i++)
            {   
                materia[i] =Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Ingrese la nota de cada materia:");

            for(int j=0; j<=2; j++)
            {
                nota[j]=int.Parse (Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Los datos ingresados son:");
            Console.WriteLine("-------------------------");
            Console.WriteLine("");  //en proceso...
            Console.WriteLine("Materias:");

            for(int i=0; i<=2; i++)
            {
                 
              Console.WriteLine(materia[i]);
           
            }
              Console.WriteLine("Notas:");

               for(int j=0; j<=2; j++)
               {
                   Console.WriteLine(nota[j]);

               } //en proceso...
           
             int
            
        } 
       
         
    }
}                                                   