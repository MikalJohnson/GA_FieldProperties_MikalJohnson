namespace GA_FieldProperties_MikalJohnson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Understanding Class Fields and Properties");

            CustomerReview customerReview = new CustomerReview();
            customerReview.name = "Mikal";
            Console.WriteLine(customerReview.name);
            Console.WriteLine(customerReview.readOnlyName);
        } 
    }   
}