using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

// Objetivo:
// Ejecutar múltiples acciones en un proyecto
// 1: Esto se usa para verificar que el proyecto sea correcto
// 2: Actualiza informes para el proyecto
// 3: Ejecutar una acción personalizada llamada "Actionname"

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
        // Ejecutamos tres comandos diferentes:
        // 1. Verifica el proyecto
        oCLI.Execute("XMsgActionStartVerification");
        // 2. Actualiza los informes
        oCLI.Execute("reports");
        // 3. Ejecuta una acción personalizada llamada "NombreAccion"
        oCLI.Execute("NombreAccion");

        return;
    }
}

