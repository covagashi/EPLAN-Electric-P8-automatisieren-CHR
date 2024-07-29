using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Objetivo:
// Mostrar un cuadro de mensaje con información después de cargar un script
// El primer mensaje se mostrará después de cargar el script
// El segundo mensaje se mostrará después de descargar el script

// Cargar el script en Eplan usando [Utilidades]>[Scripts]>[Cargar]
// Luego elegir el archivo desde la ubicación del archivo. 
// El archivo tendrá una extensión .cs.

public class Class
{
    [DeclareRegister]
    public void Register()
    {
        // Muestra un cuadro de mensaje indicando que el script ha sido cargado
        MessageBox.Show("Script cargado.");

        return;
    }

    [DeclareUnregister]
    public void UnRegister()
    {
        // Muestra un cuadro de mensaje indicando que el script ha sido descargado
        MessageBox.Show("Script descargado.");

        return;
    }
}

// Este script demuestra cómo usar los atributos [DeclareRegister] y [DeclareUnregister] en EPLAN.
// La clase 'Class' contiene dos métodos:
// - 'Register' se ejecuta cuando el script se carga en EPLAN.
// - 'UnRegister' se ejecuta cuando el script se descarga de EPLAN.
// Esto es útil para realizar acciones de inicialización y limpieza cuando se carga o descarga el script.
