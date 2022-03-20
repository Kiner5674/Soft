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
                System.IO.Directory.Delete(@"C:\Windows\Temp", true);
            }
            catch (System.UnauthorizedAccessException) //管理者権限ないとき
            {
                MessageBox.Show(
                    "アクセス権限ないよ。(UnauthorizedAccessException)\n\n対処法:管理者権限で起動する。",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (System.IO.IOException) //ファイルがロックされているとき(一部)
            {
                MessageBox.Show("I/Oエラーが起きたよ(IOException)\n\n対処法:しばらく待つかPCを再起動してみましょう。", 
                    "エラー", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void Folder_Delete_Click(object sender, EventArgs e)
        {
            //参考:https://dobon.net/vb/dotnet/form/folderdialog.html
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "削除するフォルダを指定してください。";
            folderBrowserDialog.ShowNewFolderButton = false;
            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                DialogResult dialogresult = MessageBox.Show(folderBrowserDialog.SelectedPath + "を削除しますか?", 
                    "確認", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Information);
                if (dialogresult == DialogResult.Yes)
                {
                    System.IO.Directory.Delete(folderBrowserDialog.SelectedPath);
                }
            }

        }
    }
}
