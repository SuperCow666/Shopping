using Shopping.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Shopping.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ShoppingController : AbpController
    {
        protected ShoppingController()
        {
            LocalizationResource = typeof(ShoppingResource);
        }
    }
}