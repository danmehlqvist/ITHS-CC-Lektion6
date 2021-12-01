// See https://aka.ms/new-console-template for more information
using DependencyInversion_start;

Console.WriteLine("Hello, World!");


ProductService productService = new ProductService();

var products = productService.GetProducts();

foreach(var product in products)
{
    Console.WriteLine(product);
}