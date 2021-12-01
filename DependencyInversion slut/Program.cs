// See https://aka.ms/new-console-template for more information
using DependencyInversion_slut;

Console.WriteLine("Hello, World!");


ProductService productService = new ProductService(new ProductRepo());

var products = productService.GetProducts( new ProductDiscount());

foreach(var product in products)
{
    Console.WriteLine(product);
}