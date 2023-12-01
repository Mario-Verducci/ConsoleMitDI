using Autofac;
using ConsoleMitDI.Services;

namespace ConsoleMitDI
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = GetContainer();

            using (var scope = container.BeginLifetimeScope())
            {
                using (var form = scope.Resolve<Form1>())
                {
                    form.ShowDialog();
                }
            }

            IContainer GetContainer()
            {
                var builder = new ContainerBuilder();
                builder.RegisterType<Database>().As<IDatabase>();
                builder.RegisterType<SayHello>().As<ISayHello>();
                builder.RegisterType<Form1>();

                return builder.Build();
            }
        }
    }
}