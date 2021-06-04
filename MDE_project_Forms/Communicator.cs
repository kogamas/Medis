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
    public class Communicator : CommunicationInterface
    {
        FhirClient client;

        public Communicator(string url)
        {
            client = new FhirClient(url);
        }

        public void addDevice(string deviceName, string deviceType, DateTime expirationDate, string modelNumber, string lotNumber, string serialNumber)
        {
            Device device = new Device();

            DeviceNameComponent name = new DeviceNameComponent();
            name.Name = deviceName;
            device.DeviceName.Add(name);

            device.Type = new CodeableConcept();
            device.Type.Text = deviceType;

            //new DateTime(2021,05,24)
            device.ExpirationDate = dateToString(expirationDate);

            device.ModelNumber = modelNumber;
            device.LotNumber = lotNumber;
            device.SerialNumber = serialNumber;

            Device test = client.Create<Device>(device);
        }

        public void addDevice(string deviceName, string deviceType, string serialNumber)
        {
            Device device = new Device();

            DeviceNameComponent name = new DeviceNameComponent();
            name.Name = deviceName;
            device.DeviceName.Add(name);

            device.Type = new CodeableConcept();
            device.Type.Text = deviceType;

            //Eventuelle Überprüfung auf Format
            device.SerialNumber = serialNumber;

            Device test = client.Create<Device>(device);
        }


        public List<Device> getDevicesByExpirationDate(DateTime expirationDate)
        {
            Bundle results = client.Search<Device>(null);
            List<Device> list = new List<Device>();

            for (int i = 0; i < results.Entry.Count; i++)
            {
                if ((results.Entry[i].Resource as Device).ExpirationDate != null && (results.Entry[i].Resource as Device).ExpirationDate.Equals(dateToString(expirationDate)))
                    list.Add(results.Entry[i].Resource as Device);
            }
            return list;
        }

        public List<Device> getDevicesByModelNumber(string modelNumber)
        {
            string req = "model=" + modelNumber;

            Bundle results = client.Search<Device>(new string[] { req });
            List<Device> list = new List<Device>();

            for (int i = 0; i < results.Entry.Count; i++)
            {
                list.Add(results.Entry[i].Resource as Device);
            }
            return list;
        }

        public List<Device> getDevicesByName(string deviceName)
        {
            string req = "device-name=" + deviceName;

            Bundle results = client.Search<Device>(new string[] { req });
            List<Device> list = new List<Device>();

            for (int i = 0; i < results.Entry.Count; i++)
            {
                list.Add(results.Entry[i].Resource as Device);
            }
            return list;
        }

        public List<Device> getDevicesByType(string deviceType)
        {
            string req = "type:text=" + deviceType;

            Bundle results = client.Search<Device>(new string[] { req });
            List<Device> list = new List<Device>();

            for (int i = 0; i < results.Entry.Count; i++)
            {
                list.Add(results.Entry[i].Resource as Device);
            }
            return list;
        }

        public void deleteDeviceByURL(string url)
        {
            client.Delete(new Uri(url));
        }

        //returns number of deleted devices
        public int deleteDeviceByName(string name)
        {
            Bundle results = client.Search<Device>(new string[] { "device-name=" + name });

            for (int i = 0; i < results.Entry.Count; i++)
            {
                client.Delete(new Uri(results.Entry[i].FullUrl));
            }
            return results.Entry.Count;
        }

        public List<Device> bundleToList(Bundle bundle)
        {
            List<Device> list = new List<Device>();
            if (bundle.Entry.Count > 0)
            {
                for (int i = 0; i < bundle.Entry.Count; i++)
                {
                    list.Add(bundle.Entry[i].Resource as Device);
                }
            }
            return list;
        }

        public string dateToString(DateTime date)
        {
            string str = date.Year.ToString();
            if (date.Month < 10)
                str += "-0" + date.Month;
            else
                str += "-" + date.Month;

            if (date.Day < 10)
                str += "-0" + date.Day;
            else
                str += "-" + date.Day;
            return str;
        }
    }
}
