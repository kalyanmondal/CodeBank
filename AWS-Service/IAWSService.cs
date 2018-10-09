using AWS_Service.Data;
using System.ServiceModel;

namespace AWS_Service
{
    [ServiceContract]
    public interface IAWSService
    {
        [OperationContract]
        InstanceDetails GetInstanceDetails(string instanceId);
    }
}
