using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUFMAN.DAL.Maps.Ves;

namespace TUFMAN_DAL_Tests.Configuration
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        public static ISessionFactory SessionFactory
        {
            get { return _sessionFactory ?? (_sessionFactory = CreateSessionFactory()); }
        }

        private static ISessionFactory CreateSessionFactory()
        {

            NHibernate.Cfg.Configuration config = Fluently.Configure().
                Database(MsSqlConfiguration.MsSql2008.ConnectionString("Server=SPC122004-WIN7\\SQLEXPRESS;Database=tufman_mh;Trusted_Connection=True")).
                Mappings(m => m.FluentMappings.AddFromAssemblyOf<VesselsMap>()).
                CurrentSessionContext<ThreadStaticSessionContext>().
                BuildConfiguration();
            return config.BuildSessionFactory();

        }
    }
}