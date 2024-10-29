
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
using System.Collections;

List <Product> products = new List<Product> () {
    new Product() {
        Name = "The Collected Poems of Robert Frost",
        Price = 14.99m,
        ProductTypeId = 1 
    },
    new Product() {
        Name = "Brass Trumpet",
        Price = 599.99m,
        ProductTypeId = 2 
    },
    new Product() {
        Name = "The Poetry of Maya Angelou",
        Price = 16.99m,
        ProductTypeId = 1
    },
    new Product() {
        Name = "Brass Trombone",
        Price = 499.99m,
        ProductTypeId = 2
    },
    new Product() {
        Name = "Modern American Poetry Anthology",
        Price = 20.00m,
        ProductTypeId = 1
    }
   
 };
//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
 List<ProductType> productTypes = new List<ProductType>() {
    new ProductType() {
        Title = "Poem",
        Id = 1
    },
    new ProductType() {
        Title = "Brass",
        Id = 2
    }
 };
//put your greeting here
Console.WriteLine("Hello and welcome to Brass & Poem");
 Console.WriteLine();


//implement your loop here
 int userChoice = 0;

 while (userChoice != 5)
 { 
     Console.WriteLine("Please choose an option:");
     DisplayMenu();
  
 
 
   
   userChoice = int.Parse(Console.ReadLine());
   
   switch (userChoice)
   {
    case 1:
        DisplayAllProducts(products,productTypes);
        break;

    case 2:
        DisplayAllProducts(products,productTypes);
        DeleteProduct(products,productTypes);
        break;

    case 3:
        AddProduct(products,productTypes);
        break;

    case 4:
        DisplayAllProducts(products,productTypes);
        UpdateProduct(products,productTypes);
        break;
    }


    
}


void DisplayMenu()
{
    
    Console.WriteLine(@"
    1. Display all products
    2. Delete a product
    3. Add a new product
    4. Update product properties
    5. Exit
    ");
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    List<string> productDisplay = products.Select((product, index) => {
         ProductType productType = productTypes.FirstOrDefault(type => type.Id == product.ProductTypeId);
         string productTypeName = productType.Title;
         return $"{index + 1}. {product.Name} ({productTypeName}) (${product.Price}) ";
    }).ToList();
    
    for (int i = 0; i < productDisplay.Count; i++)
  {
    Console.WriteLine(productDisplay[i]);
  }
  Console.WriteLine();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Please choose an option to delete");
    Console.WriteLine();
    int userSelection = int.Parse(Console.ReadLine());
    products.RemoveAt(userSelection - 1);
    Console.WriteLine("You have successfully removed a product");
    Console.WriteLine();

}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
   Console.WriteLine("Please enter name of product");
   string productName = Console.ReadLine();

   Console.WriteLine("Please enter price of product");
   decimal productPrice = decimal.Parse(Console.ReadLine());

   Console.WriteLine(@"Please choose a Product type:
   1. Poem
   2. Brass
   ");

   int productId = int.Parse(Console.ReadLine());

   Product newProduct = new Product() {
    Name = productName,
    Price = productPrice,
    ProductTypeId = productId
   };

   products.Add(newProduct);

}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Please choose a product to update");
    int userSelection = int.Parse(Console.ReadLine());

    Product selectedProduct = products[userSelection - 1];

    Console.WriteLine($"You chose {selectedProduct.Name}");

    Console.WriteLine("Please enter new name for product (Or press enter to keep current name)");

    string newProductName = Console.ReadLine();

    if (!string.IsNullOrEmpty(newProductName))
    {
     selectedProduct.Name = newProductName;
    }

    Console.WriteLine("Please enter new price for product (Or press enter to keep current price)");

   string newProductPrice = Console.ReadLine();
   if (!string.IsNullOrEmpty(newProductPrice))
    {
     selectedProduct.Price = decimal.Parse(newProductPrice);
    }

    Console.WriteLine(@"Please choose a product type(Press enter to keep current type):
    1. Poem
    2. Brass
    ");

    string newProductId = Console.ReadLine();
    
     if (!string.IsNullOrEmpty(newProductId))
    {
     selectedProduct.ProductTypeId = int.Parse(newProductId);
    }
}

// don't move or change this!
public partial class Program { }