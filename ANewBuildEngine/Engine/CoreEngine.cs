using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANewBuildEngine.Engine
{
    class CoreEngine
    {
        public void DoStuff()
        {
            var f = new FeatureA();
            var f1 = new FeatureB();
            var f2 = new FeatureC();

            f.ExecuteFeature();
            f1.ExecuteFeature();
            f2.ExecuteFeature();
        }
    }
}
