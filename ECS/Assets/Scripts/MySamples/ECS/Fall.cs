using System;
using Unity.Entities;

namespace Samples.ECS
{
    public struct Fall : IComponentData
    {
        public float speed;
    }
}