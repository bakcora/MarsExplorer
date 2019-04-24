using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Autofac;
using MarsExplorer.Business;
using System.Text;
using System.Diagnostics;
using MarsExplorer.Global.Exception;

namespace MarsExplorer.Test
{
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Explorer>()
               .As(typeof(IExplorer))
               .InstancePerDependency();

            builder.RegisterType<Command>()
               .As(typeof(ICommand))
               .InstancePerDependency();

            builder.RegisterType<ExplorerCommand>()
                           .As(typeof(ICommand))
                           .InstancePerDependency();

            builder.RegisterType<Parser>()
                         .As(typeof(IParser))
                         .InstancePerDependency();

            builder.RegisterType<Plateau>()
                         .As(typeof(IPlateau))
                         .InstancePerDependency();

            builder.RegisterType<Rover>()
                         .As(typeof(IRover))
                         .InstancePerDependency();

            builder.RegisterType<RoverCommander>()
                         .As(typeof(IRoverCommander))
                         .InstancePerDependency();

            Container = builder.Build();

        }

        private static IContainer Container { get; set; }

        [TestMethod]
        public void TestRovers()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                var service = scope.Resolve<IParser>();

                var platau = service.ParseMessage(Resource.Resource.PanelFirstMessage);

                if (platau == null || platau.RoverCommanders.Count < 1)
                {
                    throw new BusinessException("RoverCommanders.Count < 1");
                }

                if (platau.RoverCommanders.Count < 1)
                    throw new BusinessException("RoverCommanders.Count < 1");

                var sb = new StringBuilder();

                foreach (var commander in platau.RoverCommanders)
                {
                    foreach (var cmd in commander.CommandLine)
                    {
                        commander.Rover.Execute(cmd);
                        sb.Append(commander.Rover.Name + Resource.Resource.RoverSeparator + commander.Rover.GetPosition() + System.Environment.NewLine);
                    }
                    sb.Append(Environment.NewLine);
                }
                
                Debug.Write(sb.ToString());
            }
        }
    }
}
