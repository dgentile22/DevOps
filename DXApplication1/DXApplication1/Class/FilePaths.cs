using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyTestApplication.Class
{
    internal class FilePaths
    {
        private static readonly string parentDir = @"C:\Users\gentiled\Documents\TestFolderPath";

        internal static string GetFolderPath(string folderName)
        {
            string retVal;
            switch (folderName.ToLower())
            {
                case ".databaseconnection":
                case "error_attachments":
                case "rfd_attachments":
                case "service_logs":
                    retVal = Path.Combine(GetPath_IT(), folderName);
                    break;
                case "cad":
                case "cnc":
                    retVal = Path.Combine(GetPath_Production(), folderName);
                    break;
                case "_drawings":
                    retVal = GetPath_Drawings();
                    break;
                case "_customers":
                    retVal = Path.Combine(GetPath_Drawings(), folderName);
                    break;
                case "_partpdfs":
                case "_sigmanested files":
                    retVal = Path.Combine(GetPath_CNC(), folderName);
                    break;
                case "_taskpaperwork":
                    retVal = Path.Combine(GetPath_Sigmanested_Files(), folderName);
                    break;
                default:
                    retVal = Path.Combine(parentDir, folderName);
                    break;
            }

            return retVal;
        }

        /*
         * ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
         * If a folder contains sub-folder(s) inside then create a method you see below.
         * \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
         */
        private static string GetPath_IT()
        {
            return Path.Combine(parentDir, "IT");
        }
        private static string GetPath_IT_SubFolder(string subFolder)
        { 
            
        }
        private static string GetPath_Production()
        {
            return Path.Combine(parentDir, "Production");
        }
        private static string GetPath_CAD()
        {
            return Path.Combine(GetPath_Production(), "CAD");
        }
        private static string GetPath_Drawings()
        {
            return Path.Combine(GetPath_CAD(), "_Drawings");
        }
        private static string GetPath_CNC()
        {
            return Path.Combine(GetPath_Production(), "CNC");
        }
        private static string GetPath_Sigmanested_Files()
        {
            return Path.Combine(GetPath_CNC(), "_SIGMANESTED FILES");
        }

    }
}
