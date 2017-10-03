using System;

public class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}

Product product = new Product();

var productJson = JsonConvert.SerializeObject(product);

var productDeserilize = JsonConvert.DeserializeObject<Product>(productJson);
