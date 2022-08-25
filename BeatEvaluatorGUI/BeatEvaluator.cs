using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeatEvaluatorGUI
{
    public partial class BeatEvaluator : Form
    {
        public BeatEvaluator() {
            InitializeComponent();
        }

        private void EvaluateFolderButton_Click(object sender, EventArgs e) {
            if(EvalFolderDialog.ShowDialog() == DialogResult.OK) {
                string FolderPath = EvalFolderDialog.SelectedPath + '\\';

                MapInfoData Info = FileInterpreter.LoadInfoFile(FolderPath);
                foreach(var MapDiff in Info.DiffPaths) {
                    string DiffPath = FolderPath + MapDiff.Value;
                    FileInterpreter.EvaluateMapDiff(Info, DiffPath, MapDiff.Key);
                }
            }
        }
    }
}
