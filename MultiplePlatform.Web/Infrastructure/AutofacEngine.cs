using Autofac;
using MultiplePlatform.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Autofac.Integration.Mvc;
using System.Web.Routing;
using MultiplePlatform.Service;
using MultiplePlatform.Common;
using System.IO;

namespace MultiplePlatform.Web.Infrastructure
{
    public class AutofacEngine
    {
        /// <summary>
        /// 注册容器
        /// </summary>
        public static void RegisterAutofac()
        {
            var builder = new ContainerBuilder();

            // Register your MVC controllers. (MvcApplication is the name of
            // the class in Global.asax.)
            builder.RegisterControllers(typeof(MvcApplication).Assembly);


            #region IOC注册区域
            //参数模式的注入
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();
            //Admin
            Type baseType = typeof(IDependency);
            Assembly[] assemblies = Directory.GetFiles(AppDomain.CurrentDomain.RelativeSearchPath, "*.dll").Select(Assembly.LoadFrom).ToArray();
            builder.RegisterAssemblyTypes(assemblies) .Where(type => baseType.IsAssignableFrom(type) && !type.IsAbstract).AsImplementedInterfaces().InstancePerLifetimeScope();//InstancePerLifetimeScope 保证对象生命周期基于请求
            //builder.RegisterType<CapitalService>().As<ICapitalService>().InstancePerLifetimeScope();
           // builder.RegisterType<Test>().As<ITest>().InstancePerLifetimeScope();
            #endregion


            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }

    }
}