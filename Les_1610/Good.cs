namespace Les_1610
{
    abstract class Good : Property
    {
        public string Name;
        public bool EnabledForSale;
        public uint Quantity;

        private uint price;
        public uint Price
        {
            get => price;            
        }
        public bool SetPrice(uint Price, string Password)
        {
            if (Password == "123")
            {
                price = Price;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void PutUpForSale()
        {
            if (Price != 0 && Quantity != 0)
            {
                EnabledForSale = true;
            }
        }
        public void PutUpForSale(uint Price, uint Quantity)
        {
            if (SetPrice(Price, "123"))
            {
                EnabledForSale = true;
                this.Quantity = Quantity;
            }
        }
        public void PutAwayFromSale()
        {
            EnabledForSale = false;
        }
        public void ToSell(uint Number)
        {
            if (Quantity >= Number)
            {
                Quantity -= Number;
            }
        }
    }
}
