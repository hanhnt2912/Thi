namespace Thi.entity
{
    public class Book : Product
    {
        

        public override double computeTax()
        {
            return ProductPrice * 5 / 100;

        }
    
}

}