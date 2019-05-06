using System;
using System.Windows.Forms;
using Autofac;
using MarsExplorer.Business;
using MarsExplorer.Resource;

namespace MarsExplorer.Panel
{
    public partial class TestPanel : Form
    {
        public TestPanel()
        {
            InitializeComponent();
            txtCommadPanel.Text = Resource.Resource.PanelFirstMessage;

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

        private new static IContainer Container { get; set; }

        private void btnSendCommand_Click(object sender, EventArgs e)
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                txtResults.Text = string.Empty;

                var service = scope.Resolve<IParser>();

                var platau = service.ParseMessage(txtCommadPanel.Text);

                if (platau == null || platau.RoverCommanders.Count < 1)
                {
                    return;
                }

                if (platau.RoverCommanders.Count < 1)
                    return;

                foreach (var commander in platau.RoverCommanders)
                {
                    foreach (var cmd in commander.CommandLine)
                    {
                        commander.Rover.Execute(cmd);
                        txtResults.Text += commander.Rover.Name + Resource.Resource.RoverSeparator + commander.Rover.GetPosition() + System.Environment.NewLine;
                    }
                    txtResults.Text += Environment.NewLine;
                } 
            }
        }
    }
}
