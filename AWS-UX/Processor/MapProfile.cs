using AutoMapper;
using AWS_UX.Models;

namespace AWS_UX.Processor
{
    public static class MapProfile
    {
        public static void RegisterMaps()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<AWSService.InstanceDetails, InstanceDetails>();
            });
        }
    }
}