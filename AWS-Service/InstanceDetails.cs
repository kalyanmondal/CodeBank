using System.Runtime.Serialization;

namespace AWS_Service.Data
{
    [DataContract]
    public class InstanceDetails
    {
        [DataMember]
        public string InstanceId { get; set; }

        [DataMember]
        public string InstanceState { get; set; }

        [DataMember]
        public string InstanceName { get; set; }

        [DataMember]
        public string InstanceStatus { get; set; }

        [DataMember]
        public string SystemState { get; set; }

        [DataMember]
        public string SystemName { get; set; }

        [DataMember]
        public string SystemStatus { get; set; }

        [DataMember]
        public string AvailablityZone { get; set; }
    }
}