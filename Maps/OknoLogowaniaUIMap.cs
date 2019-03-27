using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace tEZD.TestyUI.Maps
{
  public class OknoLogowaniaUIMap
  {
    private readonly Window _mainWindow;

    public OknoLogowaniaUIMap(Window mainWindow)
    {
      _mainWindow = mainWindow;
    }

    public TextBox NazwaUzytkownikaTextBox()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("NazwaUzytkownika");
      TextBox uzytkownikTextBox = (TextBox)_mainWindow.Get(searchCriteria);
      return uzytkownikTextBox;
    }

    public TextBox HasloTextBox()
    {
      SearchCriteria hasloSearchCriteria = SearchCriteria.ByAutomationId("Haslo");
      TextBox hasloTextBox = (TextBox)_mainWindow.Get(hasloSearchCriteria);
      return hasloTextBox;
    }


    public Button ZalogujButton()
    {
      SearchCriteria zalogujSearchCriteria = SearchCriteria.ByAutomationId("LogowanieCommand");
      Button zalogujButton = (Button)_mainWindow.Get(zalogujSearchCriteria);
      return zalogujButton;
    }
  }
}
