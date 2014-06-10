using System.Web.Mvc;

namespace MvcAreaAssignment.Areas.ContactDetails
{
    public class ContactDetailsAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "ContactDetails";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "ContactDetails_default",
                "ContactDetails/{controller}/{action}/{id}",
                defaults: new {controller = "Management", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Areas.ContactDetails.Controllers" }
            );
        }
    }
}

