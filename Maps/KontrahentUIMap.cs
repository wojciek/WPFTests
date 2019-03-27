using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;

namespace tEZD.TestyUI.Maps
{
  public class KontrahentUIMap
  {
    private readonly Window _mainWindow;

    public KontrahentUIMap(Window mainWindow)
    {
      _mainWindow = mainWindow;
    }

    public ComboBox Typ()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("NadawcaTyp");
      ComboBox typ = _mainWindow.Get<ComboBox>(searchCriteria);
      return typ;
    }

    public ComboBox TypNowy()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("NadawcaTyp");
      ComboBox typ = _mainWindow.Get<ComboBox>(searchCriteria);
      return typ;
    }

    public ComboBox Wyroznik()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("NadawcaWyroznik1");
      ComboBox wyroznik = (ComboBox)_mainWindow.Get(searchCriteria);
      return wyroznik;
    }
    public TextBox KodKontrahenta()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("NadawcaKod");
      TextBox kodKontrahenta = (TextBox)_mainWindow.Get(searchCriteria);
      return kodKontrahenta;
    }
    public TextBox Akronim()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("NadawcaAkronim");
      TextBox akronim = (TextBox)_mainWindow.Get(searchCriteria);
      return akronim;
    }

    public ComboBox Nazwisko()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("NadawcaNazwisko");
      ComboBox nazwisko = (ComboBox)_mainWindow.Get(searchCriteria);
      return nazwisko;
    }
    public ComboBox ImiePierwsze()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("NadawcaImiePierwsze");
      ComboBox imiePierwsze = (ComboBox)_mainWindow.Get(searchCriteria);
      return imiePierwsze;
    }
    public ComboBox ImieDrugie()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("NadawcaImieDrugie");
      ComboBox imieDrugie = (ComboBox)_mainWindow.Get(searchCriteria);
      return imieDrugie;
    }

    public ComboBox Kraj()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("NadawcaAdresKrajIdComboBox");
      ComboBox kraj = (ComboBox)_mainWindow.Get(searchCriteria);
      return kraj;
    }
    public ComboBox Miejscowosc()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("NadawcaAdresMiejscowoscIdComboBox");
      ComboBox miejscowosc = (ComboBox)_mainWindow.Get(searchCriteria);
      return miejscowosc;
    }

    public ComboBox Ulica()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("NadawcaAdresUlicaIdComboBox");
      ComboBox ulica = (ComboBox)_mainWindow.Get(searchCriteria);
      return ulica;
    }
    public TextBox NumerDomu()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("NadawcaAdresNumerBudynku");
      TextBox numerDomu = (TextBox)_mainWindow.Get(searchCriteria);
      return numerDomu;
    }
    public TextBox NumerLokalu()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("NadawcaAdresNumerLokalu");
      TextBox numerLokalu = (TextBox)_mainWindow.Get(searchCriteria);
      return numerLokalu;
    }
    public TextBox KodPocztowy()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("NadawcaAdresKodPocztowy");
      TextBox kodPocztowy = (TextBox)_mainWindow.Get(searchCriteria);
      return kodPocztowy;
    }
    public ComboBox Poczta()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("NadawcaAdresPoczta");
      ComboBox poczta = (ComboBox)_mainWindow.Get(searchCriteria);
      return poczta;
    }

    public TextBox SkrytkaPocztowa()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("NadawcaAdresSkrytkaPocztowa");
      TextBox skrytkaPocztowa = (TextBox)_mainWindow.Get(searchCriteria);
      return skrytkaPocztowa;
    }
    public TextBox Telefon()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("NadawcaTel");
      TextBox telefon = (TextBox)_mainWindow.Get(searchCriteria);
      return telefon;
    }
    public TextBox Fax()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("NadawcaFax");
      TextBox fax = (TextBox)_mainWindow.Get(searchCriteria);
      return fax;
    }
    public TextBox Email()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("NadawcaEmail");
      TextBox email = (TextBox)_mainWindow.Get(searchCriteria);
      return email;
    }
    public TextBox Nip()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("NadawcaNIP");
      TextBox nip = (TextBox)_mainWindow.Get(searchCriteria);
      return nip;
    }

    public TextBox Regon()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("NadawcaRegon");
      TextBox regon = (TextBox)_mainWindow.Get(searchCriteria);
      return regon;
    }

    public TextBox Pesel()
    {
      SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("NadawcaPesel");
      TextBox pesel = (TextBox)_mainWindow.Get(searchCriteria);
      return pesel;
    }
  }
}
