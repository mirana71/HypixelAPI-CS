using System;

namespace HypixelCSHARP
{
    public class UsageExample
    {
        private readonly string player = HypixelAPI.getPlayerByName("RapidTheNerd");
        private readonly string playerBoosters = HypixelAPI.getBoostersByUuid("43db704e-10b1-40b3-a38d-ce059de35a59");
        
        private void print()
        {
            Console.Write(player.ToString());
            Console.Write(playerBoosters.ToString());
        }
    }
   
}