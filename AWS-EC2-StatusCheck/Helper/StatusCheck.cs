using Amazon.EC2;
using Amazon.EC2.Model;
using Amazon.Runtime;
using AWS_EC2_StatusCheck.Models;
using System;

namespace AWS_EC2_StatusCheck.Helper
{
    public class StatusCheck
    {
        public InstanceDetails StatusCheckDetails(string instanceId)
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
            catch(Exception ex)
            {
                throw ex;
            }

            return instanceDetail;
        }

        public void Terminate(string instanceId)
        {
            var ec2Client = new AmazonEC2Client(Amazon.RegionEndpoint.USEast1);

            var deleteRequest = new TerminateInstancesRequest()
            {
                InstanceIds = { instanceId }
            };

            var deleteResponse = ec2Client.TerminateInstances(deleteRequest);

            foreach (InstanceStateChange item in deleteResponse.TerminatingInstances)
            {
                Console.WriteLine();
                Console.WriteLine("Terminated instance: " + item.InstanceId);
                Console.WriteLine("Instance state: " + item.CurrentState.Name);
            }
        }
    }
}