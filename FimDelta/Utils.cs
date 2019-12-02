using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FimDelta
{
    class Utils
    {
        public static string BrowseForFile(string Title)
        {
            string result = null;

            var FD = new System.Windows.Forms.OpenFileDialog();
            FD.Title = Title;
            FD.Filter = "XML Files (*.xml)|*.xml";
            FD.FilterIndex = 1;
            FD.Multiselect = false;
            FD.ShowDialog();
            result = FD.FileName;

            return result;
        }

        public static string BrowseForFolder(string Title)
        {
            string result = null;

            var FD = new FolderBrowserDialog();
            FD.ShowNewFolderButton = true;
            FD.ShowDialog();
            result = FD.SelectedPath;

            return result;
        }
    }
}
