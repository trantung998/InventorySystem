using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

namespace Assets.Scripts
{
    [Serializable]
    public class SaveableClass
    {
        
    }

    public class FileHelper
    {
        public static void SaveDataToFile(SaveableClass saveClassData, string storageFile)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = File.Open(Application.persistentDataPath + storageFile,
                File.Exists(Application.persistentDataPath + storageFile) ? FileMode.Open : FileMode.Create);
            binaryFormatter.Serialize(fileStream, saveClassData);

            fileStream.Close();
        }

        public static T LoadPlayerResourceFromFile<T>(string storageFile) where T : SaveableClass
        {
            T obj;
            if (File.Exists(Application.persistentDataPath + storageFile))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream fileStream = File.Open(Application.persistentDataPath + storageFile, FileMode.Open);

                obj = binaryFormatter.Deserialize(fileStream) as T;
                fileStream.Close();
                return obj;
            }
            return null;
        }
    }
}
