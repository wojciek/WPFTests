using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tEZD.TestyUI.LogowanieTestsUI;
using tEZD.TestyUI.Maps;
using tEZD.TestyUI.SQLQueries;
using Usc.Domain.Ezd;

namespace tEZD.TestyUI.PismoPWPTestsUI
{
  [CodedUITest]
  public class NowePismoPWPMaximumTestUI
  {
    public string TypPisma = nameof(NowePismoPWPMaximumTestUI).Replace("NowePismo", "").Substring(0, 3);
    public string NumerKancelaryjny;
    public string ZewnetrznyNumerKancelaryjny = ZwrocLosowegoStringa();
    public string KomorkaDysponenta = "TEST";
    public string Dysponent;
    public string Typ = "OF";
    public string Wyroznik = "USC";
    public string KodKontrahenta = "(KodKOntrahenta)";
    public string Akronim = "(Akronim)";
    public string Nazwisko = "(TestNazwisko)";
    public string ImiePierwsze = "(ImiePierwsze)";
    public string ImieDrugie = "(ImieDrugie)";
    public string Kraj = "Polska";
    public string Miejscowosc = "Gliwice";
    public string Ulica = "(Ulica)";
    public string NumerDomu = "(NrDom)";
    public string NumerLokalu = "(NrLok)";
    public string KodPocztowy = "11-111";
    public string Poczta = "(Poczta)";
    public string SkrytkaPocztowa = "(SkrytkaPocztowa)";
    public string Telefon = "(555 555 555)";
    public string Fax = "(32 222 22 22)";
    public string Email = "(mail@mail.com)";
    public string Nip = "111-11-111-11";
    public string Regon = "(RegonNumer)";
    public string Pesel = "11111111111";
    public DateTime DataPisma = DateTime.Now.Date;
    public string ZnakObcy = "(Znakobcy)";
    public string KodKreskowy = "(Kod kreskowy)";
    public string WyznaczonyTerminWylicz = "KPA_14";
    public string SposobDostarczenia = "OSB";
    public string NumerNadania = "(Numer nadania)";
    public DateTime DataNadania = DateTime.Now.Date.AddDays(3);
    public string Tytul = "(Tytul testowy pisma uzytkownika Test_UI_1)";
    public string Dotyczy = "(Dotyczy testowo pisma uzytkownika Test_UI_1";
    public string RodzajPisma = "PIOG";
    public string KatDodPis1 = "U1";
    public string KatDodPis2 = "KOR_PO";
    public string KatDodPis3 = "A";
    public string RozwinDodatkoweDanePisma = "{Tab}{Enter}";
    public string Uwagi = "Uwagi dotyczące pisma uzytkownika Test_UI_1";
    public string Dostep = "PBC";
    public string Format = "TEST1";
    public string TypDanych = "Collection";
    public string Sklad = "SKNI";


    private readonly ZalogujTestUI zalogujDoAplikacji;
    private readonly OknoGlowneUIMap _oknoGlowneUIMap;
    private readonly PismoWplywajaceUIMap _pismoWplywajaceUIMap;
    private readonly KontrahentUIMap _kontrahentUIMap;
    private readonly UzytkownikSQLQueries _uzytkownikSqlQueries;

    public NowePismoPWPMaximumTestUI()
    {
      zalogujDoAplikacji = new ZalogujTestUI();
      _oknoGlowneUIMap = new OknoGlowneUIMap(zalogujDoAplikacji.oknoAplikacji);
      _pismoWplywajaceUIMap = new PismoWplywajaceUIMap(zalogujDoAplikacji.oknoAplikacji);
      _kontrahentUIMap = new KontrahentUIMap(zalogujDoAplikacji.oknoAplikacji);
      _uzytkownikSqlQueries = new UzytkownikSQLQueries();
      Dysponent = _uzytkownikSqlQueries.PobierzDaneUzytkownika(zalogujDoAplikacji.NazwaUzytkownika).Nazwisko + " " +
                  _uzytkownikSqlQueries.PobierzDaneUzytkownika(zalogujDoAplikacji.NazwaUzytkownika).Imie;
    }
    [TestMethod]
    [TestCategory("RejestracjaPWP")]
    [DeploymentItem("hibernate.cfg.xml")]
    public void ZarejestrujNowePismoPWPMaximumTestMethod()
    {
      #region Uruchomienie_I_Wpisanie_danych_podstawowych
      //zaloguj
      zalogujDoAplikacji.ZalogujDoAplikacjiTestMethod();
      //nowePismoClick
      _oknoGlowneUIMap.MenuGlowneAplikacji("NowePWPCommand").Click();
      //Kontrahent
      _kontrahentUIMap.Wyroznik().Click();
      ZaznaczElementZGotowejListyComboBox(Wyroznik);
      _kontrahentUIMap.KodKontrahenta().Text = KodKontrahenta;
      _kontrahentUIMap.Akronim().Text = Akronim;
      _kontrahentUIMap.Nazwisko().EditableText = Nazwisko;
      _kontrahentUIMap.ImiePierwsze().EditableText = ImiePierwsze;
      _kontrahentUIMap.ImieDrugie().EditableText = ImieDrugie;
      _kontrahentUIMap.Miejscowosc().EditableText = Miejscowosc;
      _kontrahentUIMap.Ulica().EditableText = Ulica;
      _kontrahentUIMap.NumerDomu().Text = NumerDomu;
      _kontrahentUIMap.NumerLokalu().Text = NumerLokalu;
      _kontrahentUIMap.KodPocztowy().Text = KodPocztowy;
      _kontrahentUIMap.Poczta().EditableText = Poczta;
      _kontrahentUIMap.SkrytkaPocztowa().Text = SkrytkaPocztowa;
      _kontrahentUIMap.Telefon().Text = Telefon;
      _kontrahentUIMap.Fax().Text = Fax;
      _kontrahentUIMap.Email().Text = Email;
      _kontrahentUIMap.Nip().Text = Nip;
      _kontrahentUIMap.Regon().Text = Regon;
      _kontrahentUIMap.Pesel().Text = Pesel;
      //Pismo
      _pismoWplywajaceUIMap.ZewNrKancelaryjny().Text = ZewnetrznyNumerKancelaryjny;
      _pismoWplywajaceUIMap.DataPisma().Text = DateTime.Now.ToShortDateString();
      _pismoWplywajaceUIMap.ZnakObcy().Text = ZnakObcy;
      _pismoWplywajaceUIMap.KodKreskowy().Text = KodKreskowy;
      _pismoWplywajaceUIMap.WyznaczonyTerminSposobWyliczeniaTerminu().Click();
      ZaznaczElementZGotowejListyComboBox(WyznaczonyTerminWylicz);
      _pismoWplywajaceUIMap.SposobDostarczenia().Click();
      ZaznaczElementZGotowejListyComboBox(SposobDostarczenia);
      _pismoWplywajaceUIMap.NumerNadania().Text = NumerNadania;
      _pismoWplywajaceUIMap.DataNadania().Text = DataNadania.ToShortDateString();
      _pismoWplywajaceUIMap.Tytul().Text = Tytul;
      _pismoWplywajaceUIMap.Dotyczy().Text = Dotyczy;
      _pismoWplywajaceUIMap.RodzajPisma().Click();
      ZaznaczElementZGotowejListyComboBox(RodzajPisma);
      _pismoWplywajaceUIMap.PisKaDod1().Click();
      ZaznaczElementZGotowejListyComboBox(KatDodPis1);
      _pismoWplywajaceUIMap.PisKaDod2().Click();
      ZaznaczElementZGotowejListyComboBox(KatDodPis2);
      _pismoWplywajaceUIMap.PisKaDod3().Click();
      ZaznaczElementZGotowejListyComboBox(KatDodPis3);
      RozwinDaneDodatkowePisma();
      _pismoWplywajaceUIMap.Uwagi().Text = Uwagi;
      _pismoWplywajaceUIMap.Dostep().Click();
      ZaznaczElementZGotowejListyComboBox(Dostep);
      _pismoWplywajaceUIMap.Format().Click();
      ZaznaczElementZGotowejListyComboBox(Format);
      _pismoWplywajaceUIMap.TypDanych().Click();
      ZaznaczElementZGotowejListyComboBox(TypDanych);
      _pismoWplywajaceUIMap.Sklad().Click();
      ZaznaczElementZGotowejListyComboBox(Sklad);
      Thread.Sleep(1000);
      _pismoWplywajaceUIMap.ZapiszPismo().Click();
      #endregion
      Thread.Sleep(1000);
      #region Assercje
      PismoSQLQueries pismoQuery = new PismoSQLQueries();
      NumerKancelaryjny = _pismoWplywajaceUIMap.NumerKancelaryjnyPisma().Text;
      Pismo pismoDB = pismoQuery.PobierzDanePisma(NumerKancelaryjny);
      //Assercje z danymi w bazie danych
      Assert.AreEqual(pismoDB.Typ.ToString(), TypPisma);
      Assert.AreEqual(pismoDB.Dysponent.Komorka, KomorkaDysponenta);
      Assert.AreEqual(pismoDB.Dysponent.Nazwisko + " " + pismoDB.Dysponent.Imie.ToString(), Dysponent);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Typ, Typ);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Wyroznik1, Wyroznik);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Kod, KodKontrahenta);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Akronim, Akronim);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Nazwisko, Nazwisko);
      Assert.AreEqual(pismoDB.DaneKontrahenta.ImiePierwsze, ImiePierwsze);
      Assert.AreEqual(pismoDB.DaneKontrahenta.ImieDrugie, ImieDrugie);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Adres.KrajNazwa, Kraj);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Adres.MiejscowoscNazwa, Miejscowosc);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Adres.UlicaNazwa, Ulica);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Adres.NumerBudynku, NumerDomu);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Adres.NumerLokalu, NumerLokalu);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Adres.KodPocztowy, KodPocztowy);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Adres.Poczta, Poczta);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Adres.SkrytkaPocztowa, SkrytkaPocztowa);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Tel, Telefon);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Fax, Fax);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Email, Email);
      Assert.AreEqual(pismoDB.DaneKontrahenta.NIP, Nip);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Regon, Regon);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Pesel, Pesel);
      Assert.AreEqual(pismoDB.DataPisma, DataPisma);
      Assert.AreEqual(pismoDB.ZnakObcy, ZnakObcy);
      Assert.AreEqual(pismoDB.KodKreskowy, KodKreskowy);
      Assert.AreEqual(pismoDB.TerminDekretacji.Value.ToShortDateString(), _pismoWplywajaceUIMap.WyznaczonyTermin().Text);
      Assert.AreEqual(pismoDB.Sposob, SposobDostarczenia);
      Assert.AreEqual(pismoDB.NrNadania, NumerNadania);
      Assert.AreEqual(pismoDB.DataNadania, DataNadania);
      Assert.AreEqual(pismoDB.Tytul, Tytul);
      Assert.AreEqual(pismoDB.Dotyczy, Dotyczy);
      Assert.AreEqual(pismoDB.RodzajDokumentu, RodzajPisma);
      Assert.AreEqual(pismoDB.KategoriaDodatkowa1, KatDodPis1);
      Assert.AreEqual(pismoDB.KategoriaDodatkowa2, KatDodPis2);
      Assert.AreEqual(pismoDB.KategoriaDodatkowa3, KatDodPis3);
      Assert.AreEqual(pismoDB.Uwagi, Uwagi);
      Assert.AreEqual(pismoDB.Dostep, Dostep);
      Assert.AreEqual(pismoDB.FormatDanych, Format);
      Assert.AreEqual(pismoDB.TypDanych, TypDanych);
      Assert.AreEqual(pismoDB.Sklad, Sklad);

      //Assercje z danymi na widoku
      Assert.AreEqual(pismoDB.Dysponent.Komorka, _pismoWplywajaceUIMap.KomorkaDysponenta().Text);
      Assert.AreEqual(pismoDB.Dysponent.Nazwisko + " " + pismoDB.Dysponent.Imie, _pismoWplywajaceUIMap.Dysponent().Text);
      //Assert.AreEqual(pismoDB.DaneKontrahenta.Typ, _kontrahentUIMap.Typ().SelectedItemText);
      // Assert.AreEqual(pismoDB.DaneKontrahenta.Wyroznik1, _kontrahentUIMap.Wyroznik().EditableText);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Kod, _kontrahentUIMap.KodKontrahenta().Text);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Akronim, _kontrahentUIMap.Akronim().Text);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Nazwisko, _kontrahentUIMap.Nazwisko().EditableText);
      Assert.AreEqual(pismoDB.DaneKontrahenta.ImiePierwsze, _kontrahentUIMap.ImiePierwsze().EditableText);
      Assert.AreEqual(pismoDB.DaneKontrahenta.ImieDrugie, _kontrahentUIMap.ImieDrugie().EditableText);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Adres.KrajNazwa, _kontrahentUIMap.Kraj().EditableText);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Adres.MiejscowoscNazwa, _kontrahentUIMap.Miejscowosc().EditableText);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Adres.UlicaNazwa, _kontrahentUIMap.Ulica().EditableText);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Adres.NumerBudynku, _kontrahentUIMap.NumerDomu().Text);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Adres.NumerLokalu, _kontrahentUIMap.NumerLokalu().Text);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Adres.KodPocztowy, _kontrahentUIMap.KodPocztowy().Text);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Adres.Poczta, _kontrahentUIMap.Poczta().EditableText);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Adres.SkrytkaPocztowa, _kontrahentUIMap.SkrytkaPocztowa().Text);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Tel, _kontrahentUIMap.Telefon().Text);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Fax, _kontrahentUIMap.Fax().Text);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Email, _kontrahentUIMap.Email().Text);
      Assert.AreEqual(pismoDB.DaneKontrahenta.NIP, _kontrahentUIMap.Nip().Text);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Regon, _kontrahentUIMap.Regon().Text);
      Assert.AreEqual(pismoDB.DaneKontrahenta.Pesel, _kontrahentUIMap.Pesel().Text);
      Assert.AreEqual(pismoDB.DataPisma, _pismoWplywajaceUIMap.DataPisma().Text);
      Assert.AreEqual(pismoDB.ZnakObcy, _pismoWplywajaceUIMap.ZnakObcy().Text);
      Assert.AreEqual(pismoDB.KodKreskowy, _pismoWplywajaceUIMap.KodKreskowy().Text);
      Assert.AreEqual(pismoDB.TerminDekretacji, _pismoWplywajaceUIMap.DataPisma().Text);
      //Assert.AreEqual(pismoDB.Sposob, _pismoWplywajaceUIMap.SposobDostarczenia().EditableText);
      Assert.AreEqual(pismoDB.NrNadania, _pismoWplywajaceUIMap.NumerNadania().Text);
      Assert.AreEqual(pismoDB.DataNadania, _pismoWplywajaceUIMap.DataNadania().Text);
      Assert.AreEqual(pismoDB.Tytul, _pismoWplywajaceUIMap.Tytul().Text);
      Assert.AreEqual(pismoDB.Dotyczy, _pismoWplywajaceUIMap.Dotyczy().Text);
      //Assert.AreEqual(pismoDB.RodzajDokumentu, _pismoWplywajaceUIMap.RodzajPisma().EditableText);
      //Assert.AreEqual(pismoDB.KategoriaDodatkowa1, _pismoWplywajaceUIMap.PisKaDod1().EditableText);
      //Assert.AreEqual(pismoDB.KategoriaDodatkowa2, _pismoWplywajaceUIMap.PisKaDod2().EditableText);
      //Assert.AreEqual(pismoDB.KategoriaDodatkowa3, _pismoWplywajaceUIMap.PisKaDod3().EditableText);
      Assert.AreEqual(pismoDB.Uwagi, _pismoWplywajaceUIMap.Uwagi().Text);
      //Assert.AreEqual(pismoDB.Dostep, _pismoWplywajaceUIMap.Dostep().EditableText);
      //Assert.AreEqual(pismoDB.FormatDanych, _pismoWplywajaceUIMap.Format().EditableText);
      //Assert.AreEqual(pismoDB.TypDanych, _pismoWplywajaceUIMap.TypDanych().EditableText);
      //Assert.AreEqual(pismoDB.Sklad, _pismoWplywajaceUIMap.Sklad().EditableText);
      #endregion

    }

    private static void RozwinDaneDodatkowePisma()
    {
      Keyboard.SendKeys("{Tab}");
      Keyboard.SendKeys("{Enter}");
    }

    static void ZaznaczElementZGotowejListyComboBox(string parameter)
    {
      Keyboard.SendKeys(parameter);
      Keyboard.SendKeys("{Enter}");
    }

    static string ZwrocLosowegoStringa()
    {
      Random rand = new Random();
      string x = rand.Next(1000) + "_" + rand.Next(12345);
      return x;
    }
  }
}
