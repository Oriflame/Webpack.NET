using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;

namespace Webpack.NET
{
    public class PathMappingService : IPathMappingService
    {
        public string MapPath(string path)
        {
            return HostingEnvironment.MapPath(path);
        }
    }
}
