using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class UpdateCheck
    {
       public static void CheckForUpdates()
       {
       // This will check for updates via a dropbox server. I'm going to update this method later in development, since dropbox is most likely unstable and 
           // does not install properly.
       }
       
       public static void ValidifyUpdate()
       {
      // This will validify that the update is not from a development build. This is a current draft.
           if(lblNewVersion.Contains("dev") == true)
           {
              btnDownload.Visible = false;
           }
           
        }
       
    }
}
