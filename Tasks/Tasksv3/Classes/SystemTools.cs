﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Cleanup_Modules
{
    public class SystemTools
    {
   // This class is for system tools that are based on Windows functions, such as taskkilling, browser removal, etc.
  
        //Variables:
        public string task = "";
        
        // Proper Syntax: CreateProcess("explorer.exe") 
        public static void CreateProcess(string processname)
        {
          processname = task;      
        }
        
        // Proper Syntax: EndProcess("explorer.exe")
        public static void EndProcess(string processname)
        {
            processname = task;
        }
        
        // Proper Syntax: EndBrowserProcess(1);
       public static void EndBrowserProcess(int Browser)
       {
           // 1 - Chrome 
           // 2 - Firefox
           // 3 - Edge
    
       }
        
    }
 }
