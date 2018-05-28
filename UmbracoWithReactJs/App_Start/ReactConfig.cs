using System;
using System.IO;
using System.Reflection;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using React;
using React.AspNet;
using Microsoft.AspNetCore.Http;
[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(UmbracoWithReactJs.ReactConfig), "Configure")]

namespace UmbracoWithReactJs
{
	public static class ReactConfig
	{
		public static void Configure()
		{
			
		
			// If you want to use server-side rendering of React components, 
			// add all the necessary JavaScript files here. This includes 
			// your components as well as all of their dependencies.
			// See http://reactjs.net/ for more information. Example:
			//ReactSiteConfiguration.Configuration
			//	.AddScript("~/Scripts/First.jsx")
			//	.AddScript("~/Scripts/Second.jsx");

			// If you use an external build too (for example, Babel, Webpack,
			// Browserify or Gulp), you can improve performance by disabling 
			// ReactJS.NET's version of Babel and loading the pre-transpiled 
			// scripts. Example:
			//ReactSiteConfiguration.Configuration
			//	.SetLoadBabel(false)
			//	.AddScriptWithoutTransform("~/Scripts/bundle.server.js")
		
				ReactSiteConfiguration.Configuration.SetUseDebugReact(true);
				ReactSiteConfiguration.Configuration.SetReuseJavaScriptEngines(false);
				ReactSiteConfiguration.Configuration
					.SetLoadBabel(true)
					.SetLoadReact(true)
					.AddScriptWithoutTransform("~/app/build/static/js/server.js");
			
				//Display or log the error based on your application.
			}
			

		}
	}
