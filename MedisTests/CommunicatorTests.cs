using Microsoft.VisualStudio.TestTools.UnitTesting;
using MDE_project_Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDE_project_Forms.Tests
{
    [TestClass()]
    public class CommunicatorTests
    {
        string fihrUrl = "https://fhir.ls.technikum-wien.at/fhir";
        string FihrUrlHttp = "https://fhir.ls.technikum-wien.at/fhir";
        string FihrUrlWrong = "https://orf.at";
        string FihrUrlNoUrl = "test";

        string deviceName = "";
        string deviceType = "";
        DateTime expirationDate;
        string modelNumber = "";
        string lotNumber = "";
        string serialNumber = "";

        [TestMethod()]
        public void CommunicatorTestCorrectUrl()
        {
            try
            {
                new Communicator(fihrUrl);
                Assert.Fail();
            }
            catch (Exception)
            {
            }
            
        }

        [TestMethod()]
        public void CommunicatorTestUrlOnlyHttp()
        {
            try
            {
                new Communicator(FihrUrlHttp);
                Assert.Fail();
            }
            catch (Exception)
            {
            }

        }

        [TestMethod()]
        public void addDeviceTestCorrect()
        {
            try
            {
                new Communicator(fihrUrl).addDevice(deviceName, deviceType, expirationDate, modelNumber, lotNumber, serialNumber);
            }
            catch (Exception)
            {
            }
        }

        [TestMethod()]
        public void addDeviceTestCorrect()
        {
            try
            {
                new Communicator(fihrUrl).addDevice(deviceName, deviceType, expirationDate, modelNumber, lotNumber, serialNumber);
            }
            catch (Exception)
            {
            }
        }

        [TestMethod()]
        public void addDeviceTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getDevicesByExpirationDateTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getDevicesByModelNumberTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getDevicesByNameTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getDevicesByTypeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void deleteDeviceByURLTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void deleteDeviceByNameTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void bundleToListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void dateToStringTest()
        {
            Assert.Fail();
        }
    }
}