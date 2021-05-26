using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using static Hl7.Fhir.Model.Device;

namespace MDE_project_Forms
{
    interface CommunicationInterface
    {

        void addDevice(string deviceName, string deviceType, DateTime expirationDate, string modelNumber, string lotNumber, string serialNumber);

        void addDevice(string deviceName, string deviceType, string serialNumber);

        int deleteDeviceByName(string name);

        void deleteDeviceByURL(string url);


        List<Device> getDevicesByName(string deviceName);
        List<Device> getDevicesByType(string deviceType);
        List<Device> getDevicesByExpirationDate(DateTime expirationDate);
        List<Device> getDevicesByModelNumber(string modelNumber);
    }
}
