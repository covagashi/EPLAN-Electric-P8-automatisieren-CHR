using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

// Objetivo:
// Ejecutar la actualización de informes para el proyecto

// Para ejecutar este script en Eplan:
// 1. Ve a [Utilidades] > [Scripts] > [Ejecutar]
// 2. Luego elige este archivo desde su ubicación. 
// 3. El archivo tendrá una extensión .cs

public class Class
{
    // Esta etiqueta [Start] indica que esta función es el punto de entrada del script para Eplan
    [Start]
    public void Function()
    {
        // Creamos un nuevo intérprete de línea de comandos
        // Esto nos permite ejecutar comandos de EPLAN
        CommandLineInterpreter oCLI = new CommandLineInterpreter();
        // Ejecutamos el comando "reports" que actualiza los informes
        oCLI.Execute("reports");
        // Terminamos la función
        return;
    }
}

