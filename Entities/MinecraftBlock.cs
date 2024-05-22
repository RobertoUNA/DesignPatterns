using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class MinecraftBlock
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }

    public class OverWorldMinecraftBlock : MinecraftBlock
    { 
       
    }
    public class NetherMinecraftBlock : MinecraftBlock { }
    public class OverWorldMinecraftItem : MinecraftItem { }
    public class NetherMinecraftItem : MinecraftItem { }
}
