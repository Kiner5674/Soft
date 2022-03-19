using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Soft
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Temp_Delete_Click(object sender, EventArgs e)
        {
            try 
            {
                System.IO.Directory.Delete(@"C:\Windows\Temp",true);
            }
            catch (System.UnauthorizedAccessException)
            {

            }
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
