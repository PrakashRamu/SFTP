using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Renci.SshNet;
using Renci.SshNet.Sftp;
using System.IO;

namespace SFTP_File_Upload.Models
{
    public class Upload
    {
        public void UploadSFTPFile(Inputs model)
        {
            using (SftpClient client = new SftpClient(model.host, model.port, model.username, model.password))
            {
                client.Connect();
                client.ChangeDirectory(model.destinationpath);
                try
                {
                    using (FileStream fs = new FileStream(model.sourcefile, FileMode.Open))
                    {
                        client.BufferSize = 4 * 1024;
                        client.UploadFile(fs, Path.GetFileName(model.sourcefile));
                        fs.Flush();
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }
        }
    }
}
