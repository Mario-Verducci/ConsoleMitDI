using ConsoleMitDI.Services;
using Unity;

namespace ConsoleMitDI
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = GetServices();

            using (var form = container.Resolve<Form1, Options>(new Options { ConnectionString = "123 abc Datenbank" }))
            {
                form.ShowDialog();
            }

            UnityContainer GetServices()
            {
                var services = new UnityContainer();
                services.RegisterType<IDatabase, Database>();
                services.RegisterType<ISayHello, SayHello>();
                services.RegisterType<Form1>();

                return services;
            }
        }
    }
}