using System.ComponentModel;
using System.Configuration.Install;

namespace SymbioteProcessService
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
        }

        private void SymbioteProcessServiceInstaller_AfterInstall(object sender, InstallEventArgs e)
        {

        }
    }
}
