using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuckarooSdk.Services.Maestro
{
    class MaestroRefundResponse : ActionResponse
    {
        public override ServiceEnum ServiceEnum => ServiceEnum.Maestro;
    }
}
