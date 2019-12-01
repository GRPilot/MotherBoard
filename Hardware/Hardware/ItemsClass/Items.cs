using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware.ItemsClass
{
    class Items
    {
        private string Name { set; get; }
        private string Description { set; get; }

        public Items()
        { }

        public string GetName()
        {
            return this.Name;
        }
        public string GetDescription()
        {
            return this.Description;
        }


        public void SetName(string outName)
        {
            this.Name = outName;
        }

        public void SetDescription(string outDesc)
        {
            this.Description = outDesc;
        }
    }

    
}
