using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDotNetSite.Models
{
    public interface IParagraphRepository: IRepository<Paragraph>
    {
        //for registering to services
        IEnumerable<Paragraph> getByType(string type);
    }
}
