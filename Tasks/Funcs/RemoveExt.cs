﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// TODO: Cleanup and change the code style
namespace Tasks
{
    class RemoveExt
    {

        public static int RemoveExtFirefox(string extpath)
        {
            try
            {

                string aa = extpath;
                File.Delete(aa);
                return 0;
            }
            catch
            {
                return 1;
            }
        }
            public static int RemoveExtChrome(string extpath)
            {
                try
                {

                    string aa = extpath;
                    File.Delete(aa);
                    return 0;
                }
                catch
                {
                    return 1;
                }
            }
    }
}
