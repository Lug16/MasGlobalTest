using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobalTest.Tools.Configuration
{
    public interface IConfigHandler
    {
        T GetConfigValue<T>(string key) where T : class;
    }
}
