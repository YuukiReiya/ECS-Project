using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace Samples.HelloCube
{
    [RequiresEntityConversion]
    public class RotationSpeedProxy : MonoBehaviour,IConvertGameObjectToEntity
    {
        public float degreesPerSecond = 360;

        public void Convert(Entity entity,EntityManager dstManager,GameObjectConversionSystem convSystem)
        {
            var data = new RotationSpeed
            {
                radiansPerSpeed = math.radians(degreesPerSecond)
            };
            dstManager.AddComponentData(entity, data);
        }
    }
}