using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroQuery.Models
{
    public class BattleListVModel
    {
        public int Id { get; set; }
        public int ChampionId { get; set; }
        public string Item0 { get; set; }
        public string Item0Name { get; set; }
        public string Item0Img { get; set; } 

        public string Item1 { get; set; }
        public string Item1Name { get; set; }
        public string Item1Img { get; set; } 
        public string Item2 { get; set; }
        public string Item2Name { get; set; }
        public string Item2Img { get; set; } 
        public string Item3 { get; set; }
        public string Item3Name { get; set; }
        public string Item3Img { get; set; } 
        public string Item4 { get; set; }
        public string Item4Name { get; set; }
        public string Item4Img { get; set; } 
        public string Item5 { get; set; }
        public string Item5Name { get; set; }
        public string Item5Img { get; set; } 
        public string Item6 { get; set; }
        public string Item6Name { get; set; }
        public string Item6Img { get; set; } 
        public int Kills { get; set; }
        public int Deathss { get; set; }
        public int Assist { get; set; }
        /// <summary>
        /// 对局ID
        /// </summary>
        public string GameId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime GameCreationTime { get; set; }

        /// <summary>
        /// 胜利Win或失败Fail
        /// </summary>
        public string win { get; set; }

        public float KDA { get; set; }
        /// <summary>
        /// 是否重开，0：正常，1：重开
        /// </summary>
        public int GameEndedInEarlySurrender { get; set; }



        public string championName { get; set; }
        public string HeroId { get; set; }

        public string title { get; set; }

        /// <summary>
        /// 使用次数 -- 排名专用
        /// </summary>
        public int  num { get; set; }
    }
}
