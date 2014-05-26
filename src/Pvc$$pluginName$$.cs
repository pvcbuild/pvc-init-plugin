using PvcCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PvcPlugins
{
    public class Pvc$$pluginName$$ : PvcPlugin
    {
        public Pvc$$pluginName$$()
        {
            // Plugin setup
        }

        public override IEnumerable<PvcStream> Execute(IEnumerable<PvcStream> inputStreams)
        {
            foreach (var inputStream in inputStreams)
            {
                // Plugin actions.
            };
            return inputStreams;
        }
    }
}
