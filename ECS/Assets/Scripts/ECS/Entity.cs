using UnityEngine;
using Unity.Jobs;
using Unity.Entities;

namespace ECS
{
    /// <summary>
    /// ECSの実体
    /// </summary>
    public struct Entity : IComponentData
    {
        public float val;
    }

}