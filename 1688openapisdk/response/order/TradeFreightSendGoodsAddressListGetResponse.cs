﻿using System;
using System.Collections.Generic;
using System.Text;
using _1688openapisdk.domain.order;

namespace _1688openapisdk.response.order
{
    public class TradeFreightSendGoodsAddressListGetResponse:AliResponse
    {
        public DeliveryAddress[] toReturn { get; set; }
    }
}
