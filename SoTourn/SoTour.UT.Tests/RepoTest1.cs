using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoTour.Core.Contracts;
using SoTour.Core.Models;
using SoTour.DataAccess.Repository;

namespace SoTour.UT.Tests
{
    [TestClass]
    public class RepoTest1
    {
        private IRepository _repository;

        [TestInitialize]
        public void Initialize()
        {
            _repository = new SoTourRepository();
        }

        [TestMethod]
        public void Quertyat_team_point()
        {
            var list = _repository.All<team_points>().ToList();
            foreach (var item in list)
            {
                Trace.TraceInformation("Team pooints name : {0}", item.name);
            }
        }
    }
}
