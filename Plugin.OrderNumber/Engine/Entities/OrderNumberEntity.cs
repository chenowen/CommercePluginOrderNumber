﻿using Sitecore.Commerce.Core;

namespace Achievecreative.Commerce.Plugin.OrderNumber.Entities
{
    public class OrderNumberEntity : CommerceEntity
    {
        public const string OrderNumberEntityId = "Achievecreative.Commerce.Plugin.OrderNumberEntity";

        public int LastOrderNumber { get; set; }
    }
}
