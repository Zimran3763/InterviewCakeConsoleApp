using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    public class Parser 
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DNSName { get; set; }
        public int timeToLive { get; set; }
        public int ClusterSize { get; set; }
        public int PortNumber { get; set; }
        public bool IsEnabled { get; set; }
        public bool EnsureTransaction { get; set; }
        public bool PersistentStorage { get; set; }
        /*
        Here is an example input configuration to parse:

        UserName:admin;
        Password:""super%^&*333password;
        DNSName:SomeName;

        TimeToLive:4;
        ClusterSize:2;
        PortNumber:2222;

        IsEnabled:true;
        EnsureTransaction:false;
        PersistentStorage:false;
        */
        public dynamic Parse(string configuration)
        {
            Dictionary<string, string> stringParser = new Dictionary<string, string>();
            int index = configuration.LastIndexOf(';');
            string newString = configuration.Remove(index,1);
            if (configuration != null)
            {
                foreach (string val in newString.Split(';'))
                {
                    string[] valuesInTheString = val.Split(':');
                    stringParser.Add(valuesInTheString[0], valuesInTheString[1]);
                }
                var par = new Parser();
                par.UserName = stringParser["UserName"];
                par.Password = stringParser["Password"];
                par.DNSName = stringParser["DNSName"];
                string timetolive = stringParser["TimeToLive"];
                par.timeToLive = Int32.Parse(timetolive);
                string clusterSize = stringParser["ClusterSize"];
                par.ClusterSize = Int32.Parse(clusterSize);
                string portNumber = stringParser["PortNumber"];
                par.PortNumber = Int32.Parse(portNumber);
                string isEnabled = stringParser["IsEnabled"];
                par.IsEnabled = bool.Parse(isEnabled);
                string ensureTransaction = stringParser["EnsureTransaction"];
                par.EnsureTransaction = bool.Parse(ensureTransaction);
                string persistentStorage = stringParser["PersistentStorage"];
                par.PersistentStorage = bool.Parse(persistentStorage);
                return par;

            }
            else
            {
                throw new ArgumentException("EmptyString");
            }
            throw new NotImplementedException();
        }
    }

}

