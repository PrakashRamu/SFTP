using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SFTP_File_Upload.Models
{
    public class Inputs
    {
        public string sourcefile { get; set; }
        public string destinationpath { get; set; }
        public string host { get; set; }
        public string username { get; set; }
        public int port { get; set; }
        public string password { get; set; }
    }
}
