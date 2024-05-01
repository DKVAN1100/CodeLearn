using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Run
{
    public class Run
    {
        public static async Task Main(string[] args)
        {
            var service = new Search.Service.Service();
            await service.RunBinaryTree();
        }
    }
}
