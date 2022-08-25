using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatEvaluatorGUI {
    public enum MapDifficulty {Easy, Normal, Hard, Expert, ExpertPlus};
    public enum NoteType {Left,Right,Bomb};
    public enum NoteDirection {
        UpStraight,DownStraight,LeftStraight,RightStraight,
        UpLeft,UpRight,DownLeft,DownRight,
        DotBlock,
    };

    public struct MapInfoData {
        public string SongName;
        public string SongAuthor;
        public string LevelAuthor;
        public float BPM;

        public string SongFileName;
        public Dictionary<MapDifficulty, string> DiffPaths;
    }

    public class JSON_MapHandle {
        public List<JSON_NoteHandle> _notes;
    }

    public class JSON_NoteHandle {
        public float _time { get; set; }
        public int _lineIndex { get; set; }
        public int _lineLayer { get; set; }
        public NoteType _type { get; set; }
        public NoteDirection _cutDirection { get; set; }
    }

    public struct Criteria {
        public MapDifficulty Difficulty;
        public float HotStart;
        public float ColdEnd;
        public List<float> NoteOverlaps;
        public List<float> WallWidth;
        public List<float> WallDuration;
        public List<float> WallMinDuration;
    }
}
