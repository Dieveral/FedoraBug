using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace FedoraBug.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new FedoraBug.App(), args);
            host.Run();
        }
    }
}
