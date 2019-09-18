using System;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;


namespace Samples.ECS
{
    public struct Spawner : IComponentData
    {
        //public GameObject prefab;
        public uint spawnPerFrameCount;
        public float intervalTime;
        public uint count;
    }
}