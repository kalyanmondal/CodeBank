namespace AWS_EC2_StatusCheck.Models
{
    public class InstanceDetails
    {
        public string InstanceId { get; set; }

        public string InstanceState { get; set; }

        public string InstanceName { get; set; }

        public string InstanceStatus { get; set; }

        public string SystemState { get; set; }

        public string SystemName { get; set; }

        public string SystemStatus { get; set; }

        public string AvailablityZone { get; set; }
    }
}