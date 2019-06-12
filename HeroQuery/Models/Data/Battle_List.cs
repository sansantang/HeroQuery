using System;
public class Battle_List
{
    public int Id { get; set; }
    public int ChampionId { get; set; }
    public string Item0 { get; set; }
    public string Item1 { get; set; }
    public string Item2 { get; set; }
    public string Item3 { get; set; }
    public string Item4 { get; set; }
    public string Item5 { get; set; }
    public string Item6 { get; set; }
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
}
