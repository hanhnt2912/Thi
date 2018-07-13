namespace Thi.entity
{
    public abstract class Product
    {
        public int productId;
        public string productName;
        public double productPrice;

        public Product()
        {
        }

        public Product(int productId, string productName, double productPrice)
        {
            this.productId = productId;
            this.productName = productName;
            this.productPrice = productPrice;
        }

        public int ProductId
        {
            get => productId;
            set => productId = value;
        }

        public string ProductName
        {
            get => productName;
            set => productName = value;
        }

        public double ProductPrice
        {
            get => productPrice;
            set => productPrice = value;
        }

        public abstract double computeTax();
    }

   
}