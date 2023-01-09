using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Delegate_Collections.Exeptions
{
    public class InvaliLoginException:Exception
    {
        public InvaliLoginException(string message):base(message) { }
    }
}
