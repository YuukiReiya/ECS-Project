using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

namespace Samples.ECS
{
    public class SpawnerProxy : MonoBehaviour, IConvertGameObjectToEntity
    {
        [SerializeField] GameObject prefab;
        [SerializeField] uint spwanPerFrameCpunt;
        [SerializeField] float intervalTime;
        public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
        {
            var data = new Spawner
            {
                intervalTime = this.intervalTime,
                spawnPerFrameCount = this.spwanPerFrameCpunt,
                count = 0
            };
            dstManager.AddComponentData(entity, data);
        }
    }
}