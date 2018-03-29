using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SFTP_File_Upload.Models;
using System.IO;
using Renci.SshNet;
using Renci.SshNet.Sftp;

namespace SFTP_File_Upload.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult UploadFiles()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UploadFiles(Inputs model)
        {
            model.host = "10.10.3.212";
            model.username = "vmuser";
            model.password = "Power@1234";
            model.destinationpath = "/home/vmuser/test/";
            model.port = 22;
            model.sourcefile = @"D:\Prakash Work\Report Issue\Json_Input_Data.txt";
          //  model.sourcefile = @"D:\Prakash Work\Report Issue\GOOD REPORT.pdf";
            Upload sftp = new Upload();
            sftp.UploadSFTPFile(model);
            return View();
        }
    }
}
