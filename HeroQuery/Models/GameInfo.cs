using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroQuery.Models
{
    public class GameInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public string region { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string gameId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int mapId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string gameMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> gameMutators { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string gameType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string gameName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long gameCreationTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int gameTypeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int queueId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int seasonId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> bannedChampions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long gameStartTimestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string gameVersion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string gameServerName { get; set; }
    }


    public class GameStats
    {
        /// <summary>
        /// 
        /// </summary>
        public string completed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long finalFrameTimestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        // public List<TeamStatsItem> teamStats { get; set; }
        /// <summary>
        /// 
        /// </summary>
        // public List<string> eventStats { get; set; }
    }

    public class Stats
    {
        /// <summary>
        /// 
        /// </summary>
        public string win { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string winner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string leaver { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int timePlayed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int totalTimeSpentDisconnected { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int champLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int item0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int item1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int item2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int item3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int item4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int item5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int item6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int kills { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int doubleKills { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int tripleKills { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int quadraKills { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int pentaKills { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int unrealKills { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int largestKillingSpree { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int largestMultiKill { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int killingSprees { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int longestTimeSpentLiving { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int deaths { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int totalTimeSpentDead { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int assists { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int totalDamageDealt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int totalDamageTaken { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int largestCriticalStrike { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int totalHeal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int totalTimeCrowdControlDealt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int totalUnitsHealed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int minionsKilled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int neutralMinionsKilled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int goldEarned { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int goldSpent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int combatPlayerScore { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int objectivePlayerScore { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int playerScore0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int playerScore1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int playerScore2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int playerScore3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int playerScore4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int playerScore5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int playerScore6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int playerScore7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int playerScore8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int playerScore9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int totalPlayerScore { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int totalScoreRank { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int nodeCapture { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int nodeCaptureAssist { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int nodeNeutralize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int nodeNeutralizeAssist { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int teamObjective { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int magicDamageDealtToChampions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int physicalDamageDealtToChampions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int trueDamageDealtToChampions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int totalDamageDealtToChampions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int visionWardsBoughtInGame { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sightWardsBoughtInGame { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int magicDamageDealt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int physicalDamageDealt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int trueDamageDealt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int magicDamageTaken { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int physicalDamageTaken { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int trueDamageTaken { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string firstBloodKill { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string firstBloodAssist { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string firstTowerKill { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string firstTowerAssist { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string firstInhibitorKill { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string firstInhibitorAssist { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string wasAfk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string wasAfkAfterFailedSurrender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int inhibitorKills { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int towerKills { get; set; }
        /// <summary>
        /// 是否重开，0：正常，1：重开
        /// </summary>
        public string gameEndedInEarlySurrender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string gameEndedInSurrender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string causedEarlySurrender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string earlySurrenderAccomplice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string teamEarlySurrendered { get; set; }
    }

    public class ParticipantsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public long originalAccountId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string originalPlatformId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long currentAccountId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string currentPlatformId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int teamId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int spell1Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int spell2Id { get; set; }
        /// <summary>
        /// 英雄ID
        /// </summary>
        public int championId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int skinIndex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int profileIconId { get; set; }
        /// <summary>
        /// Tiger灬阿秋
        /// </summary>
        public string summonerName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int teamParticipantId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int queueRating { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Stats stats { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long timeAddedToQueue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long summonerId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long wardSkin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long participantId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string partnerId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string obfuscatedIP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        // public Timeline timeline { get; set; }
    }



    public class Msg
    {
        /// <summary>
        /// 
        /// </summary>
        public GameInfo gameInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public GameStats gameStats { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ParticipantsItem> participants { get; set; }
    }


    public class Root
    {
        /// <summary>
        /// 
        /// </summary>
        public int status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Msg msg { get; set; }
    }
}
