using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ushanka.GitHubUpdate
{
    public partial class UpdateForm : Form
    {
        private UpdateChecker updateChecker;

        public UpdateForm(UpdateChecker checker)
        {
            this.updateChecker = checker;

            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            this.label1.Text = updateChecker.UpdateData.Name;
            this.label2.Text = updateChecker.UpdateData.Body;
        }
    }
}
