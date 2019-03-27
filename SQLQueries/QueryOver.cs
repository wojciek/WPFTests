using EnsureThat;
using NHibernate;
using Tit.Common.Repository;

namespace tEZD.TestyUI.SQLQueries
{
  public class QueryOver
  {
    private readonly IUnitOfWork _unitOfWork;

    public QueryOver()
    {
      _unitOfWork = new UnitOfWork();
    }

    public IQueryOver<T, T> GetQueryOver<T>() where T : class
    {
      var session = _unitOfWork.GetSession();
      var queryOver = session.QueryOver<T>();
      Ensure.That(queryOver, nameof(queryOver)).IsNotNull();
      return queryOver;
    }
  }
}


