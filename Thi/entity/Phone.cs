namespace Thi.entity
{
    public class phone : Product
    {
        public override double computeTax()
        {
            return ProductPrice * 10/ 100;

        }

     
        
    }
}