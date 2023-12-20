using System.Collections.Generic;

namespace ExampleApp.Models
{
	public interface IRepository
	{
		IEnumerable<Product> Products { get; }

		void DeleteProduct(int id);
		Product GetProduct(int id);
		Product SaveProduct(Product newProduct);
		Product UpdateProduct(Product editProduct);
	}
}