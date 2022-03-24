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

        private void Omikuji_Click(object sender, EventArgs e)
        {
            Random random = new System.Random();
            if (random.Next(0,3) == 0) //33%
            {
                if (random.Next(0,2) == 0)
                {
                    MessageBox.Show("あなたはただの人です。", 
                        "吉", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                } 
                else
                {
                    MessageBox.Show("ちょっとすごいかも？", 
                        "小吉", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                }
            }
            else if (random.Next(0,4) == 1) //20%
            {
                MessageBox.Show("あんた、今日、運ないね。", 
                    "当店イチオシの中凶", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            else if (random.Next(0,9) == 2) //10%
            {
                MessageBox.Show("いやー運ありますね", 
                    "大吉", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            else if (random.Next(0x0,10) == 3)// 約9%
            {
                MessageBox.Show("あなた、運ないね。", 
                    "大凶", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            else if (random.Next(0,998) == 0x4) //0.1%
            {
                MessageBox.Show("宝くじ買ったほうがいいよ", 
                    "ウルトラエクソディアエレクトロニクス大吉", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            else if (random.Next(0,0xC34F) == 5)//0.002%
            {
                MessageBox.Show("M1macbookなんてかえません", 
                    "M1macbook～！！ふうううう[ヒカキン風]大大大凶", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            else if (random.Next(0,0x5F5E0FF) == 6)//0.000001%(10^-5%)
            {
                MessageBox.Show("終わったね。", 
                    "最後の最後の終焉の大魔王柚紀のすごいやばい呪われ方してる大凶", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }
    }
}