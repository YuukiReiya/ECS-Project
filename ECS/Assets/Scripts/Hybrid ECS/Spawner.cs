using System;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;


namespace MyECS
{
    namespace Component
    {
        public struct Spawner : ISharedComponentData
        {
            public Entity _prefab;
            public float _radius;
            public int _count;
        }
    }

    [RequiresEntityConversion]
    public class Spawner:MonoBehaviour,IDeclareReferencedPrefabs,IConvertGameObjectToEntity
    {
        public GameObject _prefab;
        public float _radius;
        public int _count;

        public void Convert(Entity entity,EntityManager manager,GameObjectConversionSystem convSystem)
        {
            var spawnerData = new Component.Spawner
            {
                _prefab = convSystem.GetPrimaryEntity(_prefab),
                _radius = _radius,
                _count = _count
            };
            manager.AddSharedComponentData(entity, spawnerData);
        }

        public void DeclareReferencedPrefabs(List<GameObject> prefabs)
        {
            prefabs.Add(_prefab);
        }
    }
}