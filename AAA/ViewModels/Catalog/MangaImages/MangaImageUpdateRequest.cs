﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.Catalog.MangaImages
{
    public class MangaImageUpdateRequest
    {
        public int Id { get; set; }

        public string ChuThich { get; set; }

        public bool Anhmacdinh { get; set; }

        public int ThuTu { get; set; }

        public IFormFile ImageFile { get; set; }
    }
}
