using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroQuery.Models
{
    public class ResultModel<T>
    {
        public int code { get; set; }
        public string msg { get; set; }
        public int count { get; set; }
        public List<T> data { get; set; }

        /// <summary>
        /// 返回排行榜信息
        /// </summary>
        public List<Rangking> rangkingList { get; set; }

    }

    public class Rangking
    {
        /// <summary>
        /// 序列号
        /// </summary>
        public int numId { get; set; }
        /// <summary>
        /// 英雄名
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 显示次数
        /// </summary>
        public int occurrenceCount { get; set; }
    }
}
