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

    #region JSON objects
    public class JSON_InfoBlock {
        public string _songName { get; set; }
        public string _songAuthorName { get; set; }
        public string _levelAuthorName { get; set; }
        public float _beatsPerMinute { get; set; }
        public string _songFilename { get; set; }
        public string _coverImageFilename { get; set; }
        public List<JSON_MapSetBlock> _difficultyBeatmapSets { get; set; }
    }
    public class JSON_MapSetBlock {
        public string _beatmapCharacteristicName;
        public List<JSON_DifficultyBlock> _difficultyBeatmaps;
    }

    public class JSON_DifficultyBlock {
        public string _difficulty { get; set; }
        public string _beatmapFilename { get; set; }
    }

    public class JSON_MapHandle {
        public List<JSON_NoteHandle> _notes;
        public List<JSON_ObstacleHandle> _obstacles;
    }
    public class JSON_NoteHandle {
        public float _time { get; set; }
        public int _lineIndex { get; set; }
        public int _lineLayer { get; set; }
        public NoteType _type { get; set; }
        public NoteDirection _cutDirection { get; set; }
    }
    public class JSON_ObstacleHandle {
        public float _time { get; set; }
        public int _lineIndex { get; set; }
        public int _type { get; set; }
        public float _duration { get; set; }
        public int _width { get; set; }
    }
    #endregion

    public struct MapInfoData {
        public string FolderPath;
        public string SongName;
        public string SongAuthor;
        public string LevelAuthor;
        public string CoverImage;
        public float BPM;

        public string SongFileName;
        public Dictionary<MapDifficulty, string> DiffPaths;
    }

    public enum MapMet {
        HotStart = 1<<0,
        ColdEnd = 1<<1,
        NoteOverlap = 1<<2,
        WallWidth = 1<<3,
        WallDuration = 1<<4,
        WallMinDuration = 1<<5
    };

    public struct Criteria {
        public MapDifficulty Difficulty;
        public float HotStart;
        public float ColdEnd;
        public List<float> NoteOverlaps;
        public List<float> WallWidth;
        public List<float> WallDuration;
        public List<float> WallMinDuration;

        public MapMet CriteriaPass;
        public static MapMet AllMet = (MapMet)((1<<6)-1);

        //Built this stupidly but easily modifiable
        public void UpdateCriteriaFlags() {
            CriteriaPass = 0;
            if(HotStart > 1.5f) CriteriaPass |= MapMet.HotStart;
            if(ColdEnd > 2.0f) CriteriaPass |= MapMet.ColdEnd;
            if(NoteOverlaps.Count==0) CriteriaPass |= MapMet.NoteOverlap;
            if(WallWidth.Count==0) CriteriaPass |= MapMet.WallWidth;
            if(WallDuration.Count==0) CriteriaPass |= MapMet.WallDuration;
            if(WallMinDuration.Count==0) CriteriaPass |= MapMet.WallMinDuration;
        }
    }

    public struct MapNode {
        public string LoadPath;
        public MapInfoData Info;
        public List<Criteria> DiffCriteria;
    }
}
