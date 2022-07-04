namespace Eshop_DataAccess.Model
{
    public class product
    {
        public string ArticleId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public product()
        {
            
        }

        public product(string articleId,string name,decimal price)
        {
            ArticleId=articleId;
            Name=name; 
            Price=price;
        }
    }
}