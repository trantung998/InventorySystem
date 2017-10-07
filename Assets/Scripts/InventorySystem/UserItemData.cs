using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.InventorySystem
{
    public class UserItemManager
    {
        private string uItemDataFile = "/u_item.data";
        private UserItemDataFile userData;

        public UserItemDataFile UserData
        {
            get { return userData; }
            set { userData = value; }
        }

        public UserItemManager()
        {
            ReadData();
        }

        private void ReadData()
        {
            userData = FileHelper.LoadPlayerResourceFromFile<UserItemDataFile>(uItemDataFile);
            if (userData == null)
            {
                userData = new UserItemDataFile();
                userData.UserItemList =  new List<UserItem>();
            }
        }

        private void SaveData()
        {
            FileHelper.SaveDataToFile(userData, uItemDataFile);
        }
    }

    [Serializable]
    public class UserItem
    {
        [SerializeField]
        private string itemId;
        [SerializeField]
        private int upgradeLevel;
        [SerializeField]
        private int value;
        [SerializeField]
        private bool isLock;

        public string ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

        public int UpgradeLevel
        {
            get { return upgradeLevel; }
            set { upgradeLevel = value; }
        }

        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public bool IsLock
        {
            get { return isLock; }
            set { isLock = value; }
        }
    }

    public class UserItemDataFile : SaveableClass
    {
        public List<UserItem> UserItemList;

        public UserItemDataFile()
        {
            UserItemList = new List<UserItem>();
        }
    }
}
