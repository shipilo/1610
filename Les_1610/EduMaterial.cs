namespace Les_1610
{
    enum Type
    {
        Book,
        Site,
        Video,
        Lecture
    }
    enum Carrier
    {
        Paper,
        Electronic,
        Both
    }
    enum Field
    {
        Mathematics,
        Biology,
        Phisics,
        IT
    }
    class EduMaterial : Good
    {        
        public Person Creator;
        public Carrier Carrier;
        public Type Type;
        public Field Field;
        public EduMaterial() { }
        public EduMaterial(string Name, Person Creator, Carrier Carrier, Type Type, Field Field)
        {
            this.Name = Name;
            this.Creator = Creator;
            this.Carrier = Carrier;
            this.Type = Type;
            this.Field = Field;
        }
        public EduMaterial(string Name, Person Creator, Carrier Carrier, Type Type, Field Field, uint Price, uint Quantity)
        {
            this.Name = Name;
            this.Creator = Creator;
            this.Carrier = Carrier;
            this.Type = Type;
            this.Field = Field;
            SetPrice(Price, "123");
            this.Quantity = Quantity;
        }        
    }
}
