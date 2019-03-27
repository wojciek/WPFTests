using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tEZD.TestyUI.LogowanieTestsUI;
using tEZD.TestyUI.Maps;
using tEZD.TestyUI.SQLQueries;
using Usc.Domain.Ezd;

namespace tEZD.TestyUI.PismoPWPTestsUI
{
  [CodedUITest]
  public class NowePismoPWPMinimumTestUI
  {
    public string Nazwisko { get; set; }
    public string Miejscowosc { get; set; }
    public string SposobDostarczenia { get; set; }
    public string Tytul { get; set; }
    public string RodzajPisma { get; set; }

    private readonly ZalogujTestUI zalogujDoAplikacji;
    private readonly OknoGlowneUIMap _oknoGlowneUIMap;
    private readonly PismoWplywajaceUIMap _pismoWplywajaceUIMap;
    private readonly KontrahentUIMap _kontrahentUIMap;
    public NowePismoPWPMinimumTestUI()
    {
      zalogujDoAplikacji = new ZalogujTestUI();
      _oknoGlowneUIMap = new OknoGlowneUIMap(zalogujDoAplikacji.oknoAplikacji);
      _pismoWplywajaceUIMap = new PismoWplywajaceUIMap(zalogujDoAplikacji.oknoAplikacji);
      _kontrahentUIMap = new KontrahentUIMap(zalogujDoAplikacji.oknoAplikacji);
      UstawWartosciStartowe();


    }
    public void UstawWartosciStartowe()
    {
      Miejscowosc = "Gliwice";
      Nazwisko = "(TestNazwisko)";
      RodzajPisma = "PIOG";
      SposobDostarczenia = "OSB";
      Tytul = "(Tytul testowy pisma uzytkownika Test_UI_1)";
    }

    [TestMethod]
    [TestCategory("RejestracjaPWP")]
    [DeploymentItem("hibernate.cfg.xml")]
    public void ZarejestrujNowePismoPWPMinimumTestMethod()
    {
      #region Uruchomienie_I_Wpisanie_danych_podstawowych

      zalogujDoAplikacji.ZalogujDoAplikacjiTestMethod();
      _oknoGlowneUIMap.MenuGlowneAplikacji("NowePWPCommand").Click();
      _kontrahentUIMap.Nazwisko().EditableText = Nazwisko;
      _kontrahentUIMap.Miejscowosc().EditableText = Miejscowosc;
      _pismoWplywajaceUIMap.SposobDostarczenia().Click();
      Keyboard.SendKeys(SposobDostarczenia);
      Keyboard.SendKeys("{Enter}");
      _pismoWplywajaceUIMap.Tytul().Text = Tytul;
      _pismoWplywajaceUIMap.RodzajPisma().Click();
      Keyboard.SendKeys(RodzajPisma);
      Keyboard.SendKeys("{Enter}");
      _pismoWplywajaceUIMap.ZapiszPismo().Click();

      #endregion

      #region Assercje
      PismoSQLQueries pismoQuery = new PismoSQLQueries();
      Pismo pismoDB = pismoQuery.PobierzDanePisma(_pismoWplywajaceUIMap.NumerKancelaryjnyPisma().Text);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Nazwisko, _kontrahentUIMap.Nazwisko().EditableText);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Adres.MiejscowoscNazwa, _kontrahentUIMap.Miejscowosc().EditableText);
      Assert.AreEqual(pismoDB.Sposob, SposobDostarczenia);
      Assert.AreEqual(pismoDB.Tytul, _pismoWplywajaceUIMap.Tytul().Text);
      Assert.AreEqual(pismoDB.RodzajDokumentu, RodzajPisma);
      #endregion

    }
  }
}
