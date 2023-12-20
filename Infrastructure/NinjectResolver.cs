using ExampleApp.Models;
using Ninject;
using Ninject.Extensions.ChildKernel;
using Ninject.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Dependencies;

namespace ExampleApp.Infrastructure
{
	public class NinjectResolver : IDependencyResolver, System.Web.Mvc.IDependencyResolver
	{
		private IKernel kernel;
		public NinjectResolver() : this(new StandardKernel()) { }
		public NinjectResolver(IKernel ninjectKernel)
		{
			kernel = ninjectKernel;

			AddBindings(kernel);

		}
		public IDependencyScope BeginScope()
		{
			return this;
			//return new NinjectResolver(AddRequestBindings(new ChildKernel(kernel)), true);
		}
		public object GetService(Type serviceType)
		{
			return kernel.TryGet(serviceType);
		}
		public IEnumerable<object> GetServices(Type serviceType)
		{
			return kernel.GetAll(serviceType);
		}
		public void Dispose()
		{
			// do nothing
		}
		private void AddBindings(IKernel kernel)
		{
			//singleton  
			kernel.Bind<IRepository>().To<Repository>().InSingletonScope();
			////request scope 
			//kernel.Bind<IRepository>().To<Repository>().InRequestScope();

			////TRASIENT  
			//kernel.Bind<IRepository>().To<Repository>().InTransientScope();
		}
		private IKernel AddRequestBindings(IKernel kernel)
		{
			kernel.Bind<IRepository>().To<Repository>().InSingletonScope();
			return kernel;
		}
	}
}
