using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStartApp.Models
{
    /// <summary>
    /// 應用程式模型
    /// </summary>
    public class ApplicationModel
    {
        /// <summary>
        /// 應用程式名稱
        /// </summary>
        public string AppName { get; set; }
        /// <summary>
        /// 應用程式路徑
        /// </summary>
        public string AppPath { get; set; }
        /// <summary>
        /// 儲存在Img資料夾內的圖示名稱
        /// </summary>
        public string ImgName { get; set; }
    }

    public class ApplicationModelList
    {
        /// <summary>
        /// 應用程式清單
        /// </summary>
        public List<ApplicationModel> Apps { get; set; }

        /// <summary>
        /// 傳回示範用的應用程式清單
        /// </summary>
        /// <returns>示範用的應用程式清單，為List格式</returns>
        public ApplicationModelList GetSimpleApplicationList()
        {
            ApplicationModelList simpleList = new ApplicationModelList()
            {
                Apps = new List<ApplicationModel>
                {
                    new ApplicationModel { AppName="NotePad", AppPath="NotePad.exe", ImgName="SampleApp" },
                }
            };

            return simpleList;
        }
    }
}