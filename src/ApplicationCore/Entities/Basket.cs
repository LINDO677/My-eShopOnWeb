﻿using System.Collections.Generic;
using System.Linq;

namespace Microsoft.eShopWeb.ApplicationCore.Entities
{
    public class Basket : BaseEntity
    {
        public string BuyerId { get; set; }
        public List<BasketItem> Items { get; set; } = new List<BasketItem>();

        public void AddItem(int catalogItemId, decimal unitPrice, int quantity = 1)
        {
            if (!Items.Any(i => i.CatalogItemId == catalogItemId))
            {
                Items.Add(new BasketItem()
                {
                    CatalogItemId = catalogItemId,
                    Quantity = quantity,
                    UnitPrice = unitPrice
                });
                return;
            }
            var existingItem = Items.FirstOrDefault(i => i.CatalogItemId == catalogItemId);
            existingItem.Quantity += quantity;
        }
        //public void AddItem(CatalogItem item, decimal unitPrice, int quantity = 1)
        //{
        //    if (!Items.Any(i => i.Item.Id == item.Id))
        //    {
        //        Items.Add(new BasketItem()
        //        {
        //            Item = item,
        //            //ProductId = productId,
        //            Quantity = quantity,
        //            UnitPrice = unitPrice
        //        });
        //        return;
        //    }
        //    var existingItem = Items.FirstOrDefault(i => i.Item.Id == item.Id);
        //    existingItem.Quantity += quantity;
        //}
    }
}
