namespace ProductStore;

class Program
{
    private const int MinNumberOfProducts = 1;
    private const int MaxNumberOfProducts = 30;

    static void Main(string[] args)
    {
        DisplayIntroduction();

        Console.WriteLine("Enter number of products between {0} and {1} (inclusive): ", MinNumberOfProducts, MaxNumberOfProducts);
        int num = InputValue(MinNumberOfProducts, MaxNumberOfProducts);

        Product[] product = new Product[num];

        GetProductData(product);

        DisplayAllProducts(product);

        GetProductLists(product);

    }

    // Project intro and author details
    public static void DisplayIntroduction()
    {
        Console.WriteLine("********************************************************");
        Console.WriteLine("****                                                ****");
        Console.WriteLine("****               IFN556 Assessment II             ****");
        Console.WriteLine("****  THIS PROGRAM STORE AN ARRAY OF PRODUCTS AND   ****");
        Console.WriteLine("****  DISPLAY THE PRODUCTS BY CATEGORY BASED ON THE ****");
        Console.WriteLine("****  CATEGORY SELECTED BY THE USER.                ****");
        Console.WriteLine("****                       ---                      ****");
        Console.WriteLine("****                Name: Sonam Dargay              ****");
        Console.WriteLine("****                  ID: N11684097                 ****");
        Console.WriteLine("****                                                ****");
        Console.WriteLine("********************************************************\n");
    }

    // Get an number between min and max (inclusive) from user
    public static int InputValue(int min, int max)
    {
        int value;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out value)
                && value >= min && value <= max)
            {
                return value;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }

    // Check whether the format is valid or not
    public static bool CheckString(string id)
    {
        return id.Length == 4 && Char.IsLower(id[0]) && id[1] == '-'
            && Char.IsDigit(id[2]) && Char.IsDigit(id[3]);
    }

    // Method to create an array of products
    private static void GetProductData(Product[] products)
    {
        Console.WriteLine("******************************************************");
        for (int i = 0; i < products.Length; i++)
        {
            // Get product ID
            Console.WriteLine("\nEnter details for product: {0}", i+1);
            string productID;
            do
            {
                Console.WriteLine("ProductID starts with lowercase char and one hyphen, and ends with 2 digits, eg. a-12");
                Console.WriteLine("\nEnter Product ID: ");
                
                productID = Console.ReadLine();

            } while (!CheckString(productID));

            // Get product name
            Console.WriteLine("Enter product name: ");
            string productName = Console.ReadLine();

            // Get product quantity
            Console.WriteLine("Enter product quantity: ");
            int productQuantity = InputValue(MinNumberOfProducts, MaxNumberOfProducts);

            // Get product price
            Console.Write("Enter Product Price: ");
            double productPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("------NEXT Product----");

            products[i] = new Product(productID, productName, productQuantity, productPrice);
        }
        Console.WriteLine("******************************************************");
    }

    // Method to display products
    public static void DisplayAllProducts(Product[] products)
    {
        Console.WriteLine("******************************************************");
        Console.WriteLine("Displaying information of all Products: ");
        Console.WriteLine("******************************************************");
        foreach (Product product in products)
        {
            Console.WriteLine(product.ToString());
        }
    }


    // View information of products by category
    private static void GetProductLists(Product[] products)
    {
        Console.WriteLine("******************************************************");
        Console.WriteLine("     Valid Product Categories");
        Console.WriteLine("******************************************************");
        for (int i = 0; i < Product.categoryCodes.Length; i++)
        {
            Console.WriteLine($"{i+1}. {Product.categoryCodes[i]} -> {Product.categoryNames[i]}");
        }

        while (true)
        {
            Console.Write("Enter a category code to display products (or 'q' to quit): ");
            string categoryCode = Console.ReadLine();

            if (categoryCode == "q")
                break;

            // Gives the index of category in the codes array, returns -1 when not found
            int index = Array.IndexOf(Product.categoryCodes, categoryCode);

            if (index != -1)
            {
                Console.WriteLine("******************************************************");
                Console.WriteLine($"     Products in {Product.categoryNames[index]}");
                Console.WriteLine("******************************************************");
                int count = 0;
                foreach (Product product in products)
                {
                    if (product.ProductID.StartsWith(categoryCode))
                    {
                        Console.WriteLine(product);
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("No products in this category.");
                }
            }
            else
            {
                Console.WriteLine("Invalid category code. Please try again.");
            }
            Console.WriteLine("******************************************************");
        }
    }
}

public class Product
{
    // Arrays for category codes and names
    public static string[] categoryCodes = { "a-", "b-", "f-", "t-", "o-" };
    public static string[] categoryNames = { "Apparel", "Books", "Foods", "Toys", "Others" };


    // datafields for productID and productCategoryName
    public string productID;
    public string productCategoryName;

    public string ProductID
    {
        get
        {
            return productID;
        }

        set
        {
            productID = value;
        }
    }

    public string ProductCategoryName
    {
        get
        {
            return productCategoryName;
        }
        set
        {
            productCategoryName = value;
        }
    }


    // Auto-implemented properties
    public string ProductName { get; set; }

    public int ProductQuantity { get; set; }

    public double ProductPrice { get; set; }


    // Product constructors
    public Product()
    {

    }

    public Product(string id, string name, int quantity, double price)
    {
        ProductID = SetProductID(id);
        ProductName = name;
        ProductQuantity = quantity;
        ProductPrice = price;
    }

    // Method to set product id based on user input
    public string SetProductID(string id)
    {
        string validCategory = "o-";
        foreach (string categoryCode in categoryCodes)
        {
            if (id.StartsWith(categoryCode) && id.Length == 4)
            {
                validCategory = categoryCode;
                break;
            }
        }

        ProductCategoryName = categoryNames[Array.IndexOf(categoryCodes, validCategory)];
        return validCategory + id.Substring(2);
    }

    // Method for customizing native ToString()
    public override string ToString()
    {
        return $"Product ID: {ProductID}\n"
            + $"\tProduct Name: {ProductName}\n"
            + $"\tCategory: {ProductCategoryName}\n"
            + $"\tQuantity: {ProductQuantity}\n"
            + $"\tPrice: {ProductPrice:C}";
    }

}

