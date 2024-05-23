using System;

public class Program{
    public static void Main() {
        // Datos dummy.
        var product1 = new Product { Id = 1, Name = "Product A", Price = 100.85M };
        var product2 = new Product { Id = 2, Name = "Product B", Price = 120.57M };

        var productRepository = new ProductRepository();

        // Create
        productRepository.Add(product1);
        productRepository.Add(product2);

        // Update
        product1.Price = 200.22M;
        productRepository.Update(product1);

        // Read by id
        var productSearch = productRepository.GetById(1);
        Console.WriteLine( "Product found : ");
        Console.WriteLine( $"{productSearch.Id}" );
        Console.WriteLine( $"{productSearch.Name}");
        Console.WriteLine( $"{productSearch.Price}");

        // Delete
        productRepository.Delete(2);

        // Read all
        var productList = productRepository.GetAll();

        foreach (var product in productList) {
            Console.WriteLine($"{product.Id}, {product.Name}, {product.Price}");
        }
    }
}