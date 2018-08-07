using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SrednjeSkole_API.Models
{
    public partial class SrednjeSkoleEntities: DbContext
    {
        public SrednjeSkoleEntities(bool enableLazyLoading)
           : base("name=SrednjeSkoleEntities")
        {
            this.Configuration.LazyLoadingEnabled = enableLazyLoading;
        }
    }
}