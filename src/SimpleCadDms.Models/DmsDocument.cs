﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCadDms.Models
{
    public class DmsDocument
    {
        public string DocumentId { get; set; }

        public string FileExtension { get; set; }

        public byte[] FileContent { get; set; }
    }
}
