using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational
{
    //Defines a generic factory
    public interface IAbstractFactory
    {
        public MinecraftBlock CreateMinecraftBlock();
        public MinecraftItem CreateMinecraftItem();
    }
    // It is a specialized factory 
    // Generates blocks and items that belong to Nether Dimension
    public class NetherFactory : IAbstractFactory
    {
        public MinecraftBlock CreateMinecraftBlock()
        {
            return new NetherMinecraftBlock();
        }

        public MinecraftItem CreateMinecraftItem()
        {
            return new NetherMinecraftItem();
        }
    }
    // It is a specialized factory 
    // Generates blocks and items that belong to Nether Dimension
    public class OverWorldFactory : IAbstractFactory
    {
        public MinecraftBlock CreateMinecraftBlock()
        {
            return new OverWorldMinecraftBlock();
        }

        public MinecraftItem CreateMinecraftItem()
        {
            return new OverWorldMinecraftItem();
        }
    }

    
}
