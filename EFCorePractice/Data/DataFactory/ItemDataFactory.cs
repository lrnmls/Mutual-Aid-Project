using EFCorePractice.Data.Context;
using EFCorePractice.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCorePractice.Data.DataFactory
{
    public class ItemDataFactory : BaseEntityDataFactory<Item>
    {
        public ItemDataFactory(PracticeContext practiceContext) : base(practiceContext)
        {

        }

        public override Item[] Seed => new[]
        {
            new Item()
            {
                Id = 1,
                Name = "Long Sleeve T-Shirt",
                ImgUrl = "/images/long-sleeve-shirt.jpg",
                Description = "Black Long Sleeve T-Shirt",
                Price = 9.99M,
                Quantity = 1
            },
            new Item()
            {
                Id = 2,
                Name = "T-Shirt",
                ImgUrl = "/images/short-sleeve-shirt.jpg",
                Description = "White Short Sleeve T-Shirt",
                Price = 5.99M,
                Quantity = 1
            },
             new Item()
            {
                Id = 3,
                Name = "Shorts",
                ImgUrl = "/images/black-denim-shorts.jpg",
                Description = "Black Denim Shorts",
                Price = 24.99M,
                Quantity = 1
            },
              new Item()
            {
                Id = 4,
                Name = "Plaid Pants",
                ImgUrl = "/images/red-plaid-pants.jpg",
                Description = "Red Plaid Cropped Pants",
                Price = 34.99M,
                Quantity = 1
            },
               new Item()
            {
                Id = 5,
                Name = "Leather Jacket",
                ImgUrl = "/images/black-leather-jacket.jpg",
                Description = "Black Leather Biker Jacket",
                Price = 99.99M,
                Quantity = 1
            }
        };
    }
}
