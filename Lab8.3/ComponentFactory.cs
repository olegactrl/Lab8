using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._3
{
    class ComponentFactory : IComponentFactory
    {
        public IScreen CreateScreen()
        {
            return new AMOLED();
        }

        public IProcessor CreateProcessor()
        {
            return new Exynos();
        }

        public ICamera CreateCamera()
        {
            return new DualCamera();
        }
    }
}
