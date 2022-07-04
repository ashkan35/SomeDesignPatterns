﻿namespace Eshop_DataAccess.Model
{
    public class Product
    {
        public string ArticleId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }



        public Product(string articleId,string name,decimal price)
        {
            ArticleId=articleId;
            Name=name; 
            Price=price;
        }
    }
}