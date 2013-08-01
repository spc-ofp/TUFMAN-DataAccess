using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TUFMAN_DAL_Tests.Configuration;
using TUFMAN_DAL_Tests.Repositories;
using System.Collections.Generic;
using System.Linq;
using HibernatingRhinos.Profiler.Appender.NHibernate;
using NHibernate;
using TUFMAN.Domain.Log;
using TUFMAN.Domain.Ves;
using TUFMAN.Domain.Ref;

namespace TUFMAN_DAL_Tests
{
    [TestClass]
    public class TUFMANTests
    {
        [TestMethod]
        public void TestVesselCount()
        {
            UnitOfWork unitOfWork = new UnitOfWork(NHibernateHelper.SessionFactory);
            Repository repo = new Repository(unitOfWork.Session);

            List<TUFMAN.Domain.Ves.Vessels> list = repo.GetAll<TUFMAN.Domain.Ves.Vessels>().ToList();
            Assert.IsTrue(list.Count > 0);
            unitOfWork.Rollback();

        }

        [TestMethod]
        public void TestVesselFlags1()
        {
            NHibernateProfiler.Initialize();

            List<System.Collections.DictionaryEntry> flagList;
            UnitOfWork unitOfWork = new UnitOfWork(NHibernateHelper.SessionFactory);
            Repository repo = new Repository(unitOfWork.Session);

            flagList = repo.GetAll<TUFMAN.Domain.Log.TripsLL>().Select(x => new System.Collections.DictionaryEntry { Key = x.vessels.flag_country.country_code, Value = x.vessels.flag_country.country_name }).Distinct().OrderBy(x => x.Value).ToList();
            Assert.IsTrue( flagList.Count > 0);
            unitOfWork.Rollback();
        }

        [TestMethod]
        public void TestVesselFlagsQueryOver()
        {
            NHibernateProfiler.Initialize();

            //List<System.Collections.DictionaryEntry> flagList;
            UnitOfWork unitOfWork = new UnitOfWork(NHibernateHelper.SessionFactory);
            Repository repo = new Repository(unitOfWork.Session);

            // seems too complicated with numerous joins
            // refer to http://stackoverflow.com/questions/10314861/queryover-how-to-select-only-one-object-from-a-join-of-three-tables for how to do it

            TripsLL tt = null;
            Vessels vv = null;
            Countries cc = null;

            unitOfWork.Session.QueryOver<TripsLL>(() => tt)
                .Inner.JoinAlias(() => tt.vessels, () => vv)
                .Inner.JoinAlias(() => vv.flag_country, () => cc)
                .List();

            //var flaglist = unitOfWork.Session.QueryOver<Countries>(() => cc)
            //    .Inner.JoinAlias(() => vv.flag_country, () => vv)
            //    .Inner.JoinAlias(() => tt.vessels, () => tt)
            //    .List();

            //        .Inner<TUFMAN.Domain.Log.TripsLL>(c => c.vessel_id)
            //        .Select(c => c.vessel_id);
            
            //flagList = repo.GetAll<TUFMAN.Domain.Log.TripsLL>().Select(x => new System.Collections.DictionaryEntry { Key = x.vessels.flag_code, Value = x.vessels.flag_country.country_name }).Distinct().OrderBy(x => x.Value).ToList();
            //Assert.IsTrue(flagList.Count > 0);
            unitOfWork.Rollback();
        }

        [TestMethod]
        public void TestVesselFlagsHQL()
        {
            NHibernateProfiler.Initialize();

            //List<System.Collections.DictionaryEntry> flagList;
            UnitOfWork unitOfWork = new UnitOfWork(NHibernateHelper.SessionFactory);
            Repository repo = new Repository(unitOfWork.Session);

            //IQuery query = unitOfWork.Session.CreateQuery("Select distinct vessel_id from TripsLL");
            //IQuery query = unitOfWork.Session.CreateQuery("Select distinct v.vessel_id from TripsLL t,Vessels v where v.vessel_id = t.vessel_id");
            //IQuery query = unitOfWork.Session.CreateQuery("Select distinct v.vessel_id from TripsLL as t inner join t.vessels as v");

            IQuery query = unitOfWork.Session.CreateQuery("Select distinct c.country_code,c.country_name from TripsLL as t inner join t.vessels as v inner join v.flag_country c");

            List<System.Collections.DictionaryEntry> flaglist = (from object[] x in query.List()
                           select new System.Collections.DictionaryEntry { Key = x[0], Value = x[1]}).ToList();

       

            //flagList = repo.GetAll<TUFMAN.Domain.Log.TripsLL>().Select(x => new System.Collections.DictionaryEntry { Key = x.vessels.flag_code, Value = x.vessels.flag_country.country_name }).Distinct().OrderBy(x => x.Value).ToList();
            //Assert.IsTrue(query.List().Count > 0);
            Assert.IsTrue(flaglist.Count > 0);

            unitOfWork.Rollback();
        }

        [TestMethod]
        public void TestVesselFlagsSQL()
        {
            NHibernateProfiler.Initialize();
            string sql;
            //object testList;

            //List<System.Collections.Generic.KeyValuePair<string,string>> fff;
            //List<System.Collections.DictionaryEntry> flagList;
            UnitOfWork unitOfWork = new UnitOfWork(NHibernateHelper.SessionFactory);
            Repository repo = new Repository(unitOfWork.Session);

            sql = "Select distinct c.country_code,c.country_name from log.Trips_LL as t inner join ves.vessels as v on t.vessel_id = v.vessel_id inner join ref.countries c on c.country_code = v.flag_code";
            IQuery query = unitOfWork.Session.CreateSQLQuery(sql);

            List<System.Collections.DictionaryEntry> flaglist = (from object[] x in query.List()
                                                                 select new System.Collections.DictionaryEntry { Key = x[0], Value = x[1] }).ToList();

            //testList =query.List();
            //flagList = query.List<System.Collections.DictionaryEntry>();

            Assert.IsTrue(flaglist.Count > 0);
            unitOfWork.Rollback();
        }
    }
}
