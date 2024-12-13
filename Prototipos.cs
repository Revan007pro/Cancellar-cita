using System;
using System.Security.Principal;
using Gtk;

namespace Prototipos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();

            // Crear la ventana principal
            Window windowPrincipal = new Window("Prototipos");
            windowPrincipal.SetDefaultSize(300, 200);
            windowPrincipal.SetPosition(WindowPosition.Center);
            windowPrincipal.DeleteEvent += (o, e) => Application.Quit();

            // Crear un contenedor vertical
            var vbox = new Box(Orientation.Vertical, 10);
            windowPrincipal.Add(vbox);

            // Crear y agregar una etiqueta al contenedor
            Label label1 = new("¿Esta seguro de Cancelar su cita?");
            vbox.PackStart(label1, false, false, 10);

            

            // Crear un contenedor horizontal para los botones
            var hbox = new Box(Orientation.Horizontal, 10);

            // Crear los botones
            Button buttonSi = new("Si");
            Button buttonNo = new("No");

            // Agregar los botones al contenedor horizontal
            hbox.PackStart(buttonSi, true, true, 5);
            hbox.PackStart(buttonNo, true, true, 5);

            buttonSi.Clicked += (o, e) => {
                VentanaCitaCancelada(windowPrincipal);
                windowPrincipal?.Hide();
                
            };

            buttonNo.Clicked += (o, e) => {
                Application.Quit();
            };

            // Agregar el contenedor horizontal al contenedor vertical
            vbox.PackStart(hbox, false, false, 10);

            // Mostrar todo el contenido
            windowPrincipal.ShowAll();
            Application.Run();
            
        }
    
            static void VentanaCitaCancelada(Window windowPrincipal ){


            Window windowCitaCancelada = new Window("Prototipos");
            windowCitaCancelada.SetDefaultSize(300, 200);
            windowCitaCancelada.SetPosition(WindowPosition.Center);

            var vbox2 = new Box(Orientation.Vertical, 10);
            windowCitaCancelada.Add(vbox2);

            Label labelCita=new Label("Estas son sus Citas");
            vbox2.PackStart(labelCita, false , false ,10);

            Button buttonFecha1=new Button("DD/MM/AA");
            vbox2.PackStart(buttonFecha1, false , false , 10);
            
            Label label2 = new("Cita Cancelada");
            vbox2.PackStart(label2, false, false, 10);

            Label label3 =new Label("¿Desea Reprogramar su cita");
            vbox2.PackStart(label3, false, false, 10);

            Button buttonSi = new("Si");
            vbox2.PackStart(buttonSi, false, false, 10);
            Button buttonNo = new("No");
            vbox2.PackStart(buttonNo, false, false, 10);

            buttonSi.Clicked +=(o,e)=>{
                ReprogramarCita(windowCitaCancelada, windowPrincipal);

                windowCitaCancelada.Hide();
                
              

            };

            buttonNo.Clicked += (o, e) => {
                Application.Quit();
            };


            windowCitaCancelada.ShowAll();
        

            }

        static void ReprogramarCita(Window windowPrincipal, Window windowCitaRe){
            Window windowReprogramar=new Window("Prototipos");
            windowReprogramar.SetDefaultSize(300,200);
            windowReprogramar.SetPosition(WindowPosition.Center);

            var vbox3 = new Box(Orientation.Vertical, 10);
            windowReprogramar.Add(vbox3);
            
            Label label1 = new("Citas Disponibles");
            vbox3.PackStart(label1, false, false, 10);

            Button buttonSi = new("dd/mm/aa");
            vbox3.PackStart(buttonSi, false , false , 10);
            Button buttonNo = new("dd/mm/aa");
            vbox3.PackStart(buttonNo, false ,false, 10);

            
            Button buttonSalir=new Button("Salir");
            vbox3.PackEnd(buttonSalir , false , false , 10);

            buttonSi.Clicked +=(o , e)=>{
                
                VentanaCitaReprogramada(windowCitaRe , windowReprogramar);
                windowReprogramar.Hide();

            };

            buttonSalir.Clicked += (o, e) => {
                Application.Quit();
            };


            windowReprogramar.ShowAll();


        }

        static void VentanaCitaReprogramada(Window windowReprogramar , Window windowPrincipal){
            Window windowCitaRe=new Window("Prototipos");
            windowCitaRe.SetDefaultSize(300,200);
            windowCitaRe.SetPosition(WindowPosition.Center);

            var vbox4 =new Box(Orientation.Vertical, 10);
            windowCitaRe.Add(vbox4);

            Label label5=new Label("Su Cita ha sido reprogramada satisfactoriamente");
            vbox4.PackStart(label5, false ,false,10);
            Label label6=new Label("¿Desea Continuar?");
            vbox4.PackStart(label6, false , false , 10);

            Button buttonSi=new Button("Si");
            vbox4.PackStart(buttonSi , false ,false ,10);
            Button buttonNo=new Button("No");
            vbox4.PackStart(buttonNo, false , false , 10);

            buttonSi.Clicked += (o , e) =>{
                windowCitaRe?.Hide();
                windowPrincipal?.Show();

            };

            buttonNo.Clicked += (o,e) =>{
                Application.Quit();
            };

            windowCitaRe.ShowAll();
            windowReprogramar?.Hide();
        }
        
    }
}
