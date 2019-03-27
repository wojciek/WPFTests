using System;
using Framework.Domain.Logi;
using NHibernate.Criterion;
using Tit.Common.Repository;

namespace tEZD.TestyUI.SQLQueries
{
  class LogsSQLQueries
  {
    private readonly IUnitOfWork _unitOfWork;

    public LogsSQLQueries()
    {
      _unitOfWork = new UnitOfWork();
    }

    public string PobierzLogZalogowanegoOstanioUzytkownika(string nazwaUzytkownika)
    {
      var queryOver = new QueryOver().GetQueryOver<Logs>();

      queryOver.And(Restrictions.Between(Projections.Property<Logs>(l => l.AudytRekordu.DataModyfikacji), DateTime.Now.Date, DateTime.Now.Date.AddHours(23).AddMinutes(59).AddSeconds(59)));
      queryOver.And(Restrictions.InsensitiveLike(Projections.Property<Logs>(x => x.Dyspozycja), nazwaUzytkownika, MatchMode.Anywhere));
      queryOver.And(Restrictions.Eq(Projections.Property<Logs>(x => x.KodOperacji),
        "001_010"));
      queryOver.And(Restrictions.Eq(Projections.Property<Logs>(x => x.KodGrupy),
        "001"));
      var logUzyt = queryOver
        .OrderBy(l => l.AudytRekordu.DataModyfikacji)
        .Desc
        .Take(1)
        .SingleOrDefault<Logs>();

      if (logUzyt != null)
      {
        return logUzyt.Dyspozycja;
      }
      else
      {
        return null;
      }
    }
  }
}

