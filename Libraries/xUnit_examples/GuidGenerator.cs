using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnit_examples
{
    public class GuidGenerator
    {
        public Guid RandomGuid { get; } = Guid.NewGuid();
    }
}
