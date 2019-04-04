using System.IO;

namespace StockApp
{
    public class XmlAdder : IAdder
    {

        public void AddProduct(Product product)
        {
            using (FileStream stream = new FileStream("data.xml", FileMode.OpenOrCreate))
            {
                if (stream.Length > 0)
                    stream.Position = stream.Length - 1;

                System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(product.GetType());

                xmlSerializer.Serialize(stream, product);
            }
        }
    }
}
