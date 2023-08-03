using PracticalWork007.Interface;

namespace PracticalWork007
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
