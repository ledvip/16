﻿using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.util;

namespace _1688openapisdk.response.order
{
    public class AreaCodeGetResponse:AliResponse
    {
        public Dictionary<string, int> toReturn 
        {
            get
            {
                return StringUtil.StringToDictionary(this.body);
                  
            }
        }


    }
}
