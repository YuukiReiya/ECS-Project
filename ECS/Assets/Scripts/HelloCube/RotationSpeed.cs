using System;
using Unity.Entities;

namespace Samples.HelloCube
{
    [Serializable]
    public struct RotationSpeed : IComponentData
    {
        public float radiansPerSpeed;
    }
}