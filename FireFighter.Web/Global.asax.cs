using Autofac;
using Autofac.Features.ResolveAnything;
using Autofac.Integration.Mvc;
using AutoMapper;
using DotNetOpenAuth.OAuth;
using FireFighter.Core.Domain;
using FireFighter.Data;
using FireFighter.Data.UnitOfWork;
using FireFighter.Service.AboutPageFolder;
using FireFighter.Service.AnimalServiceFolder;
using FireFighter.Service.AutoMapper;
using FireFighter.Service.AwardService;
using FireFighter.Service.AwardServiceFolder;
using FireFighter.Service.DTOs;
using FireFighter.Service.ItemServiceFolder;
using FireFighter.Service.PlaceServiceFolder;
using FireFighter.Service.PlayerServiceFolder;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace FireFighter.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var builder = new ContainerBuilder();
            #region Services
            MapperConfiguration config = AutoMapperConfiguration.Configure();

            IMapper mapper = config.CreateMapper();

            builder.RegisterInstance(mapper);
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType(typeof(AutoMapperConfiguration));
            builder.RegisterGeneric(typeof(EfRepository<>)).As(typeof(IRepository<>)).InstancePerDependency();
            builder.RegisterType<FireFighterDBContext>().InstancePerLifetimeScope();
            builder.RegisterType<AnimalService>().As<IAnimalService>().InstancePerLifetimeScope();
            builder.RegisterType<AwardService>().As<IAwardService>();
            builder.RegisterType<ItemService>().As<IItemService>();
            builder.RegisterType<PlaceAnimalService>().As<IPlaceAnimalService>();
            builder.RegisterType<PlaceItemsService>().As<IPlaceItemService>();
            builder.RegisterType<PlaceService>().As<IPlaceService>();
            builder.RegisterType<PlayerService>().As<IPlayerService>();
            builder.RegisterType<PlayerAwardService>().As<IPlayerAwardService>();
            builder.RegisterType<AthenticationService>().As<IAuthenticationService>();
            builder.RegisterType<AboutUsService>().As<IAboutUsService>();
            builder.RegisterType<AskedQuestionService>().As<IAskedQuestionService>();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            builder.RegisterType<SecuritySettings>().As<SecuritySettings>();

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            #endregion
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
