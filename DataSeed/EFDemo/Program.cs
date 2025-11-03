﻿using Microsoft.EntityFrameworkCore;

class Program
{

    static void Main()
    {

        using (var context = new AppDbContext())
        {
            // Add a list of items
            var itemList = new List<ItemData>
            {
                new ItemData
                {
                    Name = "Logitech G402 Hyperion Fury",
                    Description = "Mouse",
                    Price = 2495.00m,
                    Quantity = 127,
                    Url = "https://tse1.mm.bing.net/th/id/OIP.LtXxHYPNGIR8vBFpzbbz6QHaE2?rs=1&pid=ImgDetMain&o=7&rm=3"
                },
                new ItemData
                {
                    Name = "Razer DeathAdder V2 Pro",
                    Description = "Mouse",
                    Price = 6995.00m,
                    Quantity = 256,
                    Url = "https://www.cravingtech.com/blog/wp-content/uploads/2020/10/Razer-DeathAdder-V2-Pro-9-1536x1024.jpg"
                },
                new ItemData
                {
                    Name = "Razer Viper 8kHz",
                    Description = "Mouse",
                    Price = 4995.00m,
                    Quantity = 9,
                    Url = "https://cf.shopee.co.th/file/72899118835675df8f620d6f0b77fba3"
                },
                new ItemData
                {
                    Name = "Cosmic Byte Trinity",
                    Description = "Keyboard",
                    Price = 2950.00m,
                    Quantity = 156,
                    Url = "https://cdns3.thecosmicbyte.com/wp-content/uploads/5-2-7-5.jpg"
                },
                new ItemData
                {
                    Name = "Cosmic Byte Artemis",
                    Description = "Keyboard",
                    Price = 450.00m,
                    Quantity = 245,
                    Url = "https://cdns3.thecosmicbyte.com/wp-content/uploads/Titan_Black_2.jpg"
                },
                new ItemData
                {
                    Name = "Redragon Diemos K599",
                    Description = "Keyboard",
                    Price = 4566.00m,
                    Quantity = 78,
                    Url = "https://cdn.shopify.com/s/files/1/2695/9506/files/4.jpg?v=1620698756"
                },
                new ItemData
                {
                    Name = "ASUS TUF-GAMING-H3",
                    Description = "Headphone",
                    Price = 3562.00m,
                    Quantity = 34,
                    Url = "https://webshop.asus.com/media/97/77/15/1715864800/e6cc7a8803531acb41323d05a70863dd.jpeg"
                },
                new ItemData
                {
                    Name = "Corsair HS60 PRO",
                    Description = "Headphone",
                    Price = 6789.00m,
                    Quantity = 20,
                    Url = "https://www.altstore.si/modules/uploader/uploads/s_product/pictures/corsair-hs60-pro-surround-gaming--1.jpg"
                },
                new ItemData
                {
                    Name = "Ant Esports H1100 Pro ",
                    Description = "Headphone",
                    Price = 3256.00m,
                    Quantity = 36,
                    Url = "https://tse4.mm.bing.net/th/id/OIP.bRsgwtormY2Bk9xqy74fcAAAAA?rs=1&pid=ImgDetMain&o=7&rm=3"
                },
                new ItemData
                {
                    Name = "BenQ MOBIUZ EX2510",
                    Description = "Display",
                    Price = 25000.00m,
                    Quantity = 45,
                    Url = "https://www.static-src.com/wcsstore/Indraprastha/images/catalog/full/catalog-image/104/MTA-97098015/oem_oem_full01.jpg"
                },
                new ItemData
                {
                    Name = "AOC 22B30HM2 21.5",
                    Description = "Display",
                    Price = 12000.00m,
                    Quantity = 34,
                    Url = "https://tse2.mm.bing.net/th/id/OIP.hEfBKvQa8TScG3k-rNIpIQHaHa?rs=1&pid=ImgDetMain&o=7&rm=3"
                },
                new ItemData
                {
                    Name = "LG 34WQ500 34",
                    Description = "Display",
                    Price = 18000.00m,
                    Quantity = 23,
                    Url = "https://tse1.mm.bing.net/th/id/OIP.j-0u6p7eempNJBWV43fFgQHaHa?rs=1&pid=ImgDetMain&o=7&rm=3"
                },
                new ItemData
                {
                    Name = "Lenovo V15 G4",
                    Description = "Laptop",
                    Price = 54000.00m,
                    Quantity = 88,
                    Url = "https://m.media-amazon.com/images/I/71aup0IO2ZL._AC_UY218_.jpg"
                },
                new ItemData
                {
                    Name = "ASUS Vivobook 14",
                    Description = "Laptop",
                    Price = 43000.00m,
                    Quantity = 12,
                    Url = "https://m.media-amazon.com/images/I/71Mh-ltniDL._AC_UY218_.jpg"
                },
                new ItemData
                {
                    Name = "JioBook 11",
                    Description = "Laptop",
                    Price = 10990.00m,
                    Quantity = 223,
                    Url = "https://m.media-amazon.com/images/I/61IDcxw27+L._AC_UY218_.jpg"
                },
                new ItemData
                {
                    Name = "Western Digital 2TB",
                    Description = "Hard-Disk",
                    Price = 7350.00m,
                    Quantity = 26,
                    Url = "https://m.media-amazon.com/images/I/510+J06fz0L._AC_UY218_.jpg"
                },
                new ItemData
                {
                    Name = "AYKAIT Slim 300GB",
                    Description = "Hard-Disk",
                    Price = 1400.00m,
                    Quantity = 24,
                    Url = "https://m.media-amazon.com/images/I/71woTtDHhrL._AC_UY218_.jpg"
                },
                new ItemData
                {
                    Name = "Seagate Expansion 2TB",
                    Description = "Hard-Disk",
                    Price = 3500.00m,
                    Quantity = 45,
                    Url = "https://m.media-amazon.com/images/I/814SDu24dnL._AC_UY218_.jpg"
                },
                new ItemData
                {
                    Name = "K9 Dual Wireless",
                    Description = "Mic",
                    Price = 699.00m,
                    Quantity = 123,
                    Url = "https://m.media-amazon.com/images/I/412sa06TPfL._SY300_SX300_QL70_FMwebp_.jpg"
                },
                new ItemData
                {
                    Name = "VELOMAX Mic",
                    Description = "Mic",
                    Price = 975.00m,
                    Quantity = 112,
                    Url = "https://m.media-amazon.com/images/I/417zkc3UwCL._SY300_SX300_QL70_FMwebp_.jpg"
                },
                new ItemData
                {
                    Name = "Portronics Dash 7",
                    Description = "Mic",
                    Price = 759.00m,
                    Quantity = 23,
                    Url = "https://m.media-amazon.com/images/I/510FMHQ1ikL._SX569_.jpg"
                },
                new ItemData
                {
                    Name = "boAt Airdopes 141 ",
                    Description = "Earphones",
                    Price = 999.00m,
                    Quantity = 26,
                    Url = "https://m.media-amazon.com/images/I/71O+4zDSk-L._SY450_.jpg"
                },
                new ItemData
                {
                    Name = "GOBOULT Z60",
                    Description = "Earphones",
                    Price = 799.00m,
                    Quantity = 26,
                    Url = "https://m.media-amazon.com/images/I/61-LZt6l8HL._AC_UY218_.jpg"
                },
                new ItemData
                {
                    Name = "OnePlus Nord Buds 2r",
                    Description = "Earphones",
                    Price = 1500.00m,
                    Quantity = 42,
                    Url = "https://m.media-amazon.com/images/I/51oMWaW7tKL._SX569_.jpg"
                },
            };
            context.ItemData.AddRange(itemList);
            context.SaveChanges();
            Console.WriteLine("Items added to the database.");

            // Clear Whole Database
            // context.ItemData.RemoveRange(context.ItemData);
            // context.SaveChanges();
            // Console.WriteLine("All items deleted from the database.");

        }
    }
}