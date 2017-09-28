using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.InventorySystem
{
    public enum ItemType
    {
        None,
        NormalItem,
        ExpItem,
        Resource,
    }

    public enum ItemClass
    {
        None,
        Weapon,
        Head,
        Chest,
        Legs,
        Accessorie,
        Hand
    }

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
        [SerializeField]
        private bool isStackable;

        [SerializeField] private bool hideInventory;

        [SerializeField] private ItemType itemType;
        [SerializeField] private ItemClass itemClass;

        public ItemType ItemType
        {
            get { return itemType; }
            set { itemType = value; }
        }

        public ItemClass ItemClass
        {
            get { return itemClass; }
            set { itemClass = value; }
        }

        public bool HideInventory
        {
            get { return hideInventory; }
            set { hideInventory = value; }
        }

        public bool IsStackable
        {
            get { return isStackable; }
            set { isStackable = value; }
        }

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

    [Serializable]
    public class ItemVisual
    {
        [SerializeField]
        private uint itemDataId;

        [SerializeField] private Sprite itemSprite;

        public uint ItemDataId
        {
            get { return itemDataId; }
            set { itemDataId = value; }
        }

        public Sprite ItemSprite
        {
            get { return itemSprite; }
            set { itemSprite = value; }
        }
    }
}
