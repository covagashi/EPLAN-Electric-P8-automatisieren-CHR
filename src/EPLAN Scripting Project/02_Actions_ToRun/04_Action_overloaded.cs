using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;
using System.Windows.Forms;

public class Class
{
  // Esta línea declara una nueva acción en EPLAN
  // Estamos "sobrecargando" (overloading) una acción existente llamada "XSDShowMatchingMasterDialogAction"
  [DeclareAction("XSDShowMatchingMasterDialogAction", 50)]
  public void Function()
  {
    // Este es nuestro código personalizado que se ejecutará antes de la acción original
    // En este caso, simplemente mostramos un mensaje de advertencia
    MessageBox.Show("¡Precaución!");

    // Ahora, preparamos para ejecutar la acción original

    // Creamos un nuevo contexto para llamar a la acción
    // Esto es necesario para pasar cualquier parámetro que la acción original pueda necesitar
    ActionCallingContext acc = new ActionCallingContext();
    
    // Buscamos la acción base original de EPLAN
    // Esto es clave en el "action overloading": estamos obteniendo la acción que estamos sobrecargando
    Eplan.EplApi.ApplicationFramework.Action action =
        new ActionManager().FindBaseActionFromFunctionAction(false);    
    
    // Finalmente, ejecutamos la acción original
    // Esto asegura que la funcionalidad original de EPLAN se mantenga
    action.Execute(acc);
  }
}


    

