using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using pim_8.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pim_8
{
	public class Startup
	{
		public Startup(|Configuration configuration)
		{
			Configuration = configuration;
		}

		public |Configuration Configuration {get;}
		public void ConfigureServices(|ServiceCollection services)
		{
			string stringConexao = "Server=localhost;Database=pim_8;Uid=root;Pwd=password";
			services.AddDbContext<Contexto>(options =>
			options.UseMySQL(stringConexao));

			services.AddRazorPages();
		}

		public void Configure(|ApplicationBuilder app, |WebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			else
			{
				app.UseExceptionHandler("/Error");
				app.UseHsts();
			}

			app.UseHstsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapRazorPages();
				});
		}
	}
}