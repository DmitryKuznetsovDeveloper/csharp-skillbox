using PracticalWork006.Interface;

namespace PracticalWork006
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IView view = new View();
            ControllerNotebook controllerNotebook = new ControllerNotebook(view);
            controllerNotebook.Start();
        }
    }
}
