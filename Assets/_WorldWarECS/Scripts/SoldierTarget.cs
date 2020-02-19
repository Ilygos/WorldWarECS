///-----------------------------------------------------------------
///   Author : Dream Team                 
///   Date   : 19/02/2020 12:28
///-----------------------------------------------------------------
using Unity.Entities;
using UnityEngine;
namespace Com.DreamTeam.WorldWarECS
{
    public struct SoldierTarget : IComponentData
    {
        public GameObject value;
    }
}