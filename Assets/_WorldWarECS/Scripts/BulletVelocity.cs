///-----------------------------------------------------------------
///   Author : Dream Team                 
///   Date   : 19/02/2020 12:25
///-----------------------------------------------------------------
using Unity.Entities;
using UnityEngine;

namespace Com.DreamTeam.WorldWarECS
{
    public struct BulletVelocity : IComponentData
    {
        public Vector3 value;
    }
}