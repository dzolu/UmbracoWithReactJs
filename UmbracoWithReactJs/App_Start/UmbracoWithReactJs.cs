using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Examine;
using Umbraco.Core;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using UmbracoWithReactJs.Controllers;
using UmbracoWithReactJs.Helpers;
using UmbracoWithReactJs.Models;
using UmbracoWithReactJs.Model_Adapter;
using UmbracoWithReactJs.Model_Adapter.Interafaces;

namespace UmbracoWithReactJs
{
    public class UmbracoWithReactJsStartup : IApplicationEventHandler
    {
        public void OnApplicationInitialized(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
        }

        public void OnApplicationStarting(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            // Register custom default controller
            DefaultRenderMvcControllerResolver.Current.SetDefaultControllerType(typeof(DefaultController));
        }

        public void OnApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            // This project uses dependency injection
            // Read more about umbraco and dependency injection here:
            // https://glcheetham.name/2016/05/27/implementing-ioc-in-umbraco-unit-testing-like-a-boss/
            // https://glcheetham.name/2017/01/29/mocking-umbracohelper-using-dependency-injection-the-right-way/


            var umbracoContext = umbracoApplication.Context.GetUmbracoContext();

            var builder = new ContainerBuilder();

            var umbracoHelper = new UmbracoHelper(umbracoContext);

            // Register our controllers from this assembly with Autofac
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            // Register controllers from the Umbraco assemblies with Autofac
            builder.RegisterControllers(typeof(UmbracoApplication).Assembly);
            builder.RegisterApiControllers(typeof(UmbracoApplication).Assembly);
            // Register the types we need to resolve with Autofac
            builder.RegisterInstance(ExamineManager.Instance).As<ExamineManager>();
            builder.RegisterInstance(umbracoHelper.ContentQuery).As<ITypedPublishedContentQuery>();
        
            //Model adapters
            builder.RegisterType<MasterModelAdapter>().As<IModelAdapter<MasterModel>>();
            builder.RegisterType<MetaDataModelAdapter>().As<IModelAdapter<MetaDataModel>>();     
            builder.RegisterType<ImageModelAdapter>().As<IModelAdapter<ImageModel>>();  
            builder.RegisterType<InitialStateModelAdapter>().As<IModelAdapter<InitialState>>();            
            builder.RegisterType<RequestModelAdapter>().As<IModelAdapter<RequestModel>>();
            builder.RegisterType<BlogModelAdapter>().As<IModelAdapter<BlogModel>>();
            builder.RegisterType<BlogPostModelAdapter>().As<IModelAdapter<BlogPostModel>>();
            builder.RegisterType<ContactModelAdpater>().As<IModelAdapter<ContactModel>>();
            builder.RegisterType<ContentPageModelAdapter>().As<IModelAdapter<ContentPageModel>>();
            builder.RegisterType<DetailsModelAdapter>().As<IModelAdapter<DetailsModel>>();
            builder.RegisterType<FeatureModelAdapter>().As<IModelAdapter<FeatureModel>>();
            builder.RegisterType<FooterHomeModelAdapter>().As<IModelAdapter<FooterHomeModel>>();
            builder.RegisterType<HeroModelAdapter>().As<IModelAdapter<HeroModel>>();
            builder.RegisterType<HomeModelAdapter>().As<IModelAdapter<HomeModel>>();
            builder.RegisterType<RequestModelAdapter>().As<IModelAdapter<RequestModel>>();
            builder.RegisterType<PeopleModelAdapter>().As<IModelAdapter<PeopleModel>>();
            builder.RegisterType<PersonModelAdapter>().As<IModelAdapter<PersonModel>>();
            builder.RegisterType<ProductDetailsModelAdapter>().As<IModelAdapter<ProductDetailsModel>>();
            builder.RegisterType<ProductModelAdapter>().As<IModelAdapter<ProductModel>>();
            builder.RegisterType<ProductsModelAdapter>().As<IModelAdapter<ProductsModel>>();
            builder.RegisterType<SocialModelAdapter>().As<IModelAdapter<SocialModel>>();
            builder.RegisterType<ContentModelAdapter>().As< IModelAdapter<ContentModel>>();
            
            
            
        
            //helper            
            builder.RegisterType<HttpContext>().As<IHttpContext>().InstancePerRequest();
            
            // Set up MVC to use Autofac as a dependency resolver
            var container = builder.Build();
            System.Web.Mvc.DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            // And WebAPI
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}