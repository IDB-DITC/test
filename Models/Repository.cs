using System.Collections.Generic;

namespace ExampleApp.Models
{
	public class Repository : IRepository
	{
		private Dictionary<int, Product> data;

		//private static Repository repo;

		//static Repository()
		//{
		//	repo = new Repository();
		//}





		//public static Repository Current
		//{
		//	get { return repo; }
		//}

		public Repository()
		{
			Product[] products = new Product[] {
			 new Product {ProductID = 1, Name = "Kayak", Price = 275M },
			 new Product {ProductID = 2, Name = "Lifejacket", Price = 48.95M },
			new Product {ProductID = 3, Name = "Soccer Ball", Price = 19.50M },
			 new Product {ProductID = 4, Name = "Thinking Cap", Price = 16M },
			 };

			data = new Dictionary<int, Product>();
			foreach (Product prod in products)
			{
				data.Add(prod.ProductID, prod);
			}
		}
		public IEnumerable<Product> Products
		{
			get { return data.Values; }
		}
		public Product GetProduct(int id)
		{
			return data[id];
		}
		public Product SaveProduct(Product newProduct)
		{
			newProduct.ProductID = data.Keys.Count + 1;

			//data.Add(newProduct.ProductID, newProduct);
			//return newProduct;




			return data[newProduct.ProductID] = newProduct;
		}
		public Product UpdateProduct(Product editProduct)
		{
			//newProduct.ProductID = data.Keys.Count + 1;

			//data.Add(newProduct.ProductID, newProduct);
			//return newProduct;

			return data[editProduct.ProductID] = editProduct;
		}
		public void DeleteProduct(int id)
		{

			#region test collection

			//List<string> names = new List<string>();



			//	names.Add("IDB");

			//names.AddRange(new[] { "IDB", "R55", "DITC" });


			//string n = names[3];





			//Dictionary<string, string> contacts = new Dictionary<string, string>();




			//contacts.Add("a1", "111111111");
			//contacts.Add("a2", "22222222");
			//contacts.Add("a3", "333333");
			//contacts["a4"] = "444444444";


			//var d = contacts["a2"];


			//var list = contacts;


			//foreach (var item in contacts)
			//{
			//	item.Value
			//}

			#endregion


			Product prod = data[id];
			if (prod != null)
			{
				data.Remove(id);
			}
			//return prod;
		}
	}




}