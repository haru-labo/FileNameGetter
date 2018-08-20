using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileNameGetter
{
    public partial class FileNameGetter : Form
    {
        public FileNameGetter()
        {
            InitializeComponent();
        }

        //読み込み時にテキストボックス内をクリア
        private void FileNameGetter_Load(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        //フォーム内にドラッグしたときのエフェクト
        private void FileNameGetter_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        //ドロップ時の処理
        private void FileNameGetter_DragDrop(object sender, DragEventArgs e)
        {
            //ドロップ時にテキストボックス内をクリア
            textBox.Clear();

            //ドロップされたディレクトリのパスを取得
            string[] dirPath = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            //ディレクトリ内のファイルパスを取得
            foreach (string dir in dirPath)
            {
                string[] files = System.IO.Directory.GetFiles(dir, "*", System.IO.SearchOption.TopDirectoryOnly);
                
                //ファイルパスからファイル名を取得し、テキストボックスに追加
                foreach (string fileName in files)
                {
                    textBox.AppendText(System.IO.Path.GetFileName(fileName) + "\r\n");
                }

            }

        }   
    }
}
