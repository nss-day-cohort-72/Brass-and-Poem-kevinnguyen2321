
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
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


//implement your loop here
 int userChoice = 0;

 while (userChoice != 5)
 {
  Console.WriteLine("Please choose an option:");
  Console.WriteLine(@"
    1. DisplayMenu
    2. DisplayAllProducts
    3. DeleteProduct
    4. AddProduct
    5. UpdateProduct
");
   
   userChoice = int.Parse(Console.ReadLine());
   switch (userChoice)
   {
    case 1:
    DisplayMenu();
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
    throw new NotImplementedException();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }