using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

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

        private Dictionary<TreeNode, MapNode> QueueData = new Dictionary<TreeNode, MapNode>();
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
                if(Evaluation.CriteriaPass != Criteria.AllMet)
                    AllMet = false;
            }
            //Update the GUI
            TreeNode SongNode = QueueTree.Nodes.Add($"{QueueTree.GetNodeCount(false)}: {Info.SongName}");
            SongNode.ForeColor = AllMet ? Color.Green : Color.Red;
            foreach(Criteria eval in Evaluations) {
                TreeNode DiffNode = SongNode.Nodes.Add(DiffStrings[eval.Difficulty]);
                DiffNode.ForeColor = (eval.CriteriaPass == Criteria.AllMet) ? Color.Green : Color.Red;
            }

            MapNode EvalInfo = new MapNode();
            EvalInfo.LoadPath = DirectoryPath;
            EvalInfo.Info = Info;
            EvalInfo.DiffCriteria = Evaluations;
            QueueData.Add(SongNode, EvalInfo);
        }

        //Hopefully this makes no one let me do UI ever again. :)
        private void OnQueueSelection(object sender, TreeViewEventArgs e) {
            bool isParent = QueueData.ContainsKey(e.Node);
            MapNode NodeData = QueueData[isParent? e.Node : e.Node.Parent];
            MapImage.ImageLocation = NodeData.Info.FolderPath + NodeData.Info.CoverImage;

            MapImage.Visible = true;
            MapTitle.Visible = true;
            MapMetrics.Visible = !isParent;
            if(isParent) {
                MapTitle.Text = $"{NodeData.Info.SongName} - {NodeData.Info.LevelAuthor}";
            } else {
                Criteria crit = NodeData.DiffCriteria[e.Node.Index];
                MapTitle.Text = $"{NodeData.Info.SongName} - {DiffStrings[crit.Difficulty]}";

                //Colouring
                for(int i = 0; i < MapMetrics.GetNodeCount(false); i++) {
                    bool pass = (((int)crit.CriteriaPass>>i)&1) == 1;
                    MapMetrics.Nodes[i].ForeColor = pass?Color.Green:Color.Red;
                }

                MapMetrics.Nodes[0].Text = $"Hot Start: {crit.HotStart.ToString("0.00")} seconds";
                MapMetrics.Nodes[1].Text = $"Cold End: {crit.ColdEnd.ToString("0.00")} seconds";

                FillLine(MapMetrics.Nodes[2], "Note Overlaps", crit.NoteOverlaps);
                FillLine(MapMetrics.Nodes[3], "Wall Width", crit.WallWidth);
                FillLine(MapMetrics.Nodes[4], "Wall Duration", crit.WallDuration);
                FillLine(MapMetrics.Nodes[5], "Wall Minimum Duration", crit.WallMinDuration);
                GC.Collect();
            }
        }

        private void FillLine(TreeNode Node, string Label, List<float> Values) {
            Node.Nodes.Clear();
            Node.Text = $"{Label}: {Values.Count}";
            for(int i = 0; i < Values.Count; i++) {
                Node.Nodes.Add($"{i}: {Values[i]} Seconds");
            }
        }
    }
}
