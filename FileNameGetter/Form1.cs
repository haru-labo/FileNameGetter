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

            
            //ドロップアイテム個々のパスを取得
            foreach (string dropItem in dropItemPath)
            {                
                //ドロップがディレクトリの場合
                if (System.IO.Directory.Exists(dropItem))
                {
                    string dirName = System.IO.Path.GetFileName(dropItem);
                    //該当フォルダ名を表示
                    textBox.AppendText($"【表示フォルダ：{dirName}】\r\n");

                    //トップディレクトリのファイルを表示
                    AppendFileNames(dropItem);

                    //サブフォルダとファイルをすべて表示
                    if (showSubDirName.Checked && searchSubDir.Checked){
                        AppendAllSubDirAndFileNames(dropItem);
                    }
                    //サブフォルダ名のみ表示   
                    else if (showSubDirName.Checked){   
                       AppendSubDirNames(dropItem);
                    }
                    //ファイルのみ全て表示
                    else if (searchSubDir.Checked){
                        AppendAllFileNames(dropItem);
                    }

                }
                //ドロップがディレクトリ以外
                else
                {
                    string fileName = System.IO.Path.GetFileName(dropItem);
                    textBox.AppendText($"【ファイル単独】\r\n{fileName}\r\n");
                }
            }

        } 
        
        private void AppendAllFileNames(string dirPath,int indentLevel = 0)
        {
            string[] directories = System.IO.Directory.GetDirectories(dirPath,"*",System.IO.SearchOption.TopDirectoryOnly);
            foreach (string directoryPath in directories){
                AppendFileNames(directoryPath,indentLevel);
                if (System.IO.Directory.Exists(directoryPath)){
                    AppendAllFileNames(directoryPath,indentLevel);
                }
            }
        }

        private void AppendAllSubDirAndFileNames(string dirPath,int indentLevel = 1)
        {
            string[] directories = System.IO.Directory.GetDirectories(dirPath,"*",System.IO.SearchOption.TopDirectoryOnly);
            foreach (string directoryPath in directories){
                AppendDirName(directoryPath,indentLevel);
                AppendFileNames(directoryPath,indentLevel);
                if (System.IO.Directory.Exists(directoryPath)){
                    indentLevel ++;
                    AppendAllSubDirAndFileNames(directoryPath,indentLevel);
                }
            }
        }

        private void AppendDirName(string dirPath,int indentLevel)
        {
            string dirName = System.IO.Path.GetFileName(dirPath);
         　 textBox.AppendText($"{AddIndent(indentLevel)}/{dirName}/\r\n");
        }

        private void AppendFileNames(string dirPath,int indentLevel = 0)
        {
            string[] files = System.IO.Directory.GetFiles(dirPath, "*", System.IO.SearchOption.TopDirectoryOnly);
            foreach (string file in files)
            {
                string fileName = System.IO.Path.GetFileName(file);
                textBox.AppendText($"{AddIndent(indentLevel + 1)}{fileName}\r\n");
            }
        }

        private void AppendSubDirNames(string dirPath)
        {
            IEnumerable<string> directories = System.IO.Directory.EnumerateDirectories(dirPath, "*", System.IO.SearchOption.TopDirectoryOnly);
            foreach (string subDir in directories)
            {
                string dirName = System.IO.Path.GetFileName(subDir);
         　     textBox.AppendText($"{AddIndent(1)}/{dirName}/\r\n");
            }
        }

        private string AddIndent(int indentLevel)
        {
            var indent = new string(' ',indentLevel * 4);
            return indent;
        }

    }
}
