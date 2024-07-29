# Guía de inicio a la programación en EPLAN con C#

## Introducción

Esta guía está diseñada para ayudarte a dar tus primeros pasos en la programación de scripts para EPLAN utilizando C#, incluso si no tienes experiencia previa en programación. Aprenderemos a través de ejemplos prácticos, comenzando desde lo más básico hasta conceptos un poco más avanzados.

## Requisitos previos

- EPLAN P8 instalado en tu computadora.
- Conocimientos básicos de cómo usar EPLAN.

## Ejemplo 1: Tu primer script en EPLAN

Empecemos con un script simple que muestra un mensaje.

```csharp
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class Class
{
    [Start]
    public void Function()
    {
        MessageBox.Show("¡Puedo hacer scripts!");
    }
}
```

### Explicación:

1. `using`: Estas líneas al principio nos permiten usar funciones de Windows Forms y EPLAN.
2. `public class Class`: Definimos una clase que contendrá nuestro código.
3. `[Start]`: Esta etiqueta le dice a EPLAN que este es el punto de inicio del script.
4. `public void Function()`: Esta es la función que se ejecutará cuando EPLAN inicie el script.
5. `MessageBox.Show()`: Esta función muestra un cuadro de mensaje con el texto que le pasemos.

### Cómo ejecutar:

1. Guarda este código en un archivo con extensión `.cs`.
2. En EPLAN, ve a [Utilidades] > [Scripts] > [Ejecutar].
3. Selecciona tu archivo `.cs`.
4. Verás un cuadro de mensaje que dice "¡Puedo hacer scripts!".

## Ejemplo 2: Declarando una acción

Ahora, vamos a crear una acción que podemos llamar desde EPLAN.

```csharp
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class Class
{
    [DeclareAction("MiPrimeraAccion")]
    public void Function()
    {
        MessageBox.Show("¡Puedo hacer scripts!");
    }
}
```

### Explicación:

La principal diferencia aquí es `[DeclareAction("MiPrimeraAccion")]`. Esto registra nuestra función como una acción en EPLAN con el nombre "MiPrimeraAccion".

### Cómo usar:

1. Guarda y carga este script en EPLAN.
2. Ahora puedes llamar a "MiPrimeraAccion" desde cualquier lugar en EPLAN donde puedas ejecutar acciones, por ejemplo desde un botón u otro script.

## Ejemplo 3: Manejando eventos

Este script responde a un evento específico en EPLAN: el cierre de un proyecto.

```csharp
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class Class
{
    [DeclareEventHandler("onActionStart.String.XPrjActionProjectClose")]
    public void Function()
    {
        MessageBox.Show("¡Puedo hacer scripts!");
    }
}
```

### Explicación:

`[DeclareEventHandler("onActionStart.String.XPrjActionProjectClose")]` registra nuestra función para que se ejecute cada vez que se cierra un proyecto en EPLAN.

### Cómo usar:

1. Guarda y carga este script en EPLAN.
2. Cada vez que cierres un proyecto, verás el mensaje.

## Ejemplo 4: Registro y desregistro de scripts

Este script muestra mensajes cuando se carga y descarga.

```csharp
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class Class
{
    [DeclareRegister]
    public void Register()
    {
        MessageBox.Show("Script cargado.");
    }

    [DeclareUnregister]
    public void UnRegister()
    {
        MessageBox.Show("Script descargado.");
    }
}
```

### Explicación:

- `[DeclareRegister]`: Esta función se ejecuta cuando el script se carga en EPLAN.
- `[DeclareUnregister]`: Esta función se ejecuta cuando el script se descarga de EPLAN.

### Cómo usar:

1. Guarda y carga este script en EPLAN.
2. Verás el mensaje "Script cargado."
3. Cuando descargues el script, verás "Script descargado."

## Consejos finales

- Siempre guarda tus scripts con la extensión `.cs`.
- Usa nombres descriptivos para tus clases y funciones.
- Experimenta modificando los mensajes y añadiendo más funcionalidad.

