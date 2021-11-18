using System;
using System.Collections.Generic;
using System.Text;
using Shopping.Localization;
using Volo.Abp.Application.Services;

namespace Shopping
{
    /* Inherit your application services from this class.
     */
    public abstract class ShoppingAppService : ApplicationService
    {
        protected ShoppingAppService()
        {
            LocalizationResource = typeof(ShoppingResource);
        }
    }
}
