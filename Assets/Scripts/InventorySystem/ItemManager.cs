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

        private List<UserItem> GetUserItemList()
        {
            return userItemManager.UserData.UserItemList;
        }

        private void InitData()
        {
            //item visual
            itemVisualDic = itemDatabase.ItemVisualList.Distinct().ToDictionary(x=>x.ItemDataId, x=>x.ItemSprite);
            itemDataDic = itemDatabase.ItemDataList.Distinct().ToDictionary(x=>x.ItemDataId, x=>x);
        }

        public ItemData GetItemData(uint itemId)
        {
            if (itemDataDic.ContainsKey(itemId)) return itemDataDic[itemId];
            return null;
        }

        public ItemData GetItemRawData(uint itemId)
        {
            if (itemDataDic.ContainsKey(itemId)) return itemDataDic[itemId];
            return null;
        }

        public void AddItem(uint itemId, int value = 1)
        {
            var itemData = GetItemData(itemId);
            if(itemData == null) return;
            AddItem(itemData, value);
        }

        public void AddItem(ItemData item, int value = 1)
        {
            var newItem = new UserItem()
            {
                ItemId = GetItemId(item), UpgradeLevel = 0, Value = value, IsLock = false
            };
            userItemManager.UserData.UserItemList.Add(newItem);
        }

        public void DeleteItem(string itemId, int itemValue = 1)
        {
            var userItems = userItemManager.UserData.UserItemList;

            for (int i = 0; i < userItems.Count; i++)
            {
                if (userItems[i].ItemId != itemId) continue;

                userItems[i].Value -= itemValue;
                if (userItems[i].Value <= 0)
                {
                    userItems.RemoveAt(i);
                }
            }

        }

        private string GetItemId(ItemData item)
        {
            var itemId = item.ItemDataId;
            return string.Format("item{0}_{1}", itemId, DateTime.UtcNow.Ticks);
        }
    }
}
