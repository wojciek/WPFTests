using System.Threading;
using Framework.Core.Logowanie;
using Framework.Domain.Framework;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White.UIItems.WindowItems;
using tEZD.TestyUI.Maps;
using tEZD.TestyUI.SQLQueries;
using tEZD.TestyUI.Tools;

namespace tEZD.TestyUI.LogowanieTestsUI
{
  [CodedUITest]
  public class ZalogujTestUI
  {
    private readonly UruchomAplikacje uruchomAplikacje;
    private readonly OknoLogowaniaUIMap _oknoLogowania;
    private readonly OknoGlowneUIMap _oknoGlowne;
    public Window oknoAplikacji;
    private readonly UzytkownikSQLQueries _uzytkownikSqlQueries;

    private readonly Logowanie _logowanie;
    public string NazwaUzytkownika { get; set; }
    public string Haslo { get; set; }
    public Uzytkownik Uzytkownik { get; set; }
    public string KomorkaUzytLabel { get; set; }

    public ZalogujTestUI()
    {
      uruchomAplikacje = new UruchomAplikacje();
      oknoAplikacji = uruchomAplikacje.Uruchom();
      _oknoLogowania = new OknoLogowaniaUIMap(oknoAplikacji);
      _oknoGlowne = new OknoGlowneUIMap(oknoAplikacji);
      _uzytkownikSqlQueries = new UzytkownikSQLQueries();
      UstawWartosciStartowe();
    }

    public void UstawWartosciStartowe()
    {
      NazwaUzytkownika = "TestUI_1";
      Haslo = "uscusc";
      Uzytkownik = _uzytkownikSqlQueries.PobierzDaneUzytkownika(NazwaUzytkownika);
      KomorkaUzytLabel = "TEST - all | " + Uzytkownik.Nazwisko + " " + Uzytkownik.Imie;
    }

    [TestMethod]
    [DeploymentItem("hibernate.cfg.xml")]
    public void ZalogujDoAplikacjiTestMethod()
    {
      _oknoLogowania.NazwaUzytkownikaTextBox().Text = NazwaUzytkownika;
      _oknoLogowania.HasloTextBox().Text = Haslo;
      _oknoLogowania.ZalogujButton().Click();
      Thread.Sleep(3000);

      Assert.AreEqual(_oknoGlowne.KomorkaUzytkownikLabel().Text, KomorkaUzytLabel);
      LogsSQLQueries logsQuery = new LogsSQLQueries();
      logsQuery.PobierzLogZalogowanegoOstanioUzytkownika(NazwaUzytkownika);
      Assert.IsNotNull(logsQuery.PobierzLogZalogowanegoOstanioUzytkownika(NazwaUzytkownika), "Uzytkownik zalogowany nie został odnotowany w logach aplikacji");

    }
  }
}
