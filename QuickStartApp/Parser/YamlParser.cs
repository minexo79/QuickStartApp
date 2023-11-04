using QuickStartApp.Models;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace QuickStartApp.Parser
{
    public class YamlParser
    {
        internal string yamlFileName    { get => "AppData.yaml"; }
        internal string filePath        { get => Application.LocalUserAppDataPath; }

        ISerializer     serializer;
        IDeserializer   deserializer;

        /// <summary>
        /// 實體化函式
        /// </summary>
        public YamlParser() 
        {
            // 實體化Serializer與Deserilizer物件
            serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            FileCheckAndCreate();   
        }

        private void FileCheckAndCreate()
        {
            var _path = Path.Combine(filePath, yamlFileName);

            // 檢查檔案是否存在
            if (!File.Exists(_path))
            {
                // 創建yaml設定檔
                FileStream stream = File.Create(_path);
                stream.Close();

                // 載入初始檔案結構並序列化成Yaml字串
                var sampleList = new ApplicationModelList().GetSimpleApplicationList();
                var yaml = serializer.Serialize(sampleList);

                // 將序列化好的字串寫入至yaml
                File.WriteAllText(_path, yaml);  
            }
        }

        public List<ApplicationModel> Open()
        {
            var _path = Path.Combine(filePath, yamlFileName);

            // 開啟檔案並讀取yaml內全部文字
            string buffer = File.ReadAllText(_path);
            // 反序列化
            var p = deserializer.Deserialize<ApplicationModelList>(buffer);

            // 回傳反序列化後的清單
            return p.Apps;
        }
    }
}
