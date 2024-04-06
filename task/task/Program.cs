namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Store store = new Store();
               
            Product product = new Product();
            product.Name = "Test123";
            product.Price = 10;
            product.Type = Core.Type.Baker;

            Product product1 = new Product();
            product1.Name = "Test345";
            product1.Price = 10;
            product1.Type = Core.Type.Meat;

            store.AddProduct(product);
            store.AddProduct(product1);

            string ansStr = Console.ReadLine();
            int ansInt = Convert.ToInt32(ansStr);

            foreach (Product prod in store.FilterProductByType((Core.Type)ansInt))
            {
                Console.WriteLine(prod);
            };


            //for (int i = 0; i < store.FilterProductByType(Core.Type.Meat).Length; i++)
            //{
            //    Console.WriteLine(store.FilterProductByType(Core.Type.Meat)[i]);
            //}
        }
    }
}
