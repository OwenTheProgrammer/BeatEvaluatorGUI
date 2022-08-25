using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatEvaluatorGUI {
    public enum MapDifficulty {Easy, Normal, Hard, Expert, ExpertPlus};

    public struct MapInfoData {
        public string SongName;
        public string SongAuthor;
        public string LevelAuthor;
        public float BPM;

        public string SongFileName;
        public Dictionary<MapDifficulty, string> DiffPaths;
    }

    public struct Criteria {

    }
}
