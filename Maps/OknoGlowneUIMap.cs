using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.WindowStripControls;

namespace tEZD.TestyUI.Maps
{
  public class OknoGlowneUIMap
  {
    private readonly Window _mainWindow;
    public OknoGlowneUIMap(Window mainWindow)
    {
      _mainWindow = mainWindow;
    }
    public Label KomorkaUzytkownikLabel()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("KomorkaIUzytkownik");
      Label komorkaUzytkownik = (Label)_mainWindow.Get(searchCriteria);
      return komorkaUzytkownik;
    }
    public Menu MenuGlowneAplikacji(string automationId)
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId(automationId);
      MenuBar menuBar = _mainWindow.MenuBar;
      var nowePWPelementMenu = menuBar.MenuItemBy(searchCriteria);
      return nowePWPelementMenu;
    }
  }
}
