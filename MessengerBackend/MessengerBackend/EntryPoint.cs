using MessengerBackend.ServiceSettings;

namespace MessengerBackend
{
    public class EntryPoint
    {
        public static void Main()
        {
            var settings = new MessengerServiceSettings();
            var server = new SimpleHTTPServer(settings.Folder, settings.Port);
        }
    }
}
