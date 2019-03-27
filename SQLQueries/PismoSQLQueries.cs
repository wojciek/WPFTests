using Tit.Common.Repository;
using Usc.Domain.Ezd;

namespace tEZD.TestyUI.SQLQueries
{
  public class PismoSQLQueries
  {
    private readonly IUnitOfWork _unitOfWork;
    public PismoSQLQueries()
    {
      _unitOfWork = new UnitOfWork();
    }
    public Pismo PobierzDanePisma(string numerKanc)
    {
      var queryOver = new QueryOver().GetQueryOver<Pismo>();

      var danePisma = queryOver.Where(p => p.NumerKancelaryjny == numerKanc);

      if (danePisma != null)
      {
        return danePisma.SingleOrDefault<Pismo>();
      }
      else
      {
        return null;
      }
    }
  }
}
