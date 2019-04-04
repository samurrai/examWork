using System;

namespace StockApp
{
    public delegate void AdderDelegate(Product product);
    [Serializable]
    public class Product
    {
        public event AdderDelegate AddPressed;

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Volume { get; set; }
        public DateTime ArriveDate { get; set; }

        public Product()
        {
            Id = Guid.NewGuid();
        }

        public void Add()
        {
            AddPressed?.Invoke(this);
        }
    }
}
