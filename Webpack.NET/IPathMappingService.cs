using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webpack.NET
{
    public interface IPathMappingService
    {
        string MapPath(string path);
    }
}
