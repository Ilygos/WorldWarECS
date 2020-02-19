///-----------------------------------------------------------------
///   Author : Dream Team                 
///   Date   : 19/02/2020 12:29
///-----------------------------------------------------------------
using Unity.Entities;

public enum Teams
{ 
    BLUE,
    RED
}


namespace Com.DreamTeam.WorldWarECS
{
    public struct SoldierTeam : IComponentData
    {
        public Teams value; 
    }
}