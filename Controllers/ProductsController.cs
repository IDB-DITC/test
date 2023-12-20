using ExampleApp.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExampleApp.Controllers
{
    public class ProductsController : ApiController
    {

		IRepository repo;
		
		//public ProductsController()
		//{
		//	repo = Repository.Current;
		//}


		public ProductsController(IRepository _repo)
		{
			repo = _repo;
		}

		public IHttpActionResult GetAll()
		{
			return Json(repo.Products);
		}

		//public IEnumerable<Product> GetAll()
		//{
		//	return repo.Products;
		//}
		public Product GetById(int id)
		{
			return repo.GetProduct(id);
		}
		[HttpGet]
		[Route("api/products/noop")]
		public IHttpActionResult NoOp()
		{
			return Ok("test ok");
		}




		public Product PostProduct(Product product)
		{
			return repo.SaveProduct(product);
		}

		

		public Product PutProduct(Product product)
		{
			return repo.UpdateProduct(product);
		}

		public IHttpActionResult DeleteProduct(int id)
		{
			 repo.DeleteProduct(id);

			return ResponseMessage(new HttpResponseMessage(HttpStatusCode.Accepted));

			//return StatusCode(System.Net.HttpStatusCode.Accepted);
			//return Ok();

		}
	}
}
