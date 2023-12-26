namespace CleanCodeConsole.Principles;

public class AvoidingRepetition
{
    #region ProductPrice-BadPractice
    public void AddProduct(Product product)
    {
        //Product Validate
        double productPrice = product.Price * (product.Price * product.Tax);
        //Product Operations
    }

    public void UpdateProduct(Product product)
    {
        //Product Validate
        double productPrice = product.Price * (product.Price * product.Tax);
        //Product Operations
    }
    #endregion

    #region ProductPrice-CleanCode
    public void AddProduct(Product product)
    {
        //Product Validate
        double productPrice = CalculateTotalPrice(product.Price, product.Tax);
        //Product Operations
    }

    public void UpdateProduct(Product product)
    {
        //Product Validate
        double productPrice = CalculateTotalPrice(product.Price, product.Tax);
        //Product Operations
    }

    private double CalculateTotalPrice(double price, double tax) => price + (price * tax);
    #endregion
}

#region Nested
public class Product
{
    public double Price { get; set; }
    public double Tax { get; set; }
    public double TotalPrice => Price + (Price * Tax);
}
#endregion