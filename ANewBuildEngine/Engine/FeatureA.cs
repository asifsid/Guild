using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANewBuildEngine.Engine
{
    class FeatureA
    {
        public void ExecuteFeature()
        {
            if (Tools.Utilities.SomeUtilWasNeeded("magic"))
            {
                // This is the conetent of the feature.
                // Lot of magic here
            }
        }

    }
}
