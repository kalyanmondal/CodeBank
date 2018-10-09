using Amazon.EC2;
using Amazon.EC2.Model;
using Amazon.Runtime;
using AWS_Service.Data;
using System;

namespace AWS_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class AWSService : IAWSService
    {
        public InstanceDetails GetInstanceDetails(string instanceId)
        {
            InstanceDetails instanceDetail = null;

            try
            {
                AWSCredentials credentials = new StoredProfileAWSCredentials("FirstProfile");

                var ec2Client = new AmazonEC2Client(credentials, Amazon.RegionEndpoint.USEast1);

                ////var ec2Client = new AmazonEC2Client(Amazon.RegionEndpoint.USEast1);

                var statusRequest = new DescribeInstanceStatusRequest
                {
                    InstanceIds = { instanceId }
                };



                var status = ec2Client.DescribeInstanceStatus(statusRequest).InstanceStatuses[0];

                instanceDetail = new InstanceDetails();

                instanceDetail.InstanceId = status.InstanceId;
                instanceDetail.InstanceState = status.InstanceState.Name;
                instanceDetail.InstanceName = status.Status.Details[0].Name;
                instanceDetail.InstanceStatus = status.Status.Details[0].Status;
                instanceDetail.SystemState = status.Status.Status.Value;
                instanceDetail.SystemName = status.SystemStatus.Details[0].Name;
                instanceDetail.SystemStatus = status.SystemStatus.Details[0].Status;
                instanceDetail.AvailablityZone = status.AvailabilityZone;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return instanceDetail;
        }
    }
}
