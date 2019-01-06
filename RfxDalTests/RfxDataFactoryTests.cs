using Microsoft.VisualStudio.TestTools.UnitTesting;
using RfxDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RfxDal.Tests
{
    [TestClass()]
    public class RfxDataFactoryTests
    {
        [TestMethod()]
        public void GetAllTripsTest()
        {
            var trips = RfxDataFactory.GetAllTrips();
            Assert.IsNotNull(trips);
        }
    }
}