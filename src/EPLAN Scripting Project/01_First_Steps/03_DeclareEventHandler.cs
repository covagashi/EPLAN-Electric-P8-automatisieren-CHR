using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Objetivo:
// Mostrar un cuadro de mensaje con información después de cerrar un proyecto
// Esto se mostrará después de cerrar un proyecto

// Cargar el script en Eplan usando [Utilidades]>[Scripts]>[Cargar]
// Luego elegir el archivo desde la ubicación del archivo. 
// El archivo tendrá una extensión .cs.

public class Class
{
    [DeclareEventHandler("onActionStart.String.XPrjActionProjectClose")] // Esta es un evento interno del propio Eplan
    public void Function()
    {
        // Muestra un cuadro de mensaje con el texto "¡Puedo hacer scripts!"
        MessageBox.Show("¡Puedo hacer scripts!");

        return;
    }
}

// Este script demuestra cómo declarar un manejador de eventos en EPLAN.
// La clase 'Class' contiene un método 'Function' decorado con el atributo [DeclareEventHandler],
// que registra la función para que se ejecute cuando ocurra el evento de cierre de proyecto.
// Cada vez que se cierre un proyecto en EPLAN, se mostrará el cuadro de mensaje.