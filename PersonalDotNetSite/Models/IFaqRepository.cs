using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDotNetSite.Models
{
    public interface IFaqRepository: IRepository<WebsiteFAQ>
    {
        //for registering in services
    }
}
