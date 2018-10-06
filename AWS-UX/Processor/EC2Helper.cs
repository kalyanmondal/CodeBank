using AWS_UX.Models;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace AWS_UX.Processor
{
    public class EC2Helper : IEC2Helper
    {
        public List<InstanceDetails> getAllTheInstance()
        {
            using (AWSService.AWSServiceClient aWSServiceClient= new AWSService.AWSServiceClient())
            {
                

                new List<InstanceDetails>().Add(aWSServiceClient.GetInstanceDetails("i-0602ddcf7c609a564"));
            }
        }
    }
}