using AWS_UX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_UX.Processor
{
    interface IEC2Helper
    {
        List<InstanceDetails> getAllTheInstance();
    }
}
