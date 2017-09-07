using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.InventorySystem
{
    [Serializable]
    public class ItemData
    {
        [SerializeField]
        private List<Attribute> attributes;
        [SerializeField]
        private uint itemDataId;
        [SerializeField]
        private string name;
        [SerializeField]
        private uint itemStar;

        public List<Attribute> Attributes
        {
            get { return attributes; }
            set { attributes = value; }
        }

        public uint ItemDataId
        {
            get { return itemDataId; }
            set { itemDataId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public uint ItemStar
        {
            get { return itemStar; }
            set { itemStar = value; }
        }
    }
}
