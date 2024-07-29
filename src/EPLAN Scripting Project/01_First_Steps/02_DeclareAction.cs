using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Objetivo:
// Declarar una acción que, cuando se llame, ejecutará el siguiente código
// Mostrar un cuadro de mensaje con información
// Esto se utilizará nuevamente en la carpeta 2

// Cargar el script en Eplan usando [Utilidades]>[Scripts]>[Cargar]
// Luego elegir el archivo desde la ubicación del archivo. 
// El archivo tendrá una extensión .cs.

public class Class
{
    [DeclareAction("NombreAccion")] //Si creas un botón con la acción "NombreAccion"  ejecutará  "Function"
    public void Function()
    {
        // Muestra un cuadro de mensaje con el texto "¡Puedo hacer scripts!"
        MessageBox.Show("¡Puedo hacer scripts!");

        return;
    }
}

// Este script demuestra cómo declarar una acción personalizada en EPLAN.
// La clase 'Class' contiene un método 'Function' decorado con el atributo [DeclareAction],
// que registra la función como una acción llamada "NombreAccion" en EPLAN.
// Esta acción puede ser llamada desde otros lugares en EPLAN o desde otros scripts.