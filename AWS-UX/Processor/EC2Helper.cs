using AutoMapper;
using AWS_UX.Models;
using System.Collections.Generic;

namespace AWS_UX.Processor
{
    public class EC2Helper : IEC2Helper
    {
        public List<InstanceDetails> getAllTheInstance()
        {
            using (AWSService.AWSServiceClient aWSServiceClient= new AWSService.AWSServiceClient())
            {
                List<InstanceDetails> a = new List<InstanceDetails>();

                a.Add(Mapper.Map<AWSService.InstanceDetails, InstanceDetails>(aWSServiceClient.GetInstanceDetails("i-0de71ab2835ebc685")));

                return a;
            }
        }
    }
}