﻿/// Zip helper class built by Dipesh Avlani (http://integrationexperts.wordpress.com). Free to use in your projects.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICSharpCode.SharpZipLib.Zip;
using System.IO;
using System.IO.Compression;

namespace IntegrationExperts.Samples.PipelineComponents.Helpers
{
    internal class ZipHelper
    {
        #region helpers
        public static void DeleteDirectoryContents(string directory)
        {
            DirectoryInfo di = new DirectoryInfo(directory);

            foreach (FileInfo currFile in di.GetFiles())
                currFile.Delete();

            foreach (DirectoryInfo currDir in di.GetDirectories())
                currDir.Delete(true);
        }

        public static void UnzipFile(string zipFileName, string targetDirectory)
        {
            (new FastZip()).ExtractZip(zipFileName, targetDirectory, null);
        }

        public static void UnzipFile(Stream file, string targetFolder)
        {         
            try
            {                
                using (var ZipStream = new ZipInputStream(file))
                {
                    ZipEntry theEntry;
                    while ((theEntry = ZipStream.GetNextEntry()) != null)
                    {
                        if (theEntry.IsFile)
                        {
                            if (theEntry.Name != "")
                            {
                                string strNewFile = @"" + targetFolder + @"\" +

theEntry.Name;
                                string fullDirPath = Path.GetDirectoryName(strNewFile);
                                if (!Directory.Exists(fullDirPath)) Directory.CreateDirectory(fullDirPath);


                                if (File.Exists(strNewFile))
                                {
                                    continue;
                                }

                                using (FileStream streamWriter = File.Create(strNewFile))
                                {
                                    int size = 2048;
                                    byte[] data = new byte[2048];
                                    while (true)
                                    {
                                        size = ZipStream.Read(data, 0, data.Length);
                                        if (size > 0)
                                            streamWriter.Write(data, 0, size);
                                        else
                                            break;
                                    }
                                    streamWriter.Close();                                    
                                }
                            }
                        }
                        else if (theEntry.IsDirectory)
                        {
                            string strNewDirectory = @"" + targetFolder + @"\" +
theEntry.Name;
                            if (!Directory.Exists(strNewDirectory))
                            {
                                Directory.CreateDirectory(strNewDirectory);
                            }
                        }
                    }
                    ZipStream.Close();
                }
            }
            catch (Exception ex)
            {              
                throw ex;
            }
            finally
            {
 
            }
          
        }
        
        public static string RowColumnToPosition(int row, int column)
        {
            return ColumnIndexToName(column) + RowIndexToName(row);
        }

        public static string ColumnIndexToName(int columnIndex)
        {
            char second = (char)(((int)'A') + columnIndex % 26);

            columnIndex /= 26;

            if (columnIndex == 0)
                return second.ToString();
            else
                return ((char)(((int)'A') - 1 + columnIndex)).ToString() + second.ToString();
        }

        public static string RowIndexToName(int rowIndex)
        {
            return (rowIndex + 1).ToString();
        }

        #endregion
    }
}
