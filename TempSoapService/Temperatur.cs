using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TempSoapService
{
    [DataContract]
   public class Temperatur
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public DateTime DatoTid { get; set; }

        [DataMember]
        public string Sted { get; set; }

        [DataMember]
        public bool Inde { get; set; }

        [DataMember]
        public bool Ude { get; set; }

        [DataMember]
        public float Temp { get; set; }

        [DataMember]
        public string Kommentar { get; set; }
    }
}
