using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowItems;

namespace tEZD.TestyUI.Maps
{
  public class PismoWplywajaceUIMap
  {
    private readonly Window _mainWindow;

    public PismoWplywajaceUIMap(Window mainWindow)
    {
      _mainWindow = mainWindow;
    }
    public TextBox NumerKancelaryjnyPisma()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("NumerKancelaryjny");
      TextBox numerkancPisma = (TextBox)_mainWindow.Get(searchCriteria);
      return numerkancPisma;
    }
    public TextBox Dysponent()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("Dysponent.Nazwa");
      TextBox dysponent = (TextBox)_mainWindow.Get(searchCriteria);
      return dysponent;
    }

    public Menu ZapiszPismo()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("ZapiszClickCommand");
      Menu menu = (Menu)_mainWindow.Get(searchCriteria);
      return menu;
    }
    public Button Pomoc()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("Pomoc");
      Button pomoc = (Button)_mainWindow.Get(searchCriteria);
      return pomoc;
    }

    public TextBox KomorkaDysponenta()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("Dysponent.Komorka");
      TextBox tytul = (TextBox)_mainWindow.Get(searchCriteria);
      return tytul;
    }
    public TextBox ZewNrKancelaryjny()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("ZewnetrznyNumerKancelaryjny");
      TextBox tytul = (TextBox)_mainWindow.Get(searchCriteria);
      return tytul;
    }

    public TextBox DataPisma()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("DataPismaTextBox");
      TextBox dataPisma = _mainWindow.Get<TextBox>(searchCriteria);
      return dataPisma;
    }

    public TextBox ZnakObcy()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("ZnakObcy");
      TextBox znakObcy = (TextBox)_mainWindow.Get(searchCriteria);
      return znakObcy;
    }
    public TextBox KodKreskowy()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("KodKreskowy");
      TextBox kodKreskowy = (TextBox)_mainWindow.Get(searchCriteria);
      return kodKreskowy;
    }
    public TextBox WyznaczonyTermin()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("TerminDekretacjiTextBox");
      TextBox wyznaczonyTermin = (TextBox)_mainWindow.Get(searchCriteria);
      return wyznaczonyTermin;
    }
    public ComboBox WyznaczonyTerminSposobWyliczeniaTerminu()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("TerminDekretacjiWyborWyliczeniaTerminu");
      ComboBox sposobDostarczenia = (ComboBox)_mainWindow.Get(searchCriteria);
      return sposobDostarczenia;
    }
    public TextBox DataWplywu()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("DataWplywuTextBox");
      TextBox dataWplywu = (TextBox)_mainWindow.Get(searchCriteria);
      return dataWplywu;
    }
    public ComboBox SposobDostarczenia()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("Sposob");
      ComboBox sposobDostarczenia = (ComboBox)_mainWindow.Get(searchCriteria);
      return sposobDostarczenia;
    }
    public TextBox NumerNadania()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("NrNadania");
      TextBox numerNadania = (TextBox)_mainWindow.Get(searchCriteria);
      return numerNadania;
    }
    public TextBox DataNadania()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("DataNadaniaTextBox");
      TextBox dataNadania = (TextBox)_mainWindow.Get(searchCriteria);
      return dataNadania;
    }
    public TextBox Tytul()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("Tytul");
      TextBox tytul = (TextBox)_mainWindow.Get(searchCriteria);
      return tytul;
    }
    public TextBox Dotyczy()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("Dotyczy");
      TextBox dotyczy = (TextBox)_mainWindow.Get(searchCriteria);
      return dotyczy;
    }

    public ComboBox RodzajPisma()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("RodzajDokumentu");
      ComboBox rodzajPisma = (ComboBox)_mainWindow.Get(searchCriteria);
      return rodzajPisma;
    }
    public ComboBox PisKaDod1()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("KategoriaDodatkowa1");
      ComboBox pisKatDod1 = (ComboBox)_mainWindow.Get(searchCriteria);
      return pisKatDod1;
    }
    public ComboBox PisKaDod2()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("KategoriaDodatkowa2");
      ComboBox pisKatDod2 = (ComboBox)_mainWindow.Get(searchCriteria);
      return pisKatDod2;
    }
    public ComboBox PisKaDod3()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("KategoriaDodatkowa3");
      ComboBox pisKatDod3 = (ComboBox)_mainWindow.Get(searchCriteria);
      return pisKatDod3;
    }
    public TextBox Uwagi()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("Uwagi");
      TextBox uwagi = (TextBox)_mainWindow.Get(searchCriteria);
      return uwagi;
    }
    public TextBox LiczbaZalacznikow()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("LiczbaZalacznikow");
      TextBox liczbaZalaczonikow = (TextBox)_mainWindow.Get(searchCriteria);
      return liczbaZalaczonikow;
    }
    public ComboBox Dostep()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("Dostep");
      ComboBox pisKatDod3 = (ComboBox)_mainWindow.Get(searchCriteria);
      return pisKatDod3;
    }
    public ComboBox Format()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("FormatDanych");
      ComboBox format = (ComboBox)_mainWindow.Get(searchCriteria);
      return format;
    }
    public ComboBox TypDanych()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("TypDanych");
      ComboBox typ = (ComboBox)_mainWindow.Get(searchCriteria);
      return typ;
    }
    public ComboBox Sklad()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("Sklad");
      ComboBox sklad = (ComboBox)_mainWindow.Get(searchCriteria);
      return sklad;
    }

    public ComboBox Proces()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("Proces");
      ComboBox proces = (ComboBox)_mainWindow.Get(searchCriteria);
      return proces;
    }
  }
}
