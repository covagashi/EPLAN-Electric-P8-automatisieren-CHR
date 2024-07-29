using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;
using System.Windows.Forms;

public class Class
{
  [DeclareAction("XSDShowMatchingMasterDialogAction", 50)]
  public void Function()
  {
    MessageBox.Show("¡Precaución!");

    ActionCallingContext acc = new ActionCallingContext();
    Eplan.EplApi.ApplicationFramework.Action action =
        new ActionManager().FindBaseActionFromFunctionAction(false);    
    action.Execute(acc);
  }
}