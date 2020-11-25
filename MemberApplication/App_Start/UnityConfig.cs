using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace MemberApplication
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            //container.RegisterType<IMemberService, MemberServiceADO>();
           // container.RegisterType<IMemberService, MemberServiceEDM>();

           // DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}