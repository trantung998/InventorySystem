using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.InventorySystem
{
    public class ItemManager : MonoBehaviour
    {
        private ItemDatabase itemDatabase;
        private UserItemManager userItemManager;

        Dictionary<uint, Sprite> itemVisualDic = new Dictionary<uint, Sprite>();
        Dictionary<uint, ItemData> itemDataDic = new Dictionary<uint, ItemData>();
        void Start()
        {
            itemDatabase = Resources.Load("Data/ItemData/Item Visuals") as ItemDatabase;
            userItemManager = new UserItemManager();
        }

        private void InitData()
        {
            //item visual
            itemVisualDic = itemDatabase.ItemVisualList.Distinct().ToDictionary(x=>x.ItemDataId, x=>x.ItemSprite);
            itemDataDic = itemDatabase.ItemDataList.Distinct().ToDictionary(x=>x.ItemDataId, x=>x);
        }

        public ItemData GetItemRawData(uint itemId)
        {
            if (itemDataDic.ContainsKey(itemId)) return itemDataDic[itemId];
            return null;
        }

        public void AddItem(uint itemId, int value = 1)
        {
            
        }

        public void AddItem(ItemData item, int value = 1)
        {
            
        }
    }
}
