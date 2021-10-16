namespace Les_1610
{    
    class Program
    {
        static void Main(string[] args)
        {
            EduMaterial myBook = new EduMaterial("Книга", new Person(), Carrier.Paper);
            myBook.Creator.FirstName = "Anna";
            myBook.Creator.SecondName = "Shipilo";
            //myBook.Price = 30; - ошибка, так как цена только для чтения
            myBook.SetPrice(30, "123");
            myBook.Quantity = 100;
            myBook.PutUpForSale();
        }
    }
}
