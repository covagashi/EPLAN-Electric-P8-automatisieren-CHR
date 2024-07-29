using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Objetivo:
// Mostrar un cuadro de mensaje con información

// Ejecutar el script en Eplan usando [Utilidades]>[Scripts]>[Ejecutar]
// Luego elegir el archivo desde la ubicación del archivo. 
// El archivo tendrá una extensión .cs. 

public class Class
{
    [Start]
    public void Function()
    {
        // Muestra un cuadro de mensaje con el texto "¡Puedo hacer scripts!"
        MessageBox.Show("¡Puedo hacer scripts!"); 
        return;
    }
}

// Este script es un ejemplo básico de cómo crear y ejecutar un script en EPLAN.
// La clase 'Class' contiene un método 'Function' decorado con el atributo [Start],
// lo que indica a EPLAN que este es el punto de entrada del script.
// Cuando se ejecuta, mostrará un cuadro de mensaje simple.
