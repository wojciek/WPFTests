using TestyJednostkoweAdministracja.Uslugi;

namespace tEZD.TestyUI.Tools
{
  public class StartowaKonfiguracja
  {
    public static void Konfiguruj()
    {
      UstawieniePolaczeniaBazodanowego.UstawPolaczenieZBazaDanych(
        "Data Source=DBServer;Initial Catalog=Database;User ID=iis_user;Password=P@ssw0rd;MultipleActiveResultSets=True;");
    }
  }
}
