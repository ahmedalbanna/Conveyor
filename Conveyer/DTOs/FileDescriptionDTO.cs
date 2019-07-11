﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conveyer.DTOs
{
    public class FileDescriptionDTO
    {
        public string ContentType { get; set; }
        public DateTime DateUploaded { get; set; }

        public string FileName { get; set; }

        public string Guid { get; set; }

        public int Id { get; set; }
        public long Size { get; set; }
    }
}
