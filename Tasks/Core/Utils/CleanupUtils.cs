﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

// everything is over-noted, don't mind it.
namespace Tasks.Core.Utils
{
    public class CleanupUtils
    {
        
        public static int filesDeleted;
        
        // Deletes all files in a directory.
        // Will also add a string list for all of the file names, that's pretty easy.
        public static bool DeleteAllFiles(DirectoryInfo directoryInfo)
        {
            foreach (var file in directoryInfo.GetFiles()) // could optimize?
            {
                try
                {
                    file.Delete();
                    filesDeleted++;
                    //   Debug.Log(file.FullName);
                }
                catch (Exception)
                {
                    //   Debug.Log(ex.Message);
                }

            }
            foreach (var dir in directoryInfo.GetDirectories())
            {
                try
                {
                    dir.Delete(true);
                    filesDeleted++;
                }
                catch (Exception)
                {
                    
                }

            }

            return true;
        }

        public static void AnalyzeAllFiles(DirectoryInfo directoryInfo)
        {
            foreach (var file in directoryInfo.GetFiles())
            {
                try
                {
                    Debug.Print("File: " + file.Name);
                }
                catch (Exception)
                {
                    
                }
            }
        }
        
        public static bool CanLogCleanup()
        {
            if (Directory.Exists(Dirs.tasksDir))
            {
               return true;
            }
                return false;
        }
           
        public static void SaveCleanupLog()
        {
            CanLogCleanup();
            frmCleanup CleanupForm = new frmCleanup();
            int t = (int)((DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds);
            if (CanLogCleanup() == true)
            {
                // bad code, will fix later.
                File.WriteAllLines(Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Tasks"), "Cleanup Summary") + "\\tasks-cleanup-summary-" + t + ".txt", CleanupForm.CleanupLogsLBox.Items.Cast<string>().ToArray());
            }
        }
       
       // Deletes directory and recreates it (Usually meant for debugging / settings) 
        public static void DeleteTasksFolder()
        {
            Directory.Delete(Dirs.tasksDir);
            Directory.CreateDirectory(Dirs.tasksDir);
        }



        [DllImport("Shell32.dll")]
        public static extern int SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlag dwFlags);

        [Flags]
        public enum RecycleFlag : int
        {
            SHERB_NOCONFIRMATION = 0x00000001,
            SHERB_NOPROGRESSUI = 0x00000001,
            SHERB_NOSOUND = 0x00000004
        }

        [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
        public static extern void SHAddToRecentDocs(ShellAddToRecentDocsFlags flag, string path);

        public enum ShellAddToRecentDocsFlags
        {
            Pidl = 0x001,
            Path = 0x002,
            PathW = 0x003
        }

    }


    public static class CleanupDirectories
    {
        // Everything here is mostly placeholder until I fill in the directories.
        public static string localappdata = Environment.GetEnvironmentVariable("LocalAppData");
        public static string roamingappdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string windowstemp = "C:\\Windows\\Temp\\";
        public static string usertemp = Path.GetTempPath();
        public static string downloads = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\";

        public static string[] ChromeDirectories = {"Default\\Cache\\", "Default\\Code Cache\\", "Default\\GPUCache\\", "ShaderCache\\", "Default\\Service Worker\\CacheStorage\\", "Default\\Service Worker\\ScriptCache\\", "GrShaderCache\\GPUCache\\", "Default\\File System\\", "Default\\JumpListIconsMostVisited\\", "Default\\JumpListIconsRecentClosed\\", "Default\\Service Worker\\Database\\" };
        public static string ChromeExtensionDirectory;

        public static string[] FirefoxDirectories = { localappdata + "\\Mozilla\\Firefox\\Profiles\\", "ab", "abc", "abcd" };
        public static string FirefoxExtensionDirectory = "";

        public static string[] EdgeDirectories = { "a", "ab", "abc", "abcd" };
        public static string EdgeExtensionDirectory = "";
    }
}


