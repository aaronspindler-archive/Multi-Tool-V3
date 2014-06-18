using System;
using System.Globalization;
using System.Windows.Forms;

namespace Multi_Tool_V3
{
    internal class UsefulCode
    {
        public void ErrorOccured(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public string GetCurrentTime()
        {
            var time = DateTime.Now.ToString("hh:mm:ss tt", DateTimeFormatInfo.InvariantInfo);
            return time;
        }
    }
}