using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json; // :)

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
            dynamic InfoJson = JsonConvert.DeserializeObject(InfoFileData);
            MapInfoData CollectedData;
            CollectedData.SongName = InfoJson._songName;
            CollectedData.SongAuthor = InfoJson._songAuthorName;
            CollectedData.LevelAuthor = InfoJson._levelAuthorName;
            CollectedData.BPM = InfoJson._beatsPerMinute;
            CollectedData.SongFileName = InfoJson._songFilename;
            CollectedData.DiffPaths = new Dictionary<MapDifficulty, string>();

            //Find the standard beatmap set
            dynamic StandardSet = null;
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
            foreach(dynamic Diff in StandardSet._difficultyBeatmaps) {
                MapDifficulty MapDiff = DiffStrings[(string)Diff._difficulty];
                CollectedData.DiffPaths.Add(MapDiff, (string)Diff._beatmapFilename);
            }
            return CollectedData;
        }

        public static void EvaluateMapDiff(MapInfoData Info, string Path, MapDifficulty Diff) {
            if(!File.Exists(Path)) {
                throw new FileNotFoundException("Failed to find file");
            }

            string MapBuffer = File.ReadAllText(Path);
            JSON_MapHandle JsonBuffer = JsonConvert.DeserializeObject<JSON_MapHandle>(MapBuffer);

            Criteria Current;
            Current.Difficulty = Diff;

            #region Hot Start Detection
            Current.HotStart = (JsonBuffer._notes[0]._time / Info.BPM) * 60.0f;
            #endregion
        }
    }
}
