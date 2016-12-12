using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;

namespace Backend.WebApi.App_Start
{
    public interface IActionFilter : IFilter
    {

    }

    public class VersionCheckFilter : IFilter

    {
        bool IFilter.AllowMultiple
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}