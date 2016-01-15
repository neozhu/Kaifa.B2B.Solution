using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Net;

namespace BarCodePrinter
{
    public class FtpWeb
    {
        /// <summary>
        /// 如：www.baidu.com
        /// </summary>
        string ftpServer;
        string ftpRemotePath;
        string ftpUserID;
        string ftpPassword;
        int ftpPort;
        string ftpURI;

        private NetworkCredential certificate;

        /// <summary>
        /// 连接FTP
        /// </summary>
        /// <param name="FtpServerIP">FTP连接地址(域名或ip)</param>
        /// <param name="FtpUserID">用户名</param>
        /// <param name="FtpPassword">密码</param>
        public FtpWeb(string FtpServer, string FtpUserID, string FtpPassword, int FtpPort)
        {
            ftpServer = FtpServer;
            ftpUserID = FtpUserID;
            ftpPassword = FtpPassword;
            ftpPort = FtpPort;
            ftpURI = "ftp://" + ftpServer + @":" + ftpPort;
            certificate = new NetworkCredential(FtpUserID, FtpPassword);

        }
        /// <summary>
        /// 创建FTP请求
        /// </summary>
        /// <param name="uri">ftp://myserver/upload.txt</param>
        /// <param name="method">Upload/Download</param>
        /// <returns></returns>
        private FtpWebRequest CreateFtpWebRequest(Uri uri, string method)
        {

            FtpWebRequest ftpClientRequest = (FtpWebRequest)WebRequest.Create(uri);

            ftpClientRequest.Proxy = null;
            ftpClientRequest.Credentials = certificate;
            ftpClientRequest.KeepAlive = true;
            ftpClientRequest.UseBinary = true;
            ftpClientRequest.UsePassive = true;
            ftpClientRequest.Method = method;

            //ftpClientRequest.Proxy = new WebProxy(@"proxy.vmware.com:3128");            
            //ftpClientRequest.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
            //ftpClientRequest.Timeout = -1;

            return ftpClientRequest;
        }

        /// <summary>
        /// 上传
        /// </summary>
        /// <param name="Localfile">本地文件</param>
        /// <param name="ServerFilePath">远程文件目录</param>
        public bool Upload(string Localfile, string ServerFilePath)
        {
            FileInfo fileInf = new FileInfo(Localfile);
            if (fileInf.Exists == false)
            {
                return false;
            }

            string uri = ftpURI + ServerFilePath + @"/" + fileInf.Name;
            FtpWebRequest reqFTP;
            FileStream fs = null;
            Stream strm = null;
            if (this.IsExist(ServerFilePath + "/" + fileInf.Name))
            {
                reqFTP = this.CreateFtpWebRequest(new Uri(uri), WebRequestMethods.Ftp.AppendFile);
                long offset = this.GetFileSize(ServerFilePath + "/" + fileInf.Name);
                fs = fileInf.OpenRead();
                fs.Position = offset;
            }
            else
            {
                reqFTP = this.CreateFtpWebRequest(new Uri(uri), WebRequestMethods.Ftp.UploadFile);
                fs = fileInf.OpenRead();
            }
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            double cmpRate = 0.0;
            try
            {
                long fileLenght = fileInf.Length;
                long totalReadCount = 0;
                int contentLen = 0;

                strm = reqFTP.GetRequestStream();
                contentLen = fs.Read(buff, 0, buffLength);


                while (contentLen != 0)
                {
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);

                    totalReadCount += contentLen;
                    cmpRate = (100 * totalReadCount) / fileLenght;

                    //if (appInfo.frmMain != null)
                    //{
                    //    appInfo.frmMain.UploadStatus.Text =
                    //        string.Format("系统提示：\"{0}\",上传中...{1}%", fileInf.Name, (int)cmpRate);
                    //}
                }
                strm.Close();
                fs.Close();
                return true;
            }
            catch (Exception ex)
            {

                if (strm != null)
                {
                    //strm.Close();
                }
                if (fs != null)
                {
                    fs.Close();
                }

                //AppDebug.LogMessageToFile("Upload Error --> " + ex.Message + " -->" + Localfile);
                return false;
            }
        }

        /// <summary>
        /// 下载
        /// </summary>
        /// <param name="serverPath">服务器路径</param>
        /// <param name="LocalPath">本地路径</param>
        /// <param name="fileName"></param>
        public bool Download(string serverPathAndName, string LocalPathAndName, string info)
        {
            FtpWebRequest reqFTP;
            System.IO.FileStream outputStream = null;
            FtpWebResponse response = null;
            Stream ftpStream = null;
            try
            {
                string uri = ftpURI + serverPathAndName;
                //AppDebug.LogMessageToFile("FTP URI: " + uri);

                Encoding unicode = Encoding.Unicode;
                Encoding utf8 = Encoding.UTF8;
                Encoding ascii = Encoding.ASCII;

                byte[] unicodeBytes = unicode.GetBytes(uri);
                //byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicodeBytes);
                byte[] utf8Bytes = Encoding.Convert(unicode, utf8, unicodeBytes);

                ////char[] asciiChars = new char[ascii.GetCharCount(asciiBytes, 0, asciiBytes.Length)];


                //ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0);
                //string asciiString = new string(asciiChars);

                //Uri ftpPath = new Uri(uri);
                string abpath = Encoding.UTF8.GetString(utf8Bytes);
                //reqFTP = this.CreateFtpWebRequest(new Uri(asciiString), WebRequestMethods.Ftp.DownloadFile);
                reqFTP = this.CreateFtpWebRequest(new Uri(abpath), WebRequestMethods.Ftp.DownloadFile);

                //判断是否继续下载
                //继续写入下载文件的FileStream
                long totalReadCount = 0L;

                if (System.IO.File.Exists(LocalPathAndName))
                {
                    //继续下载
                    reqFTP.ContentOffset = (new System.IO.FileInfo(LocalPathAndName)).Length;
                    outputStream = new System.IO.FileStream(
                        LocalPathAndName, System.IO.FileMode.Append, System.IO.FileAccess.Write);
                    totalReadCount += (new System.IO.FileInfo(LocalPathAndName)).Length;
                }
                else
                {
                    //一般下载
                    string path = (new FileInfo(LocalPathAndName)).DirectoryName;
                    if (Directory.Exists(path) == false)
                    {
                        Directory.CreateDirectory(path);
                    }
                    outputStream = new System.IO.FileStream(
                        LocalPathAndName, System.IO.FileMode.Create, System.IO.FileAccess.Write);

                }

                response = (FtpWebResponse)reqFTP.GetResponse();
                ftpStream = response.GetResponseStream();

                long fileLenght = GetFileSize(serverPathAndName);

                double cmpRate = 0;

                int bufferSize = 2048;
                int readCount;
                byte[] buffer = new byte[bufferSize];

                readCount = ftpStream.Read(buffer, 0, bufferSize);
                totalReadCount += readCount;

                //if (appInfo.tempFrm != null)
                //{
                //    string str = string.Format("系统提示：\"{0}\",开始下载...", info);
                //    AppDebug.LogMessageToFile(str);
                //    AppDebug.LogMessageToFile("Server Path: " + serverPathAndName);
                //    appInfo.tempFrm.lb_txtinfo.Text = str;

                //}

                int num = 0;
                while (readCount > 0)
                {
                    num++;
                    if (num > 10)
                    {
                        num = 1;
                    }
                    //if (appInfo.StopDown)
                    //{
                    //    break;
                    //}
                    outputStream.Write(buffer, 0, readCount);

                    readCount = ftpStream.Read(buffer, 0, bufferSize);

                    totalReadCount += readCount;
                    cmpRate = (100 * totalReadCount) / fileLenght;

                    //if (appInfo.tempFrm != null)
                    //{
                    //    appInfo.tempFrm.lb_txtinfo.Text = string.Format("系统提示：\"{0}\",下载中...{1}%", info, (int)cmpRate);
                    //}
                }
                //if (appInfo.tempFrm != null)
                //{
                //    string str = string.Format("系统提示：\"{0}\",下载结束.", info);
                //    appInfo.tempFrm.lb_txtinfo.Text = str;
                //    AppDebug.LogMessageToFile(str);
                //    AppDebug.LogMessageToFile("Server Path: " + serverPathAndName);
                //}
                ftpStream.Close();
                outputStream.Close();
                response.Close();

                //if (appInfo.StopDown)
                //{
                //    return false;
                //}

                return true;
            }
            catch (Exception ex)
            {
                //AppDebug.LogMessageToFile("Ftp download error: " + ex.Message);
                if (outputStream != null)
                {
                    outputStream.Close();
                }
                if (ftpStream != null)
                {
                    //  ftpStream.Close();
                }
                if (response != null)
                {
                    // response.Close();
                }

                //AppDebug.LogMessageToFile("Download Error --> " + ex.Message + " -->" + serverPathAndName);
                return false;
            }
        }


        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="fileName">如：/web/soft/abc.exe</param>
        public void Delete(string filePathAndName)
        {
            try
            {
                string uri = ftpURI + filePathAndName;
                FtpWebRequest reqFTP;
                reqFTP = this.CreateFtpWebRequest(new Uri(uri), WebRequestMethods.Ftp.DeleteFile);

                string result = String.Empty;
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                long size = response.ContentLength;
                Stream datastream = response.GetResponseStream();
                StreamReader sr = new StreamReader(datastream);
                result = sr.ReadToEnd();
                sr.Close();
                datastream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                //AppDebug.LogMessageToFile("Delete Error --> " + ex.Message.ToString() + "  文件名:" + filePathAndName);
            }
        }




        /// <summary>
        /// 获取当前目录下列表(文件和文件夹)
        /// </summary>
        /// <returns></returns>
        public string[] GetList()
        {
            string[] downloadFiles;
            StringBuilder result = new StringBuilder();
            FtpWebRequest reqFTP = null;
            WebResponse response = null;
            StreamReader reader = null;
            try
            {
                reqFTP = this.CreateFtpWebRequest(new Uri(ftpURI), WebRequestMethods.Ftp.ListDirectory);

                response = reqFTP.GetResponse();
                reader = new StreamReader(response.GetResponseStream(), Encoding.Default);

                string line = reader.ReadLine();
                if (line == null)
                {
                    downloadFiles = new string[] { "" };
                    return downloadFiles;
                }
                while (line != null)
                {
                    result.Append(line);
                    result.Append("\n");
                    line = reader.ReadLine();
                }
                result.Remove(result.ToString().LastIndexOf('\n'), 1);
                reader.Close();
                response.Close();
                return result.ToString().Split('\n');
            }
            catch (Exception ex)
            {
                if (reader != null)
                {
                    // reader.Close();
                }
                if (response != null)
                {
                    // response.Close();
                }

                //AppDebug.LogMessageToFile("GetFList Error --> " + ex.Message.ToString());

                return new string[0];
            }
        }



        /// <summary>
        /// 判断下指定的子目录或文件是否存在
        /// </summary>
        /// <param name="RemoteDirectoryName">指定的目录名或文件名(如：/web/aaa/bbb/ccc,/web/aaa/bbb/file.exe)</param>
        public bool IsExist(string RemotePathOrfile)
        {
            string path = "";
            string cur = "";
            string[] dir = RemotePathOrfile.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);

            if (dir.Length < 2)
            {
                GotoDirectory("", true);
                cur = dir[0];
            }
            else
            {
                for (int i = 0; i < dir.Length - 1; i++)
                {
                    path += "/" + dir[i];
                }
                GotoDirectory(path, true);
                cur = dir[dir.Length - 1];
            }

            string[] dirList = this.GetList();
            foreach (string str in dirList)
            {
                if (str.Trim() == cur.Trim())
                {
                    return true;
                }
            }
            return false;
        }



        /// <summary>
        /// 创建文件夹
        /// </summary>
        /// <param name="dirName">服务器目录(如：/web/aaa/bbb)</param>
        public void MakeDir(string dirName)
        {

            try
            {
                FtpWebRequest reqFTP;

                string[] dir = dirName.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                string uri = ftpURI;
                string path = "";

                for (int i = 0; i < dir.Length; i++)
                {
                    uri += "/" + dir[i];
                    path += "/" + dir[i];
                    if (!this.IsExist(path))
                    {
                        reqFTP = this.CreateFtpWebRequest(new Uri(uri), WebRequestMethods.Ftp.MakeDirectory);
                        FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                        Stream ftpStream = response.GetResponseStream();
                        ftpStream.Close();
                        response.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                //AppDebug.LogMessageToFile("MakeDir Error --> " + ex.Message.ToString());
            }
        }



        /// <summary>
        /// 获取指定文件大小
        /// </summary>
        /// <param name="filePathAndName">如：/web/soft/abc.exe</param>
        /// <returns></returns>
        public long GetFileSize(string filePathAndName)
        {

            string path = "";
            string cur = "";
            string[] dir = filePathAndName.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);

            if (dir.Length < 2)
            {
                GotoDirectory("", true);
                cur = dir[0];
            }
            else
            {
                for (int i = 0; i < dir.Length - 1; i++)
                {
                    path += "/" + dir[i];
                }
                GotoDirectory(path, true);
                cur = dir[dir.Length - 1];
            }

            FtpWebRequest reqFTP;
            long fileSize = 0;
            try
            {
                //reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://"+ftpServer + filePathAndName));
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpURI + filePathAndName));
                reqFTP.Method = WebRequestMethods.Ftp.GetFileSize;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();
                fileSize = response.ContentLength;

                ftpStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
               // AppDebug.LogMessageToFile("GetFileSize Error --> " + ex.Message.ToString());
            }
            return fileSize;
        }

        /// <summary>
        /// 切换当前目录
        /// </summary>
        /// <param name="DirectoryName"></param>
        /// <param name="IsRoot">true 绝对路径 false 相对路径</param> 
        public void GotoDirectory(string DirectoryName, bool IsRoot)
        {
            if (IsRoot)
            {
                ftpRemotePath = DirectoryName;
            }
            else
            {
                ftpRemotePath += DirectoryName;

            }

            //ftpURI =ftpURI + ftpRemotePath + "/";

        }

        /// <summary>
        /// 改名
        /// </summary>
        /// <param name="currentFilename"></param>
        /// <param name="newFilename"></param>
        public void ReName(string currentFilename, string newFilename)
        {
            FtpWebRequest reqFTP;
            try
            {
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpURI + currentFilename));
                reqFTP.Method = WebRequestMethods.Ftp.Rename;
                reqFTP.RenameTo = newFilename;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();

                ftpStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                //AppDebug.LogMessageToFile("ReName Error --> " + ex.Message.ToString());
            }
        }

        /// <summary>
        /// 移动文件
        /// </summary>
        /// <param name="currentFilename"></param>
        /// <param name="newFilename"></param>
        public void MovieFile(string currentFilename, string newDirectory)
        {
            ReName(currentFilename, newDirectory);
        }
    }
}
