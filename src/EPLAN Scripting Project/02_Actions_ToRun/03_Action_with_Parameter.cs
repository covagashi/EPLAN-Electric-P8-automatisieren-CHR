using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

// Objetivo:
// Ejecutar una acción en un proyecto utilizando una entrada del usuario
// Cuando se ejecuta, si seleccionas una propiedad de texto, el tamaño de la fuente se formateará a 20
// Esto se puede ejecutar seleccionando el texto y luego ejecutando el script


// Para ejecutar este script en Eplan:
// 1. Ve a [Utilidades] > [Scripts] > [Ejecutar]
// 2. Luego elige este archivo desde su ubicación. 
// 3. El archivo tendrá una extensión .cs

public class Class
{
    [Start]
    public void Function()
    {
        // Creamos un nuevo intérprete de línea de comandos
        CommandLineInterpreter oCLI = new CommandLineInterpreter();
        // Creamos un nuevo contexto para llamar a la acción
        ActionCallingContext acc = new ActionCallingContext();
        // Añadimos parámetros a la acción:
        // El nombre de la acción es "XGedIaFormatText"
        acc.AddParameter("Name", "XGedIaFormatText");
        // El tamaño de la fuente será 20 (en EPLAN, 1 unidad = 20 puntos)
        acc.AddParameter("height", "1");
        // Ejecutamos la acción que permite al usuario interactuar
        oCLI.Execute("XGedStartInteractionAction", acc);

        return;
    }
}

