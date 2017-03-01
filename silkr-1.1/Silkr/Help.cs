using System.IO;
using System.Windows.Forms;

namespace Silkr {
    public partial class Help : Form {
        public Help() {
            InitializeComponent();
            try {
                string html = File.ReadAllText("Silkr Help.html");
                webBrowser.DocumentText = html;
            }
            catch {
                webBrowser.Visible = false;
                label1.Visible = true;
            }
        }
    }
}
