using Framework.Domain.Framework;
using Tit.Common.Repository;

namespace tEZD.TestyUI.SQLQueries
{
  public class UzytkownikSQLQueries
  {
    private readonly IUnitOfWork _unitOfWork;
    public UzytkownikSQLQueries()
    {
      _unitOfWork = new UnitOfWork();
    }
    public Uzytkownik PobierzDaneUzytkownika(string nazwaUzytkownika)
    {
      var queryOver = new QueryOver().GetQueryOver<Uzytkownik>();

      var daneUzytkownika = queryOver.Where(p => p.NazwaUzytkownika == nazwaUzytkownika);

      if (daneUzytkownika != null)
      {
        return daneUzytkownika.SingleOrDefault<Uzytkownik>();
      }
      else
      {
        return null;
      }
    }
  }
}
