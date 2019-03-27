using System.Linq;
using System.Threading;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;

namespace tEZD.TestyUI.Tools
{
  public class UruchomAplikacje
  {
    public UruchomAplikacje()
    {
      StartowaKonfiguracja.Konfiguruj();
    }
    public Window Uruchom()
    {
      Application aplikacja = Application.Launch(@"C:\Apps\tEZD\dev\tEZD\tEZD.exe");
      Thread.Sleep(9000);
      string activeWindowName = aplikacja.GetWindows().Where(x => x.Name.Contains("tEZD_")).FirstOrDefault().Name;
      Window mainWindow = aplikacja.GetWindow(activeWindowName);

      return mainWindow;
    }
  }
}
