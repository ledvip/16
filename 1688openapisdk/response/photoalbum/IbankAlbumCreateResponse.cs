﻿using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.domain.photoalbum;

namespace _1688openapisdk.response.photoalbum
{
    public class IbankAlbumCreateResponse:AliResponse
    {
        public AlbumCreateResult toReturn { get; set; }
    }
}
