using Newtonsoft.Json;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_To_SQLS.Classes
{
    public class Utils
    {
        public static string FilePath = Path.GetFullPath(AppContext.BaseDirectory);
        
        private const string FolderResources = "Resources";
        private const string FolderFonts = "Fonts";
        
        public static string GetFullResourcesPath(string sResourcesName)
        {
            return Path.Combine(FilePath, FolderResources, sResourcesName);
        }

        public static string GetFullFontPath(string sFontName)
        {
            return Path.Combine(FilePath, FolderFonts, sFontName);
        }
    }
}
