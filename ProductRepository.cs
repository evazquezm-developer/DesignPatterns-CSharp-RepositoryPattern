
public class ProductRepository : IRepository<Product>
{
    private List<Product> _products;

    // Constructor
    public ProductRepository()
    {
        _products = new List<Product>();        
    }

    public IEnumerable<Product> GetAll()
    {
        return _products;
    }

    public Product GetById(int id)
    {        
        return _products.Find(x => x.Id == id);
    }

    public void Add(Product entity)
    {
        _products.Add(entity);
    }

    public void Update(Product entity)
    {
        var existingProduct = GetById(entity.Id);

        if ( existingProduct != null ) {
            existingProduct.Name = entity.Name;
            existingProduct.Price = entity.Price;
        }
        else {
            throw new InvalidOperationException("Product not found.");
        }
    }

    public void Delete(int id)
    {
        var productToRemove = GetById(id);

        if ( productToRemove != null ) {
            _products.Remove(productToRemove);
        }
        else {
            throw new InvalidOperationException("Product not found.");
        }
    }    
}