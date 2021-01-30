namespace Set01.Entities
{
    class Product // tipo referencia
    {
        public string Name { get; set; }
        public double Price { get; set; }


        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

		public override int GetHashCode()
		{
            return Name.GetHashCode() + Price.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			if (!(obj is Product)) // prog defensiva
			{
				return false;
			}
			Product other = obj as Product; //downcast
			return Name.Equals(other.Name) && Price.Equals(other.Price);
		}


	}
}