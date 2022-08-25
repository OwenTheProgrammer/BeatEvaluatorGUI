using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;

namespace BeatEvaluatorGUI
{
    public partial class AudioManager {
        [DllImport("AudioManager.dll", CharSet = CharSet.Unicode)]
        public static extern float GetAudioTime([MarshalAs(UnmanagedType.LPStr)] string FilePath);
    }
}
