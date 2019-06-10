using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HeroQuery.Common;
using Microsoft.AspNetCore.Mvc;
using HeroQuery.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace HeroQuery.Controllers
{
    public class HomeController : Controller
    {
        // private readonly IHostingEnvironment _hostingEnvironment;
        //
        // public HomeController(IHostingEnvironment hostingEnvironment)
        // {
        //     _hostingEnvironment = hostingEnvironment;
        // }

        public IActionResult Index()
        {
            string json =
                "{\"status\":0,\"msg\":{\"gameInfo\":{\"region\":\"HN19\",\"gameId\":1529717963,\"mapId\":12,\"gameMode\":\"ARAM\",\"gameMutators\":[\"ReRoll\",\"EsportsRecallDecals(1)\",\"Banana\",\"Moments\",\"NewSummonerBadgeSystem(1)\",\"EmotesTempQuestNotification\",\"Event_Popstar\"],\"gameType\":\"MATCHED_GAME\",\"gameName\":\"teambuilder-match-1529717963\",\"gameCreationTime\":1559926101159,\"gameTypeId\":21,\"queueId\":450,\"seasonId\":0,\"bannedChampions\":[],\"gameStartTimestamp\":1559926103478,\"gameVersion\":\"9.11.276.4911\",\"gameServerName\":\"\"},\"gameStats\":{\"completed\":true,\"finalFrameTimestamp\":1559927187254,\"teamStats\":[{\"teamId\":100,\"win\":\"Fail\",\"firstBlood\":false,\"firstTower\":false,\"firstInhibitor\":false,\"firstBaron\":false,\"firstDragon\":false,\"firstRiftHerald\":false,\"towerKills\":0,\"inhibitorKills\":0,\"baronKills\":0,\"dragonKills\":0,\"vilemawKills\":0,\"riftHeraldKills\":0},{\"teamId\":200,\"win\":\"Win\",\"firstBlood\":true,\"firstTower\":true,\"firstInhibitor\":true,\"firstBaron\":false,\"firstDragon\":false,\"firstRiftHerald\":false,\"towerKills\":4,\"inhibitorKills\":2,\"baronKills\":0,\"dragonKills\":0,\"vilemawKills\":0,\"riftHeraldKills\":0}],\"eventStats\":[]},\"participants\":[{\"originalAccountId\":4008214695,\"originalPlatformId\":\"HN19\",\"currentAccountId\":4008214695,\"currentPlatformId\":\"HN19\",\"teamId\":100,\"spell1Id\":14,\"spell2Id\":4,\"championId\":142,\"skinIndex\":0,\"profileIconId\":4088,\"summonerName\":\"Tiger\\u706c\\u963f\\u79cb\",\"teamParticipantId\":1,\"queueRating\":1564,\"stats\":{\"win\":\"Fail\",\"winner\":false,\"leaver\":false,\"timePlayed\":1048,\"totalTimeSpentDisconnected\":0,\"champLevel\":17,\"item0\":3285,\"item1\":3165,\"item2\":3020,\"item3\":3151,\"item4\":0,\"item5\":0,\"item6\":2052,\"kills\":5,\"doubleKills\":1,\"tripleKills\":0,\"quadraKills\":0,\"pentaKills\":0,\"unrealKills\":0,\"largestKillingSpree\":2,\"largestMultiKill\":2,\"killingSprees\":2,\"longestTimeSpentLiving\":255,\"deaths\":6,\"totalTimeSpentDead\":160,\"assists\":16,\"totalDamageDealt\":43712,\"totalDamageTaken\":14739,\"largestCriticalStrike\":301,\"totalHeal\":348,\"totalTimeCrowdControlDealt\":119,\"totalUnitsHealed\":3,\"minionsKilled\":34,\"neutralMinionsKilled\":0,\"goldEarned\":10968,\"goldSpent\":10450,\"combatPlayerScore\":0,\"objectivePlayerScore\":0,\"playerScore0\":0,\"playerScore1\":0,\"playerScore2\":0,\"playerScore3\":0,\"playerScore4\":0,\"playerScore5\":0,\"playerScore6\":0,\"playerScore7\":0,\"playerScore8\":0,\"playerScore9\":0,\"totalPlayerScore\":0,\"totalScoreRank\":0,\"nodeCapture\":0,\"nodeCaptureAssist\":0,\"nodeNeutralize\":0,\"nodeNeutralizeAssist\":0,\"teamObjective\":0,\"magicDamageDealtToChampions\":15153,\"physicalDamageDealtToChampions\":615,\"trueDamageDealtToChampions\":2566,\"totalDamageDealtToChampions\":18335,\"visionWardsBoughtInGame\":0,\"sightWardsBoughtInGame\":0,\"magicDamageDealt\":36583,\"physicalDamageDealt\":3942,\"trueDamageDealt\":3185,\"magicDamageTaken\":4866,\"physicalDamageTaken\":9145,\"trueDamageTaken\":727,\"firstBloodKill\":false,\"firstBloodAssist\":false,\"firstTowerKill\":false,\"firstTowerAssist\":false,\"firstInhibitorKill\":false,\"firstInhibitorAssist\":false,\"wasAfk\":false,\"wasAfkAfterFailedSurrender\":false,\"inhibitorKills\":0,\"towerKills\":0,\"gameEndedInEarlySurrender\":false,\"gameEndedInSurrender\":false,\"causedEarlySurrender\":false,\"earlySurrenderAccomplice\":false,\"teamEarlySurrendered\":false},\"timeAddedToQueue\":1559926013892,\"summonerId\":4008214695,\"wardSkin\":92,\"participantId\":1,\"partnerId\":\"\",\"obfuscatedIP\":\"3VoTUXLOxMy1OmdTUitHpqfdYIc=\",\"timeline\":{\"creepsPerMinDeltas\":{\"0-10\":2},\"xpPerMinDeltas\":{\"0-10\":716.4000000000001},\"goldPerMinDeltas\":{\"0-10\":517.1},\"csDiffPerMinDeltas\":{\"0-10\":0.10000000000000009},\"xpDiffPerMinDeltas\":{\"0-10\":-117.72000000000003},\"damageTakenPerMinDeltas\":{\"0-10\":492.7},\"damageTakenDiffPerMinDeltas\":{\"0-10\":104.07999999999998},\"wardsPerMinDeltas\":{\"0-10\":1.5},\"assistedLaneKillsPerMinDeltas\":{\"0-10\":0},\"assistedLaneDeathsPerMinDeltas\":{\"0-10\":0},\"towerKillsPerMinCounts\":{\"0-10\":0},\"towerAssistsPerMinCounts\":{\"0-10\":0},\"inhibitorKillsPerMinCounts\":{\"0-10\":0},\"inhibitorAssistsPerMinCounts\":{\"0-10\":0},\"baronKillsPerMinCounts\":{\"0-10\":0},\"baronAssistsPerMinCounts\":{\"0-10\":0},\"dragonKillsPerMinCounts\":{\"0-10\":0},\"dragonAssistsPerMinCounts\":{\"0-10\":0},\"vilemawKillsPerMinCounts\":{\"0-10\":0},\"vilemawAssistsPerMinCounts\":{\"0-10\":0},\"elderLizardKillsPerMinCounts\":{\"0-10\":0},\"elderLizardAssistsPerMinCounts\":{\"0-10\":0},\"ancientGolemKillsPerMinCounts\":{\"0-10\":0},\"ancientGolemAssistsPerMinCounts\":{\"0-10\":0},\"role\":\"DUO_SUPPORT\",\"lane\":\"TOP\"}},{\"originalAccountId\":65660426,\"originalPlatformId\":\"HN19\",\"currentAccountId\":65660426,\"currentPlatformId\":\"HN19\",\"teamId\":100,\"spell1Id\":32,\"spell2Id\":4,\"championId\":102,\"skinIndex\":6,\"profileIconId\":3379,\"summonerName\":\"\\u6708\\u4e0b\\u4e0d\\u7559\\u5f71\",\"teamParticipantId\":2,\"queueRating\":1362,\"stats\":{\"win\":\"Fail\",\"winner\":false,\"leaver\":false,\"timePlayed\":1048,\"totalTimeSpentDisconnected\":0,\"champLevel\":15,\"item0\":3800,\"item1\":1031,\"item2\":3111,\"item3\":3194,\"item4\":1011,\"item5\":3751,\"item6\":0,\"kills\":6,\"doubleKills\":0,\"tripleKills\":0,\"quadraKills\":0,\"pentaKills\":0,\"unrealKills\":0,\"largestKillingSpree\":2,\"largestMultiKill\":1,\"killingSprees\":2,\"longestTimeSpentLiving\":119,\"deaths\":13,\"totalTimeSpentDead\":260,\"assists\":11,\"totalDamageDealt\":26984,\"totalDamageTaken\":30123,\"largestCriticalStrike\":0,\"totalHeal\":1035,\"totalTimeCrowdControlDealt\":66,\"totalUnitsHealed\":1,\"minionsKilled\":21,\"neutralMinionsKilled\":0,\"goldEarned\":9882,\"goldSpent\":9450,\"combatPlayerScore\":0,\"objectivePlayerScore\":0,\"playerScore0\":0,\"playerScore1\":1,\"playerScore2\":0,\"playerScore3\":7,\"playerScore4\":0,\"playerScore5\":0,\"playerScore6\":0,\"playerScore7\":0,\"playerScore8\":0,\"playerScore9\":0,\"totalPlayerScore\":0,\"totalScoreRank\":0,\"nodeCapture\":0,\"nodeCaptureAssist\":0,\"nodeNeutralize\":0,\"nodeNeutralizeAssist\":0,\"teamObjective\":0,\"magicDamageDealtToChampions\":7844,\"physicalDamageDealtToChampions\":2513,\"trueDamageDealtToChampions\":623,\"totalDamageDealtToChampions\":10981,\"visionWardsBoughtInGame\":0,\"sightWardsBoughtInGame\":0,\"magicDamageDealt\":20526,\"physicalDamageDealt\":5677,\"trueDamageDealt\":780,\"magicDamageTaken\":8815,\"physicalDamageTaken\":20060,\"trueDamageTaken\":1247,\"firstBloodKill\":false,\"firstBloodAssist\":false,\"firstTowerKill\":false,\"firstTowerAssist\":false,\"firstInhibitorKill\":false,\"firstInhibitorAssist\":false,\"wasAfk\":false,\"wasAfkAfterFailedSurrender\":false,\"inhibitorKills\":0,\"towerKills\":0,\"gameEndedInEarlySurrender\":false,\"gameEndedInSurrender\":false,\"causedEarlySurrender\":false,\"earlySurrenderAccomplice\":false,\"teamEarlySurrendered\":false},\"timeAddedToQueue\":1559925975913,\"summonerId\":65660426,\"wardSkin\":59,\"participantId\":2,\"partnerId\":\"\",\"obfuscatedIP\":\"3VoTUXLOxMy1OmdTUitHpqfdYIc=\",\"timeline\":{\"creepsPerMinDeltas\":{\"0-10\":0.9},\"xpPerMinDeltas\":{\"0-10\":627.4},\"goldPerMinDeltas\":{\"0-10\":386.79999999999995},\"csDiffPerMinDeltas\":{\"0-10\":0.10000000000000009},\"xpDiffPerMinDeltas\":{\"0-10\":-117.72000000000003},\"damageTakenPerMinDeltas\":{\"0-10\":1303.1},\"damageTakenDiffPerMinDeltas\":{\"0-10\":104.07999999999998},\"wardsPerMinDeltas\":{\"0-10\":0},\"assistedLaneKillsPerMinDeltas\":{\"0-10\":0},\"assistedLaneDeathsPerMinDeltas\":{\"0-10\":0},\"towerKillsPerMinCounts\":{\"0-10\":0},\"towerAssistsPerMinCounts\":{\"0-10\":0},\"inhibitorKillsPerMinCounts\":{\"0-10\":0},\"inhibitorAssistsPerMinCounts\":{\"0-10\":0},\"baronKillsPerMinCounts\":{\"0-10\":0},\"baronAssistsPerMinCounts\":{\"0-10\":0},\"dragonKillsPerMinCounts\":{\"0-10\":0},\"dragonAssistsPerMinCounts\":{\"0-10\":0},\"vilemawKillsPerMinCounts\":{\"0-10\":0},\"vilemawAssistsPerMinCounts\":{\"0-10\":0},\"elderLizardKillsPerMinCounts\":{\"0-10\":0},\"elderLizardAssistsPerMinCounts\":{\"0-10\":0},\"ancientGolemKillsPerMinCounts\":{\"0-10\":0},\"ancientGolemAssistsPerMinCounts\":{\"0-10\":0},\"role\":\"DUO_SUPPORT\",\"lane\":\"TOP\"}},{\"originalAccountId\":69894618,\"originalPlatformId\":\"HN19\",\"currentAccountId\":69894618,\"currentPlatformId\":\"HN19\",\"teamId\":100,\"spell1Id\":4,\"spell2Id\":7,\"championId\":157,\"skinIndex\":4,\"profileIconId\":745,\"summonerName\":\"\\u4e0d\\u4f1a\\u55b5\\u7684\\u54aa\",\"teamParticipantId\":2,\"queueRating\":1812,\"stats\":{\"win\":\"Fail\",\"winner\":false,\"leaver\":false,\"timePlayed\":1048,\"totalTimeSpentDisconnected\":0,\"champLevel\":15,\"item0\":3046,\"item1\":3053,\"item2\":3006,\"item3\":3031,\"item4\":1029,\"item5\":0,\"item6\":2052,\"kills\":6,\"doubleKills\":1,\"tripleKills\":0,\"quadraKills\":0,\"pentaKills\":0,\"unrealKills\":0,\"largestKillingSpree\":2,\"largestMultiKill\":2,\"killingSprees\":2,\"longestTimeSpentLiving\":239,\"deaths\":11,\"totalTimeSpentDead\":250,\"assists\":13,\"totalDamageDealt\":62411,\"totalDamageTaken\":20983,\"largestCriticalStrike\":520,\"totalHeal\":3031,\"totalTimeCrowdControlDealt\":45,\"totalUnitsHealed\":3,\"minionsKilled\":57,\"neutralMinionsKilled\":0,\"goldEarned\":11001,\"goldSpent\":10750,\"combatPlayerScore\":0,\"objectivePlayerScore\":0,\"playerScore0\":0,\"playerScore1\":0,\"playerScore2\":0,\"playerScore3\":0,\"playerScore4\":0,\"playerScore5\":21,\"playerScore6\":0,\"playerScore7\":0,\"playerScore8\":0,\"playerScore9\":0,\"totalPlayerScore\":0,\"totalScoreRank\":0,\"nodeCapture\":0,\"nodeCaptureAssist\":0,\"nodeNeutralize\":0,\"nodeNeutralizeAssist\":0,\"teamObjective\":0,\"magicDamageDealtToChampions\":1146,\"physicalDamageDealtToChampions\":16673,\"trueDamageDealtToChampions\":0,\"totalDamageDealtToChampions\":17820,\"visionWardsBoughtInGame\":0,\"sightWardsBoughtInGame\":0,\"magicDamageDealt\":5646,\"physicalDamageDealt\":56765,\"trueDamageDealt\":0,\"magicDamageTaken\":8866,\"physicalDamageTaken\":11228,\"trueDamageTaken\":888,\"firstBloodKill\":false,\"firstBloodAssist\":false,\"firstTowerKill\":false,\"firstTowerAssist\":false,\"firstInhibitorKill\":false,\"firstInhibitorAssist\":false,\"wasAfk\":false,\"wasAfkAfterFailedSurrender\":false,\"inhibitorKills\":0,\"towerKills\":0,\"gameEndedInEarlySurrender\":false,\"gameEndedInSurrender\":false,\"causedEarlySurrender\":false,\"earlySurrenderAccomplice\":false,\"teamEarlySurrendered\":false},\"highestAchievedSeasonTier\":\"GOLD\",\"timeAddedToQueue\":1559925975913,\"summonerId\":69894618,\"wardSkin\":10,\"participantId\":3,\"partnerId\":\"\",\"obfuscatedIP\":\"3VoTUXLOxMy1OmdTUitHpqfdYIc=\",\"timeline\":{\"creepsPerMinDeltas\":{\"0-10\":3.3},\"xpPerMinDeltas\":{\"0-10\":666},\"goldPerMinDeltas\":{\"0-10\":569.1},\"csDiffPerMinDeltas\":{\"0-10\":0.10000000000000009},\"xpDiffPerMinDeltas\":{\"0-10\":-117.72000000000003},\"damageTakenPerMinDeltas\":{\"0-10\":811.1},\"damageTakenDiffPerMinDeltas\":{\"0-10\":104.07999999999998},\"wardsPerMinDeltas\":{\"0-10\":0.2},\"assistedLaneKillsPerMinDeltas\":{\"0-10\":0},\"assistedLaneDeathsPerMinDeltas\":{\"0-10\":0},\"towerKillsPerMinCounts\":{\"0-10\":0},\"towerAssistsPerMinCounts\":{\"0-10\":0},\"inhibitorKillsPerMinCounts\":{\"0-10\":0},\"inhibitorAssistsPerMinCounts\":{\"0-10\":0},\"baronKillsPerMinCounts\":{\"0-10\":0},\"baronAssistsPerMinCounts\":{\"0-10\":0},\"dragonKillsPerMinCounts\":{\"0-10\":0},\"dragonAssistsPerMinCounts\":{\"0-10\":0},\"vilemawKillsPerMinCounts\":{\"0-10\":0},\"vilemawAssistsPerMinCounts\":{\"0-10\":0},\"elderLizardKillsPerMinCounts\":{\"0-10\":0},\"elderLizardAssistsPerMinCounts\":{\"0-10\":0},\"ancientGolemKillsPerMinCounts\":{\"0-10\":0},\"ancientGolemAssistsPerMinCounts\":{\"0-10\":0},\"role\":\"DUO_SUPPORT\",\"lane\":\"TOP\"}},{\"originalAccountId\":88860200,\"originalPlatformId\":\"HN19\",\"currentAccountId\":88860200,\"currentPlatformId\":\"HN19\",\"teamId\":100,\"spell1Id\":13,\"spell2Id\":4,\"championId\":161,\"skinIndex\":3,\"profileIconId\":3887,\"summonerName\":\"\\u65ad\\u7f6a\\u5c0f\\u5b66\\u8d75\\u65e5\\u5929o\",\"teamParticipantId\":3,\"queueRating\":1555,\"stats\":{\"win\":\"Fail\",\"winner\":false,\"leaver\":false,\"timePlayed\":1048,\"totalTimeSpentDisconnected\":0,\"champLevel\":17,\"item0\":0,\"item1\":0,\"item2\":3157,\"item3\":3116,\"item4\":3285,\"item5\":3020,\"item6\":2052,\"kills\":4,\"doubleKills\":0,\"tripleKills\":0,\"quadraKills\":0,\"pentaKills\":0,\"unrealKills\":0,\"largestKillingSpree\":2,\"largestMultiKill\":1,\"killingSprees\":1,\"longestTimeSpentLiving\":229,\"deaths\":12,\"totalTimeSpentDead\":278,\"assists\":20,\"totalDamageDealt\":60484,\"totalDamageTaken\":20894,\"largestCriticalStrike\":0,\"totalHeal\":688,\"totalTimeCrowdControlDealt\":358,\"totalUnitsHealed\":1,\"minionsKilled\":40,\"neutralMinionsKilled\":0,\"goldEarned\":10339,\"goldSpent\":9650,\"combatPlayerScore\":0,\"objectivePlayerScore\":0,\"playerScore0\":0,\"playerScore1\":0,\"playerScore2\":0,\"playerScore3\":0,\"playerScore4\":0,\"playerScore5\":0,\"playerScore6\":0,\"playerScore7\":0,\"playerScore8\":0,\"playerScore9\":0,\"totalPlayerScore\":0,\"totalScoreRank\":0,\"nodeCapture\":0,\"nodeCaptureAssist\":0,\"nodeNeutralize\":0,\"nodeNeutralizeAssist\":0,\"teamObjective\":0,\"magicDamageDealtToChampions\":18513,\"physicalDamageDealtToChampions\":258,\"trueDamageDealtToChampions\":4829,\"totalDamageDealtToChampions\":23601,\"visionWardsBoughtInGame\":0,\"sightWardsBoughtInGame\":0,\"magicDamageDealt\":50850,\"physicalDamageDealt\":1513,\"trueDamageDealt\":8119,\"magicDamageTaken\":7679,\"physicalDamageTaken\":12561,\"trueDamageTaken\":653,\"firstBloodKill\":false,\"firstBloodAssist\":false,\"firstTowerKill\":false,\"firstTowerAssist\":false,\"firstInhibitorKill\":false,\"firstInhibitorAssist\":false,\"wasAfk\":false,\"wasAfkAfterFailedSurrender\":false,\"inhibitorKills\":0,\"towerKills\":0,\"gameEndedInEarlySurrender\":false,\"gameEndedInSurrender\":false,\"causedEarlySurrender\":false,\"earlySurrenderAccomplice\":false,\"teamEarlySurrendered\":false},\"highestAchievedSeasonTier\":\"SILVER\",\"timeAddedToQueue\":1559925998234,\"summonerId\":88860200,\"wardSkin\":97,\"participantId\":4,\"partnerId\":\"\",\"obfuscatedIP\":\"3VoTUXLOxMy1OmdTUitHpqfdYIc=\",\"timeline\":{\"creepsPerMinDeltas\":{\"0-10\":1.9},\"xpPerMinDeltas\":{\"0-10\":688.3},\"goldPerMinDeltas\":{\"0-10\":467.8},\"csDiffPerMinDeltas\":{\"0-10\":0.10000000000000009},\"xpDiffPerMinDeltas\":{\"0-10\":-117.72000000000003},\"damageTakenPerMinDeltas\":{\"0-10\":863.4},\"damageTakenDiffPerMinDeltas\":{\"0-10\":104.07999999999998},\"wardsPerMinDeltas\":{\"0-10\":0},\"assistedLaneKillsPerMinDeltas\":{\"0-10\":0},\"assistedLaneDeathsPerMinDeltas\":{\"0-10\":0},\"towerKillsPerMinCounts\":{\"0-10\":0},\"towerAssistsPerMinCounts\":{\"0-10\":0},\"inhibitorKillsPerMinCounts\":{\"0-10\":0},\"inhibitorAssistsPerMinCounts\":{\"0-10\":0},\"baronKillsPerMinCounts\":{\"0-10\":0},\"baronAssistsPerMinCounts\":{\"0-10\":0},\"dragonKillsPerMinCounts\":{\"0-10\":0},\"dragonAssistsPerMinCounts\":{\"0-10\":0},\"vilemawKillsPerMinCounts\":{\"0-10\":0},\"vilemawAssistsPerMinCounts\":{\"0-10\":0},\"elderLizardKillsPerMinCounts\":{\"0-10\":0},\"elderLizardAssistsPerMinCounts\":{\"0-10\":0},\"ancientGolemKillsPerMinCounts\":{\"0-10\":0},\"ancientGolemAssistsPerMinCounts\":{\"0-10\":0},\"role\":\"DUO_SUPPORT\",\"lane\":\"TOP\"}},{\"originalAccountId\":4010621320,\"originalPlatformId\":\"HN19\",\"currentAccountId\":4010621320,\"currentPlatformId\":\"HN19\",\"teamId\":100,\"spell1Id\":32,\"spell2Id\":4,\"championId\":68,\"skinIndex\":0,\"profileIconId\":4022,\"summonerName\":\"\\u6211\\u8981\\u5403\\u80af\\u5fb7\\u57fa\",\"teamParticipantId\":4,\"queueRating\":1555,\"stats\":{\"win\":\"Fail\",\"winner\":false,\"leaver\":false,\"timePlayed\":1048,\"totalTimeSpentDisconnected\":0,\"champLevel\":16,\"item0\":3151,\"item1\":3152,\"item2\":3157,\"item3\":3020,\"item4\":3108,\"item5\":1033,\"item6\":2052,\"kills\":10,\"doubleKills\":2,\"tripleKills\":1,\"quadraKills\":0,\"pentaKills\":0,\"unrealKills\":0,\"largestKillingSpree\":3,\"largestMultiKill\":3,\"killingSprees\":2,\"longestTimeSpentLiving\":139,\"deaths\":15,\"totalTimeSpentDead\":324,\"assists\":13,\"totalDamageDealt\":55335,\"totalDamageTaken\":27530,\"largestCriticalStrike\":0,\"totalHeal\":263,\"totalTimeCrowdControlDealt\":153,\"totalUnitsHealed\":1,\"minionsKilled\":42,\"neutralMinionsKilled\":0,\"goldEarned\":11234,\"goldSpent\":10950,\"combatPlayerScore\":0,\"objectivePlayerScore\":0,\"playerScore0\":0,\"playerScore1\":0,\"playerScore2\":0,\"playerScore3\":3,\"playerScore4\":0,\"playerScore5\":0,\"playerScore6\":0,\"playerScore7\":0,\"playerScore8\":0,\"playerScore9\":0,\"totalPlayerScore\":0,\"totalScoreRank\":0,\"nodeCapture\":0,\"nodeCaptureAssist\":0,\"nodeNeutralize\":0,\"nodeNeutralizeAssist\":0,\"teamObjective\":0,\"magicDamageDealtToChampions\":25315,\"physicalDamageDealtToChampions\":560,\"trueDamageDealtToChampions\":328,\"totalDamageDealtToChampions\":26204,\"visionWardsBoughtInGame\":0,\"sightWardsBoughtInGame\":0,\"magicDamageDealt\":50809,\"physicalDamageDealt\":2477,\"trueDamageDealt\":2048,\"magicDamageTaken\":11147,\"physicalDamageTaken\":14816,\"trueDamageTaken\":1566,\"firstBloodKill\":false,\"firstBloodAssist\":false,\"firstTowerKill\":false,\"firstTowerAssist\":false,\"firstInhibitorKill\":false,\"firstInhibitorAssist\":false,\"wasAfk\":false,\"wasAfkAfterFailedSurrender\":false,\"inhibitorKills\":0,\"towerKills\":0,\"gameEndedInEarlySurrender\":false,\"gameEndedInSurrender\":false,\"causedEarlySurrender\":false,\"earlySurrenderAccomplice\":false,\"teamEarlySurrendered\":false},\"highestAchievedSeasonTier\":\"GOLD\",\"timeAddedToQueue\":1559925996146,\"summonerId\":4010621320,\"wardSkin\":108,\"participantId\":5,\"partnerId\":\"\",\"obfuscatedIP\":\"3VoTUXLOxMy1OmdTUitHpqfdYIc=\",\"timeline\":{\"creepsPerMinDeltas\":{\"0-10\":2.1},\"xpPerMinDeltas\":{\"0-10\":590.9},\"goldPerMinDeltas\":{\"0-10\":473.3},\"csDiffPerMinDeltas\":{\"0-10\":0.10000000000000009},\"xpDiffPerMinDeltas\":{\"0-10\":-117.72000000000003},\"damageTakenPerMinDeltas\":{\"0-10\":1125.7},\"damageTakenDiffPerMinDeltas\":{\"0-10\":104.07999999999998},\"wardsPerMinDeltas\":{\"0-10\":0},\"assistedLaneKillsPerMinDeltas\":{\"0-10\":0},\"assistedLaneDeathsPerMinDeltas\":{\"0-10\":0},\"towerKillsPerMinCounts\":{\"0-10\":0},\"towerAssistsPerMinCounts\":{\"0-10\":0},\"inhibitorKillsPerMinCounts\":{\"0-10\":0},\"inhibitorAssistsPerMinCounts\":{\"0-10\":0},\"baronKillsPerMinCounts\":{\"0-10\":0},\"baronAssistsPerMinCounts\":{\"0-10\":0},\"dragonKillsPerMinCounts\":{\"0-10\":0},\"dragonAssistsPerMinCounts\":{\"0-10\":0},\"vilemawKillsPerMinCounts\":{\"0-10\":0},\"vilemawAssistsPerMinCounts\":{\"0-10\":0},\"elderLizardKillsPerMinCounts\":{\"0-10\":0},\"elderLizardAssistsPerMinCounts\":{\"0-10\":0},\"ancientGolemKillsPerMinCounts\":{\"0-10\":0},\"ancientGolemAssistsPerMinCounts\":{\"0-10\":0},\"role\":\"DUO_SUPPORT\",\"lane\":\"TOP\"}},{\"originalAccountId\":64853363,\"originalPlatformId\":\"HN19\",\"currentAccountId\":64853363,\"currentPlatformId\":\"HN19\",\"teamId\":200,\"spell1Id\":4,\"spell2Id\":32,\"championId\":55,\"skinIndex\":0,\"profileIconId\":1443,\"summonerName\":\"\\u1160\\u1160\\u1160\\u1160\\u9a12\\u70fa\\u6ffa\\u10e6\",\"teamParticipantId\":5,\"queueRating\":1652,\"stats\":{\"win\":\"Win\",\"winner\":true,\"leaver\":false,\"timePlayed\":1048,\"totalTimeSpentDisconnected\":0,\"champLevel\":17,\"item0\":3157,\"item1\":3116,\"item2\":3165,\"item3\":3146,\"item4\":3020,\"item5\":0,\"item6\":2052,\"kills\":19,\"doubleKills\":2,\"tripleKills\":1,\"quadraKills\":1,\"pentaKills\":0,\"unrealKills\":0,\"largestKillingSpree\":5,\"largestMultiKill\":4,\"killingSprees\":5,\"longestTimeSpentLiving\":293,\"deaths\":6,\"totalTimeSpentDead\":130,\"assists\":24,\"totalDamageDealt\":61441,\"totalDamageTaken\":21010,\"largestCriticalStrike\":0,\"totalHeal\":7719,\"totalTimeCrowdControlDealt\":104,\"totalUnitsHealed\":1,\"minionsKilled\":44,\"neutralMinionsKilled\":0,\"goldEarned\":13738,\"goldSpent\":13100,\"combatPlayerScore\":0,\"objectivePlayerScore\":0,\"playerScore0\":0,\"playerScore1\":0,\"playerScore2\":0,\"playerScore3\":10,\"playerScore4\":0,\"playerScore5\":0,\"playerScore6\":0,\"playerScore7\":0,\"playerScore8\":0,\"playerScore9\":0,\"totalPlayerScore\":0,\"totalScoreRank\":0,\"nodeCapture\":0,\"nodeCaptureAssist\":0,\"nodeNeutralize\":0,\"nodeNeutralizeAssist\":0,\"teamObjective\":0,\"magicDamageDealtToChampions\":21843,\"physicalDamageDealtToChampions\":2040,\"trueDamageDealtToChampions\":877,\"totalDamageDealtToChampions\":24761,\"visionWardsBoughtInGame\":0,\"sightWardsBoughtInGame\":0,\"magicDamageDealt\":56601,\"physicalDamageDealt\":3962,\"trueDamageDealt\":877,\"magicDamageTaken\":13030,\"physicalDamageTaken\":6934,\"trueDamageTaken\":1045,\"firstBloodKill\":true,\"firstBloodAssist\":false,\"firstTowerKill\":false,\"firstTowerAssist\":true,\"firstInhibitorKill\":false,\"firstInhibitorAssist\":true,\"wasAfk\":false,\"wasAfkAfterFailedSurrender\":false,\"inhibitorKills\":0,\"towerKills\":2,\"gameEndedInEarlySurrender\":false,\"gameEndedInSurrender\":false,\"causedEarlySurrender\":false,\"earlySurrenderAccomplice\":false,\"teamEarlySurrendered\":false},\"highestAchievedSeasonTier\":\"GOLD\",\"timeAddedToQueue\":1559926023940,\"summonerId\":64853363,\"wardSkin\":91,\"participantId\":6,\"partnerId\":\"\",\"obfuscatedIP\":\"3VoTUXLOxMy1OmdTUitHpqfdYIc=\",\"timeline\":{\"creepsPerMinDeltas\":{\"0-10\":2.5999999999999996},\"xpPerMinDeltas\":{\"0-10\":765.5999999999999},\"goldPerMinDeltas\":{\"0-10\":658.1},\"csDiffPerMinDeltas\":{\"0-10\":-0.10000000000000009},\"xpDiffPerMinDeltas\":{\"0-10\":117.72000000000003},\"damageTakenPerMinDeltas\":{\"0-10\":799.2},\"damageTakenDiffPerMinDeltas\":{\"0-10\":-104.07999999999998},\"wardsPerMinDeltas\":{\"0-10\":0},\"assistedLaneKillsPerMinDeltas\":{\"0-10\":0},\"assistedLaneDeathsPerMinDeltas\":{\"0-10\":0},\"towerKillsPerMinCounts\":{\"0-10\":0},\"towerAssistsPerMinCounts\":{\"0-10\":0},\"inhibitorKillsPerMinCounts\":{\"0-10\":0},\"inhibitorAssistsPerMinCounts\":{\"0-10\":0},\"baronKillsPerMinCounts\":{\"0-10\":0},\"baronAssistsPerMinCounts\":{\"0-10\":0},\"dragonKillsPerMinCounts\":{\"0-10\":0},\"dragonAssistsPerMinCounts\":{\"0-10\":0},\"vilemawKillsPerMinCounts\":{\"0-10\":0},\"vilemawAssistsPerMinCounts\":{\"0-10\":0},\"elderLizardKillsPerMinCounts\":{\"0-10\":0},\"elderLizardAssistsPerMinCounts\":{\"0-10\":0},\"ancientGolemKillsPerMinCounts\":{\"0-10\":0},\"ancientGolemAssistsPerMinCounts\":{\"0-10\":0},\"role\":\"DUO_SUPPORT\",\"lane\":\"TOP\"}},{\"originalAccountId\":4001236723,\"originalPlatformId\":\"HN19\",\"currentAccountId\":4001236723,\"currentPlatformId\":\"HN19\",\"teamId\":200,\"spell1Id\":3,\"spell2Id\":4,\"championId\":119,\"skinIndex\":5,\"profileIconId\":4089,\"summonerName\":\"\\u671d\\u4ed3\\u524d\\u8f88\",\"teamParticipantId\":5,\"queueRating\":1568,\"stats\":{\"win\":\"Win\",\"winner\":true,\"leaver\":false,\"timePlayed\":1048,\"totalTimeSpentDisconnected\":0,\"champLevel\":18,\"item0\":3072,\"item1\":2031,\"item2\":3142,\"item3\":3006,\"item4\":3156,\"item5\":0,\"item6\":2052,\"kills\":10,\"doubleKills\":1,\"tripleKills\":0,\"quadraKills\":0,\"pentaKills\":0,\"unrealKills\":0,\"largestKillingSpree\":3,\"largestMultiKill\":2,\"killingSprees\":4,\"longestTimeSpentLiving\":272,\"deaths\":6,\"totalTimeSpentDead\":132,\"assists\":34,\"totalDamageDealt\":74046,\"totalDamageTaken\":17928,\"largestCriticalStrike\":0,\"totalHeal\":2174,\"totalTimeCrowdControlDealt\":58,\"totalUnitsHealed\":1,\"minionsKilled\":61,\"neutralMinionsKilled\":0,\"goldEarned\":12983,\"goldSpent\":11000,\"combatPlayerScore\":0,\"objectivePlayerScore\":0,\"playerScore0\":0,\"playerScore1\":0,\"playerScore2\":0,\"playerScore3\":0,\"playerScore4\":0,\"playerScore5\":0,\"playerScore6\":0,\"playerScore7\":0,\"playerScore8\":0,\"playerScore9\":0,\"totalPlayerScore\":0,\"totalScoreRank\":0,\"nodeCapture\":0,\"nodeCaptureAssist\":0,\"nodeNeutralize\":0,\"nodeNeutralizeAssist\":0,\"teamObjective\":0,\"magicDamageDealtToChampions\":0,\"physicalDamageDealtToChampions\":24613,\"trueDamageDealtToChampions\":0,\"totalDamageDealtToChampions\":24613,\"visionWardsBoughtInGame\":0,\"sightWardsBoughtInGame\":0,\"magicDamageDealt\":0,\"physicalDamageDealt\":74046,\"trueDamageDealt\":0,\"magicDamageTaken\":10740,\"physicalDamageTaken\":3845,\"trueDamageTaken\":3341,\"firstBloodKill\":false,\"firstBloodAssist\":false,\"firstTowerKill\":false,\"firstTowerAssist\":true,\"firstInhibitorKill\":true,\"firstInhibitorAssist\":false,\"wasAfk\":false,\"wasAfkAfterFailedSurrender\":false,\"inhibitorKills\":2,\"towerKills\":1,\"gameEndedInEarlySurrender\":false,\"gameEndedInSurrender\":false,\"causedEarlySurrender\":false,\"earlySurrenderAccomplice\":false,\"teamEarlySurrendered\":false},\"highestAchievedSeasonTier\":\"GOLD\",\"timeAddedToQueue\":1559926023940,\"summonerId\":4001236723,\"wardSkin\":26,\"participantId\":7,\"partnerId\":\"\",\"obfuscatedIP\":\"3VoTUXLOxMy1OmdTUitHpqfdYIc=\",\"timeline\":{\"creepsPerMinDeltas\":{\"0-10\":3.3},\"xpPerMinDeltas\":{\"0-10\":798.2},\"goldPerMinDeltas\":{\"0-10\":570.4000000000001},\"csDiffPerMinDeltas\":{\"0-10\":-0.10000000000000009},\"xpDiffPerMinDeltas\":{\"0-10\":117.72000000000003},\"damageTakenPerMinDeltas\":{\"0-10\":787.7},\"damageTakenDiffPerMinDeltas\":{\"0-10\":-104.07999999999998},\"wardsPerMinDeltas\":{\"0-10\":0},\"assistedLaneKillsPerMinDeltas\":{\"0-10\":0},\"assistedLaneDeathsPerMinDeltas\":{\"0-10\":0},\"towerKillsPerMinCounts\":{\"0-10\":0},\"towerAssistsPerMinCounts\":{\"0-10\":0},\"inhibitorKillsPerMinCounts\":{\"0-10\":0},\"inhibitorAssistsPerMinCounts\":{\"0-10\":0},\"baronKillsPerMinCounts\":{\"0-10\":0},\"baronAssistsPerMinCounts\":{\"0-10\":0},\"dragonKillsPerMinCounts\":{\"0-10\":0},\"dragonAssistsPerMinCounts\":{\"0-10\":0},\"vilemawKillsPerMinCounts\":{\"0-10\":0},\"vilemawAssistsPerMinCounts\":{\"0-10\":0},\"elderLizardKillsPerMinCounts\":{\"0-10\":0},\"elderLizardAssistsPerMinCounts\":{\"0-10\":0},\"ancientGolemKillsPerMinCounts\":{\"0-10\":0},\"ancientGolemAssistsPerMinCounts\":{\"0-10\":0},\"role\":\"DUO_SUPPORT\",\"lane\":\"TOP\"}},{\"originalAccountId\":67314986,\"originalPlatformId\":\"HN19\",\"currentAccountId\":67314986,\"currentPlatformId\":\"HN19\",\"teamId\":200,\"spell1Id\":4,\"spell2Id\":32,\"championId\":62,\"skinIndex\":0,\"profileIconId\":1442,\"summonerName\":\"\\u5c0fM\\u5c0f\\u8349\",\"teamParticipantId\":5,\"queueRating\":1455,\"stats\":{\"win\":\"Win\",\"winner\":true,\"leaver\":false,\"timePlayed\":1048,\"totalTimeSpentDisconnected\":0,\"champLevel\":16,\"item0\":3074,\"item1\":3111,\"item2\":3078,\"item3\":3071,\"item4\":0,\"item5\":0,\"item6\":2052,\"kills\":13,\"doubleKills\":3,\"tripleKills\":0,\"quadraKills\":0,\"pentaKills\":0,\"unrealKills\":0,\"largestKillingSpree\":5,\"largestMultiKill\":2,\"killingSprees\":4,\"longestTimeSpentLiving\":405,\"deaths\":6,\"totalTimeSpentDead\":178,\"assists\":23,\"totalDamageDealt\":44054,\"totalDamageTaken\":15769,\"largestCriticalStrike\":0,\"totalHeal\":1253,\"totalTimeCrowdControlDealt\":25,\"totalUnitsHealed\":1,\"minionsKilled\":38,\"neutralMinionsKilled\":0,\"goldEarned\":11758,\"goldSpent\":11383,\"combatPlayerScore\":0,\"objectivePlayerScore\":0,\"playerScore0\":0,\"playerScore1\":0,\"playerScore2\":0,\"playerScore3\":10,\"playerScore4\":0,\"playerScore5\":0,\"playerScore6\":0,\"playerScore7\":0,\"playerScore8\":0,\"playerScore9\":0,\"totalPlayerScore\":0,\"totalScoreRank\":0,\"nodeCapture\":0,\"nodeCaptureAssist\":0,\"nodeNeutralize\":0,\"nodeNeutralizeAssist\":0,\"teamObjective\":0,\"magicDamageDealtToChampions\":419,\"physicalDamageDealtToChampions\":20704,\"trueDamageDealtToChampions\":756,\"totalDamageDealtToChampions\":21880,\"visionWardsBoughtInGame\":0,\"sightWardsBoughtInGame\":0,\"magicDamageDealt\":954,\"physicalDamageDealt\":42113,\"trueDamageDealt\":986,\"magicDamageTaken\":9183,\"physicalDamageTaken\":4223,\"trueDamageTaken\":2363,\"firstBloodKill\":false,\"firstBloodAssist\":false,\"firstTowerKill\":true,\"firstTowerAssist\":false,\"firstInhibitorKill\":false,\"firstInhibitorAssist\":false,\"wasAfk\":false,\"wasAfkAfterFailedSurrender\":false,\"inhibitorKills\":0,\"towerKills\":1,\"gameEndedInEarlySurrender\":false,\"gameEndedInSurrender\":false,\"causedEarlySurrender\":false,\"earlySurrenderAccomplice\":false,\"teamEarlySurrendered\":false},\"timeAddedToQueue\":1559926023940,\"summonerId\":67314986,\"wardSkin\":132,\"participantId\":8,\"partnerId\":\"\",\"obfuscatedIP\":\"3VoTUXLOxMy1OmdTUitHpqfdYIc=\",\"timeline\":{\"creepsPerMinDeltas\":{\"0-10\":2.8},\"xpPerMinDeltas\":{\"0-10\":797.5},\"goldPerMinDeltas\":{\"0-10\":559.1},\"csDiffPerMinDeltas\":{\"0-10\":-0.10000000000000009},\"xpDiffPerMinDeltas\":{\"0-10\":117.72000000000003},\"damageTakenPerMinDeltas\":{\"0-10\":603.4},\"damageTakenDiffPerMinDeltas\":{\"0-10\":-104.07999999999998},\"wardsPerMinDeltas\":{\"0-10\":0},\"assistedLaneKillsPerMinDeltas\":{\"0-10\":0},\"assistedLaneDeathsPerMinDeltas\":{\"0-10\":0},\"towerKillsPerMinCounts\":{\"0-10\":0},\"towerAssistsPerMinCounts\":{\"0-10\":0},\"inhibitorKillsPerMinCounts\":{\"0-10\":0},\"inhibitorAssistsPerMinCounts\":{\"0-10\":0},\"baronKillsPerMinCounts\":{\"0-10\":0},\"baronAssistsPerMinCounts\":{\"0-10\":0},\"dragonKillsPerMinCounts\":{\"0-10\":0},\"dragonAssistsPerMinCounts\":{\"0-10\":0},\"vilemawKillsPerMinCounts\":{\"0-10\":0},\"vilemawAssistsPerMinCounts\":{\"0-10\":0},\"elderLizardKillsPerMinCounts\":{\"0-10\":0},\"elderLizardAssistsPerMinCounts\":{\"0-10\":0},\"ancientGolemKillsPerMinCounts\":{\"0-10\":0},\"ancientGolemAssistsPerMinCounts\":{\"0-10\":0},\"role\":\"DUO_SUPPORT\",\"lane\":\"TOP\"}},{\"originalAccountId\":4002304479,\"originalPlatformId\":\"HN19\",\"currentAccountId\":4002304479,\"currentPlatformId\":\"HN19\",\"teamId\":200,\"spell1Id\":4,\"spell2Id\":32,\"championId\":555,\"skinIndex\":10,\"profileIconId\":3599,\"summonerName\":\"Theangry\\u4e36\\u674e\\u54e5\",\"teamParticipantId\":5,\"queueRating\":1670,\"stats\":{\"win\":\"Win\",\"winner\":true,\"leaver\":false,\"timePlayed\":1048,\"totalTimeSpentDisconnected\":0,\"champLevel\":16,\"item0\":3147,\"item1\":3111,\"item2\":3142,\"item3\":3071,\"item4\":0,\"item5\":0,\"item6\":0,\"kills\":9,\"doubleKills\":1,\"tripleKills\":1,\"quadraKills\":0,\"pentaKills\":0,\"unrealKills\":0,\"largestKillingSpree\":4,\"largestMultiKill\":3,\"killingSprees\":2,\"longestTimeSpentLiving\":235,\"deaths\":8,\"totalTimeSpentDead\":218,\"assists\":16,\"totalDamageDealt\":20204,\"totalDamageTaken\":20598,\"largestCriticalStrike\":0,\"totalHeal\":6506,\"totalTimeCrowdControlDealt\":165,\"totalUnitsHealed\":1,\"minionsKilled\":9,\"neutralMinionsKilled\":0,\"goldEarned\":10266,\"goldSpent\":9950,\"combatPlayerScore\":0,\"objectivePlayerScore\":0,\"playerScore0\":0,\"playerScore1\":2,\"playerScore2\":0,\"playerScore3\":7,\"playerScore4\":0,\"playerScore5\":0,\"playerScore6\":0,\"playerScore7\":0,\"playerScore8\":0,\"playerScore9\":0,\"totalPlayerScore\":0,\"totalScoreRank\":0,\"nodeCapture\":0,\"nodeCaptureAssist\":0,\"nodeNeutralize\":0,\"nodeNeutralizeAssist\":0,\"teamObjective\":0,\"magicDamageDealtToChampions\":0,\"physicalDamageDealtToChampions\":8785,\"trueDamageDealtToChampions\":2380,\"totalDamageDealtToChampions\":11166,\"visionWardsBoughtInGame\":0,\"sightWardsBoughtInGame\":0,\"magicDamageDealt\":0,\"physicalDamageDealt\":17754,\"trueDamageDealt\":2450,\"magicDamageTaken\":12894,\"physicalDamageTaken\":6969,\"trueDamageTaken\":734,\"firstBloodKill\":false,\"firstBloodAssist\":false,\"firstTowerKill\":false,\"firstTowerAssist\":true,\"firstInhibitorKill\":false,\"firstInhibitorAssist\":false,\"wasAfk\":false,\"wasAfkAfterFailedSurrender\":false,\"inhibitorKills\":0,\"towerKills\":0,\"gameEndedInEarlySurrender\":false,\"gameEndedInSurrender\":false,\"causedEarlySurrender\":false,\"earlySurrenderAccomplice\":false,\"teamEarlySurrendered\":false},\"highestAchievedSeasonTier\":\"GOLD\",\"timeAddedToQueue\":1559926023940,\"summonerId\":4002304479,\"wardSkin\":92,\"participantId\":9,\"partnerId\":\"\",\"obfuscatedIP\":\"3VoTUXLOxMy1OmdTUitHpqfdYIc=\",\"timeline\":{\"creepsPerMinDeltas\":{\"0-10\":0.1},\"xpPerMinDeltas\":{\"0-10\":764.0999999999999},\"goldPerMinDeltas\":{\"0-10\":446.4},\"csDiffPerMinDeltas\":{\"0-10\":-0.10000000000000009},\"xpDiffPerMinDeltas\":{\"0-10\":117.72000000000003},\"damageTakenPerMinDeltas\":{\"0-10\":768.4000000000001},\"damageTakenDiffPerMinDeltas\":{\"0-10\":-104.07999999999998},\"wardsPerMinDeltas\":{\"0-10\":0},\"assistedLaneKillsPerMinDeltas\":{\"0-10\":0},\"assistedLaneDeathsPerMinDeltas\":{\"0-10\":0},\"towerKillsPerMinCounts\":{\"0-10\":0},\"towerAssistsPerMinCounts\":{\"0-10\":0},\"inhibitorKillsPerMinCounts\":{\"0-10\":0},\"inhibitorAssistsPerMinCounts\":{\"0-10\":0},\"baronKillsPerMinCounts\":{\"0-10\":0},\"baronAssistsPerMinCounts\":{\"0-10\":0},\"dragonKillsPerMinCounts\":{\"0-10\":0},\"dragonAssistsPerMinCounts\":{\"0-10\":0},\"vilemawKillsPerMinCounts\":{\"0-10\":0},\"vilemawAssistsPerMinCounts\":{\"0-10\":0},\"elderLizardKillsPerMinCounts\":{\"0-10\":0},\"elderLizardAssistsPerMinCounts\":{\"0-10\":0},\"ancientGolemKillsPerMinCounts\":{\"0-10\":0},\"ancientGolemAssistsPerMinCounts\":{\"0-10\":0},\"role\":\"DUO_SUPPORT\",\"lane\":\"TOP\"}},{\"originalAccountId\":63291727,\"originalPlatformId\":\"HN19\",\"currentAccountId\":63291727,\"currentPlatformId\":\"HN19\",\"teamId\":200,\"spell1Id\":32,\"spell2Id\":4,\"championId\":50,\"skinIndex\":0,\"profileIconId\":3776,\"summonerName\":\"\\u5f88\\u725b\\u7684\\u5927\\u53d4\",\"teamParticipantId\":5,\"queueRating\":1537,\"stats\":{\"win\":\"Win\",\"winner\":true,\"leaver\":false,\"timePlayed\":1048,\"totalTimeSpentDisconnected\":0,\"champLevel\":17,\"item0\":3029,\"item1\":3020,\"item2\":2031,\"item3\":3065,\"item4\":3165,\"item5\":0,\"item6\":2052,\"kills\":6,\"doubleKills\":2,\"tripleKills\":0,\"quadraKills\":0,\"pentaKills\":0,\"unrealKills\":0,\"largestKillingSpree\":4,\"largestMultiKill\":2,\"killingSprees\":2,\"longestTimeSpentLiving\":298,\"deaths\":5,\"totalTimeSpentDead\":130,\"assists\":41,\"totalDamageDealt\":36270,\"totalDamageTaken\":33390,\"largestCriticalStrike\":0,\"totalHeal\":17459,\"totalTimeCrowdControlDealt\":124,\"totalUnitsHealed\":1,\"minionsKilled\":24,\"neutralMinionsKilled\":0,\"goldEarned\":11645,\"goldSpent\":9450,\"combatPlayerScore\":0,\"objectivePlayerScore\":0,\"playerScore0\":0,\"playerScore1\":0,\"playerScore2\":0,\"playerScore3\":13,\"playerScore4\":0,\"playerScore5\":0,\"playerScore6\":0,\"playerScore7\":0,\"playerScore8\":0,\"playerScore9\":0,\"totalPlayerScore\":0,\"totalScoreRank\":0,\"nodeCapture\":0,\"nodeCaptureAssist\":0,\"nodeNeutralize\":0,\"nodeNeutralizeAssist\":0,\"teamObjective\":0,\"magicDamageDealtToChampions\":19112,\"physicalDamageDealtToChampions\":1214,\"trueDamageDealtToChampions\":1068,\"totalDamageDealtToChampions\":21395,\"visionWardsBoughtInGame\":0,\"sightWardsBoughtInGame\":0,\"magicDamageDealt\":32343,\"physicalDamageDealt\":2858,\"trueDamageDealt\":1068,\"magicDamageTaken\":22124,\"physicalDamageTaken\":8403,\"trueDamageTaken\":2861,\"firstBloodKill\":false,\"firstBloodAssist\":false,\"firstTowerKill\":false,\"firstTowerAssist\":true,\"firstInhibitorKill\":false,\"firstInhibitorAssist\":true,\"wasAfk\":false,\"wasAfkAfterFailedSurrender\":false,\"inhibitorKills\":0,\"towerKills\":0,\"gameEndedInEarlySurrender\":false,\"gameEndedInSurrender\":false,\"causedEarlySurrender\":false,\"earlySurrenderAccomplice\":false,\"teamEarlySurrendered\":false},\"highestAchievedSeasonTier\":\"GOLD\",\"timeAddedToQueue\":1559926023940,\"summonerId\":63291727,\"wardSkin\":96,\"participantId\":10,\"partnerId\":\"\",\"obfuscatedIP\":\"3VoTUXLOxMy1OmdTUitHpqfdYIc=\",\"timeline\":{\"creepsPerMinDeltas\":{\"0-10\":0.8999999999999999},\"xpPerMinDeltas\":{\"0-10\":752.2},\"goldPerMinDeltas\":{\"0-10\":560},\"csDiffPerMinDeltas\":{\"0-10\":-0.10000000000000009},\"xpDiffPerMinDeltas\":{\"0-10\":117.72000000000003},\"damageTakenPerMinDeltas\":{\"0-10\":1116.9},\"damageTakenDiffPerMinDeltas\":{\"0-10\":-104.07999999999998},\"wardsPerMinDeltas\":{\"0-10\":0},\"assistedLaneKillsPerMinDeltas\":{\"0-10\":0},\"assistedLaneDeathsPerMinDeltas\":{\"0-10\":0},\"towerKillsPerMinCounts\":{\"0-10\":0},\"towerAssistsPerMinCounts\":{\"0-10\":0},\"inhibitorKillsPerMinCounts\":{\"0-10\":0},\"inhibitorAssistsPerMinCounts\":{\"0-10\":0},\"baronKillsPerMinCounts\":{\"0-10\":0},\"baronAssistsPerMinCounts\":{\"0-10\":0},\"dragonKillsPerMinCounts\":{\"0-10\":0},\"dragonAssistsPerMinCounts\":{\"0-10\":0},\"vilemawKillsPerMinCounts\":{\"0-10\":0},\"vilemawAssistsPerMinCounts\":{\"0-10\":0},\"elderLizardKillsPerMinCounts\":{\"0-10\":0},\"elderLizardAssistsPerMinCounts\":{\"0-10\":0},\"ancientGolemKillsPerMinCounts\":{\"0-10\":0},\"ancientGolemAssistsPerMinCounts\":{\"0-10\":0},\"role\":\"DUO_SUPPORT\",\"lane\":\"TOP\"}}]}}";

            Root info = JsonConvert.DeserializeObject<Root>(json);


            return View();
        }

        public IActionResult BattleList(int page, int limit)
        {
            // string webRootPath = _hostingEnvironment.WebRootPath;

            var championName = Request.Query["key[championName]"];          //英雄名
            var Win = Request.Query["key[Win]"];                            //Win or Fail
            var createtimerange = Request.Query["key[createtimerange]"];    //日期范围
            if (Request.Query["key[createtimerange]"].Count == 0)
            {
                string now = DateTime.Now.ToString("yyyy-MM-dd");
                string threeMothAgo = DateTime.Now.AddMonths(-3).ToString("yyyy-MM-dd");
                createtimerange = threeMothAgo + " - " + now;
            }
            string startTime = string.Empty;                                //开始时间
            string endTime = string.Empty;                                  //结束时间



            //添加 json 文件路径
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("goodsitem.json");
            //创建配置根对象
            var configurationRoot = builder.Build();

            //取配置根下的 name 部分
            var goodsdatas = configurationRoot.GetSection("data").GetChildren();

            string where = string.Empty;
            string whereStart = string.Empty;
            int whereCount = 0;
            if (!string.IsNullOrEmpty(championName))
            {
                where += $"and b.championName LIKE '%{championName}%'  ";
                whereCount++;
            }

            if (!string.IsNullOrEmpty(Win))
            {
                where += "and a.Win = '" + Win + "'";
                whereCount++;
            }

            if (!string.IsNullOrWhiteSpace(createtimerange))
            {
                startTime = createtimerange.ToString().Substring(0, 10)+" 00:00:00";
                endTime = createtimerange.ToString().Substring(13, createtimerange.ToString().Length - 13)+" 23:59:59";
                where += $"AND a.gameCreationTime BETWEEN '{startTime}' AND '{endTime}' ";
                whereCount++;
            }

            if (whereCount > 0)
            {
                whereStart = " where ";
                where = where.Substring(4, where.Length - 4);
            }

            var battleList = DapperHelper<BattleListVModel>.Query(@"
                SELECT * FROM (SELECT top(@pageSize * @pageIndex) ROW_NUMBER() over(order by gameCreationTime desc ) as nid,a.*,b.championName,b.HeroId,b.title FROM dbo.Battle_List a
                LEFT JOIN dbo.Data_Hero b ON a.championId = b.championId " + whereStart + where + @" 
                ) as temp
                WHERE temp.nid>(@pageSize*(@pageIndex-1)) 
                ORDER BY gameCreationTime desc  ", new { pageIndex = page, pageSize = limit, });

            //求
            var battleListAllItem = DapperHelper<BattleListVModel>.Query(@"SELECT * FROM dbo.Battle_List a 
     LEFT JOIN dbo.Data_Hero b ON a.championId = b.championId " + whereStart + where, null);

            //分组，来排名
            var q =
            from p in battleListAllItem
            group p by p.championName into g
            select g;
            //排行榜
            var rankinglist = q.OrderByDescending(s => s.Count()).Select(s => new { key = s.Key, count = s.Count() });

            List<Rangking> list = new List<Rangking>();

            int ranknum = 1;
            foreach (var ranking in rankinglist.Take(10))
            {
                list.Add(new Rangking { numId = ranknum, name = ranking.key, occurrenceCount = ranking.count });
                ranknum++;
            }

            foreach (BattleListVModel vModel in battleList)
            {
                foreach (var data in goodsdatas)
                {
                    if (vModel.Item0 == data.Key)
                    {
                        var res = data.GetSection("name");
                        vModel.Item0Name = res.Value;
                        vModel.Item0Img = "/img/goods/" + vModel.Item0 + ".png";
                    }
                    if (vModel.Item1 == data.Key)
                    {
                        var res = data.GetSection("name");
                        vModel.Item1Name = res.Value;
                        vModel.Item1Img = "/img/goods/" + vModel.Item1 + ".png";
                    }
                    if (vModel.Item2 == data.Key)
                    {
                        var res = data.GetSection("name");
                        vModel.Item2Name = res.Value;
                        vModel.Item2Img = "/img/goods/" + vModel.Item2 + ".png";
                    }
                    if (vModel.Item3 == data.Key)
                    {
                        var res = data.GetSection("name");
                        vModel.Item3Name = res.Value;
                        vModel.Item3Img = "/img/goods/" + vModel.Item3 + ".png";
                    }
                    if (vModel.Item4 == data.Key)
                    {
                        var res = data.GetSection("name");
                        vModel.Item4Name = res.Value;
                        vModel.Item4Img = "/img/goods/" + vModel.Item4 + ".png";
                    }
                    if (vModel.Item5 == data.Key)
                    {
                        var res = data.GetSection("name");
                        vModel.Item5Name = res.Value;
                        vModel.Item5Img = "/img/goods/" + vModel.Item5 + ".png";
                    }
                    if (vModel.Item6 == data.Key)
                    {
                        var res = data.GetSection("name");
                        vModel.Item6Name = res.Value;
                        vModel.Item6Img = "/img/goods/" + vModel.Item6 + ".png";
                    }
                }
            }


            return Json(new ResultModel<BattleListVModel>() { code = 0, count = battleListAllItem.Count, data = battleList, msg = "", rangkingList = list });
        }


        [HttpPost]
        public int AddBattleList(string json)
        {
            var arr = json.Substring(18, json.Length - 18);
            Root info = JsonConvert.DeserializeObject<Root>(arr);

            int count = DapperHelper<int>.QueryFirst("SELECT COUNT(*) FROM dbo.Battle_List WHERE gameId = @gameId", new { gameId = info.msg.gameInfo.gameId });

            if (count == 0)
            {
                ParticipantsItem participantsItem = new ParticipantsItem();
                //新增   
                foreach (var participants in info.msg.participants)
                {
                    if (participants.summonerName == "Tiger灬阿秋")
                    {
                        participantsItem = participants;
                    }
                }

                DateTime createtime = StampToDateTime(info.msg.gameInfo.gameCreationTime.ToString()).ToLocalTime();
                string insertSQL = @"  INSERT INTO dbo.Battle_List
                                      (
                                        championId ,
                                        item0 ,
                                        item1 ,
                                        item2 ,
                                        item3 ,
                                        item4 ,
                                        item5 ,
                                        item6 ,
                                        kills ,
                                        deathss ,
                                        assist ,
                                        gameId,
                                        gameCreationTime,
                                        win
                                      )
                                      VALUES  (
                                                @championId , -- championId - int
                                                @item0 , -- item0 - nvarchar(10)
                                                @item1 , -- item1 - nvarchar(10)
                                                @item2 , -- item2 - nvarchar(10)
                                                @item3 , -- item3 - nvarchar(10)
                                                @item4 , -- item4 - nvarchar(10)
                                                @item5 , -- item5 - nvarchar(10)
                                                @item6 , -- item6 - nvarchar(10)
                                                @kills , -- kills - int
                                                @deathss , -- deathss - int
                                                @assist , -- assist - int
                                                @gameId , -- gameId - nvarchar(15)
                                               @gameCreationTime,  -- datetime
                                                @win -- nvarchar(10)
                                              ) ";


                int result = DapperHelper<int>.Execute(insertSQL,
                    new
                    {
                        championId = participantsItem.championId,
                        item0 = participantsItem.stats.item0,
                        item1 = participantsItem.stats.item1,
                        item2 = participantsItem.stats.item2,
                        item3 = participantsItem.stats.item3,
                        item4 = participantsItem.stats.item4,
                        item5 = participantsItem.stats.item5,
                        item6 = participantsItem.stats.item6,
                        kills = participantsItem.stats.kills,
                        deathss = participantsItem.stats.deaths,
                        assist = participantsItem.stats.assists,
                        gameId = info.msg.gameInfo.gameId,
                        gameCreationTime = createtime,
                        win = participantsItem.stats.win
                    });

                return result;
            }
            else
            {
                //修改
                return 0;
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // 时间戳 转换为时间
        public DateTime StampToDateTime(string timeStamp)
        {
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long mTime = long.Parse(timeStamp + "0000");
            TimeSpan toNow = new TimeSpan(mTime);
            return startTime.Add(toNow);
        }
    }
}
