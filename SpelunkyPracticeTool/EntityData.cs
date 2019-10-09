using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpelunkyPracticeTool
{
    class EntityData
    {
        public int Address;
        public string Name;
        public string[] Values;
        public bool ShowValues = false;

        public EntityData(int ptr)
        {
            Address = ptr;

            Name = ((AllEntities)Memory.ReadInt32(ptr + 0xC)).ToString();
            UpdateValues();
        }

        public EntityData UpdateValues()
        {
            Values = new string[]{
                $"Address: {Address:X}",
                $"X: {Memory.ReadFloat(Address+0x30)} Y: {Memory.ReadFloat(Address+0x34)}",
                $"Layer: {Memory.ReadFloat(Address+0x40)} OrigLayer: {Memory.ReadFloat(Address+0x44)}",
            };

            return this;
        }
    }
}
