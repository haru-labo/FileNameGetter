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
            e.Effect = DragDropEffects.Copy;
        }

        //ドロップ時の処理
        private void FileNameGetter_DragDrop(object sender, DragEventArgs e)
        {
            //ドロップ時にテキストボックス内をクリア
            textBox.Clear();

            //ドロップアイテム全てのパスを配列に取得
            string[] dropItemPath = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            string[] files;

            //ドロップアイテム個々のパスを取得
            foreach (string dropItem in dropItemPath)
            {                
                //ドロップがディレクトリの場合
                if (System.IO.Directory.Exists(dropItem))
                {
                    //該当フォルダ名を表示
                    textBox.AppendText("【表示フォルダ：" + System.IO.Path.GetFileName(dropItem) + "】");

                    //サブフォルダの検索設定
                    if (serchSubDir.Checked) { 
                        files = System.IO.Directory.GetFiles(@dropItem, "*", System.IO.SearchOption.AllDirectories);
                    } else {
                        files = System.IO.Directory.GetFiles(@dropItem, "*", System.IO.SearchOption.TopDirectoryOnly);
                    }
                    
                    //ファイルパスからファイル名を取得し、テキストボックスに追加
                    foreach (string fileName in files)
                    {
                            textBox.AppendText("\r\n" + System.IO.Path.GetFileName(fileName));
                    }

                    //サブフォルダ表示チェックあり
                    if (showSubDirName.Checked) {
                        //サブフォルダ名を取得
                        IEnumerable<string> directryNames = System.IO.Directory.EnumerateDirectories(@dropItem, "*", System.IO.SearchOption.TopDirectoryOnly);

                        //サブフォルダ名を《》で囲み表示
                        foreach (string subDirName in directryNames)
                        {
                            textBox.AppendText("\r\n《" + System.IO.Path.GetFileName(subDirName) + "》");
                        }

                    }

                }
                //ドロップがディレクトリ以外
                else
                {
                    textBox.AppendText("【ファイル単独】\r\n" + System.IO.Path.GetFileName(dropItem) + "\r\n\r\n");
                }
                    
            }

        }   
    }
}
