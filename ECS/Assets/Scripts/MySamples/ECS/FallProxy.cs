using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace Samples.ECS
{
    [RequiresEntityConversion]
    public class FallProxy : MonoBehaviour,IConvertGameObjectToEntity
    {
        public void Convert(Entity e,EntityManager dstManager,GameObjectConversionSystem convSystem)
        {
            var data = new Fall { speed = UnityEngine.Random.Range(0.1f, 0.5f) };
            dstManager.AddComponentData(e, data);
        }
    }
}