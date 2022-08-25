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
        public static Dictionary<MapDifficulty, string> DiffStrings = new Dictionary<MapDifficulty, string> {
            {MapDifficulty.Easy,"Easy"},
            {MapDifficulty.Normal,"Normal"},
            {MapDifficulty.Hard,"Hard"},
            {MapDifficulty.Expert,"Expert"},
            {MapDifficulty.ExpertPlus,"ExpertPlus"}
        };
        public BeatEvaluator() {
            InitializeComponent();
        }

        private void EvaluateFolderButton_Click(object sender, EventArgs e) {
            if(EvalFolderDialog.ShowDialog() == DialogResult.OK) {
                EvaluateMap(EvalFolderDialog.SelectedPath + '\\');
            }
        }

        public void EvaluateMap(string DirectoryPath) { 
            MapInfoData Info = FileInterpreter.LoadInfoFile(DirectoryPath);
            //Evaluate each of the difficuties from the map
            bool AllMet = true;
            List<bool> Passed = new List<bool>();
            List<Criteria> Evaluations = new List<Criteria>();
            foreach(var MapDiff in Info.DiffPaths) {
                string DiffPath = DirectoryPath + MapDiff.Value;
                Criteria Evaluation = FileInterpreter.EvaluateMapDiff(Info, DiffPath, MapDiff.Key);
                Evaluations.Add(Evaluation);
                if(!Evaluation.PassedCriteria)
                    AllMet = false;
            }
            //Update the GUI
            TreeNode SongNode = QueueTree.Nodes.Add(Info.SongName);
            SongNode.ForeColor = AllMet ? Color.Green : Color.Red;
            foreach(Criteria eval in Evaluations) {
                TreeNode DiffNode = SongNode.Nodes.Add(DiffStrings[eval.Difficulty]);
                DiffNode.ForeColor = eval.PassedCriteria ? Color.Green : Color.Red;
            }
        }
    }
}
