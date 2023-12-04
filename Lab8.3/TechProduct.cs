using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._3
{
    class TechProduct
    {
        private IScreen _screen;
        private IProcessor _processor;
        private ICamera _camera;

        public TechProduct(IComponentFactory componentFactory)
        {
            _screen = componentFactory.CreateScreen();
            _processor = componentFactory.CreateProcessor();
            _camera = componentFactory.CreateCamera();
        }

        public void Assemble()
        {
            Console.WriteLine("Assembling:");
            _screen.Display();
            _processor.Process();
            _camera.Capture();
            Console.WriteLine("assembled.");
        }
    }
}
