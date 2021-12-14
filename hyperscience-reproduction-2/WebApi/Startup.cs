using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi
{
	public class Startup
	{
		public IConfiguration Configuration { get; }
		public IHostingEnvironment Environment { get; }

		public Startup(IConfiguration configuration, IHostingEnvironment environment)
		{
			Configuration = configuration;
			Environment = environment;
		}

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvcCore();
		}

		public void Configure(IApplicationBuilder app)
		{
			app.UseMvc();
		}
	}
}
