using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json; // :)
using System.Windows.Forms;

namespace BeatEvaluatorGUI {
    internal class FileInterpreter {
        public static Dictionary<string, MapDifficulty> DiffStrings = new Dictionary<string, MapDifficulty> {
            {"Easy", MapDifficulty.Easy},
            {"Normal", MapDifficulty.Normal},
            {"Hard", MapDifficulty.Hard},
            {"Expert", MapDifficulty.Expert},
            {"ExpertPlus", MapDifficulty.ExpertPlus}
        };

        public static MapInfoData LoadInfoFile(string WorkingDir) {
            if(!Directory.Exists(WorkingDir)) {
                throw new FileLoadException("Failed to find Info.dat");
            }

            string InfoFileData = File.ReadAllText(WorkingDir + "Info.dat");
            JSON_InfoBlock InfoJson = JsonConvert.DeserializeObject<JSON_InfoBlock>(InfoFileData);
            MapInfoData CollectedData = new MapInfoData();
            CollectedData.FolderPath = WorkingDir;
            CollectedData.SongName = InfoJson._songName;
            CollectedData.SongAuthor = InfoJson._songAuthorName;
            CollectedData.LevelAuthor = InfoJson._levelAuthorName;
            CollectedData.CoverImage = InfoJson._coverImageFilename;
            CollectedData.BPM = InfoJson._beatsPerMinute;
            CollectedData.SongFileName = InfoJson._songFilename;
            CollectedData.DiffPaths = new Dictionary<MapDifficulty, string>();

            //Find the standard beatmap set
            JSON_MapSetBlock StandardSet = null;
            var sets = InfoJson._difficultyBeatmapSets;
            for(int i = 0; i < sets.Count; i++) { 
                string Characteristic = sets[i]._beatmapCharacteristicName;
                if(Characteristic == "Standard") {
                    StandardSet = sets[i];
                    break;
                }   
            }
            if(StandardSet == null) {
                throw new FieldAccessException("Failed to find standard mapping");
            }
            foreach(JSON_DifficultyBlock Diff in StandardSet._difficultyBeatmaps) {
                MapDifficulty MapDiff = DiffStrings[(string)Diff._difficulty];
                CollectedData.DiffPaths.Add(MapDiff, (string)Diff._beatmapFilename);
            }
            return CollectedData;
        }

        public static Criteria EvaluateMapDiff(MapInfoData Info, string Path, MapDifficulty Diff) {
            if(!File.Exists(Path)) {
                throw new FileNotFoundException("Failed to find file");
            }

            string MapBuffer = File.ReadAllText(Path);
            JSON_MapHandle JsonBuffer = JsonConvert.DeserializeObject<JSON_MapHandle>(MapBuffer);


            int BlockCount = JsonBuffer._notes.Count;
            Console.WriteLine($"Evaluating {BlockCount} blocks..");

            Criteria Current = new Criteria();
            Current.Difficulty = Diff;

            #region Hot Start Detection
            Current.HotStart = (JsonBuffer._notes[0]._time / Info.BPM) * 60.0f;
            #endregion
            #region Cold End Detection
            string AudioFile = Info.FolderPath + Info.SongFileName;
            float SongLength = AudioManager.GetAudioTime(AudioFile);
            if(SongLength == -1.0f) {
                throw new ApplicationException("Failed to read vorbis.");
            }
            Current.ColdEnd = SongLength - ((JsonBuffer._notes[BlockCount-1]._time / Info.BPM) * 60.0f);
            #endregion
            #region Note Overlap Detection
            //Setup timed ordering of the notes :/ this is terrible for memoryyyyy
            Dictionary<float, List<int>> OverlapDatabase = new Dictionary<float, List<int>>();
            foreach(JSON_NoteHandle handle in JsonBuffer._notes) {
                if(!OverlapDatabase.ContainsKey(handle._time)) { 
                    OverlapDatabase[handle._time] = new List<int>();
                }
            }
            Current.NoteOverlaps = new List<float>();
            foreach(JSON_NoteHandle handle in JsonBuffer._notes) {
                int Index = handle._lineLayer * 4 + handle._lineIndex;
                if(OverlapDatabase[handle._time].Contains(Index)) {
                    Current.NoteOverlaps.Add(handle._time);
                }
            }
            #endregion
            #region Wall Detections
            Current.WallWidth = new List<float>();
            Current.WallDuration = new List<float>();
            Current.WallMinDuration = new List<float>();
            foreach(JSON_ObstacleHandle handle in JsonBuffer._obstacles) { 
                if(handle._width < 0.0f) {
                    Current.WallWidth.Add(handle._time);
                }
                if(handle._duration < 0.0f) {
                    Current.WallDuration.Add(handle._time);
                }
                //-_-
                bool MiddleLane = ((handle._lineIndex)^(handle._lineIndex>>1))==1;
                if(MiddleLane && handle._duration < (1.0/72.0)) {
                    Current.WallMinDuration.Add(handle._time);
                }
            }
            Current.UpdateCriteriaFlags();
            return Current;
            #endregion
        }
    }
}
