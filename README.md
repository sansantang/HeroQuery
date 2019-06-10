# HeroQuery
英雄联盟战绩查询

## 需求
官网加载慢，不能自定义选择查看，不能统计等等。
自己写个，‘（＋﹏＋）′..

## 功能
1. 相较于初始版本，人物与装备图片化，更直观。（这才是主要需求）
2. 查询：名称，胜利或失败，时间范围
3. 新增选择后的人物排名

## BUG
1. 'goodsitem.json' 缺少“灵巧披风”，ID：1018，如果更新版本，需要手动添加，不然图片不显示
2. 数据人物可能有缺少，自己根据ID添加。（可能以后会更新，但愿吧 …⊙_⊙…  ）


# ASP.NET CORE 2.2 + MSSQL + LAYUI 
在LOL官网读取JS，获取JSON：https://lol.sw.game.qq.com/lol/commact/?proj=api&c=Battle&a=combatGains&areaId=27&gameId=1529525938&r1=combatGains
![enter description here](https://github.com/sansantang/HeroQuery/blob/master/REFERENCE/%E8%8B%B1%E9%9B%84%E6%88%90%E7%BB%A9%E6%9F%A5%E8%AF%A2.png?raw=true)

# 提示
先运行 DB/英雄联盟初始化.sql
