using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
namespace Samples.ECS.N
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] GameObject prefab;
        [SerializeField] uint spawnPerFrameCount = 100;
        uint spawnCount;
        [SerializeField] TMPro.TextMeshProUGUI text;
        [Header("spawn")]
        [SerializeField] float intervalTime = 1.0f;
        float prevTime;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Time.time > prevTime + intervalTime)
            {
                Spawn();
                prevTime = Time.time;
            }
            text.text = "SpawnCount:" + spawnCount;

        }

        void Spawn()
        {
            Entity prefab = GameObjectConversionUtility.ConvertGameObjectHierarchy(this.prefab, World.Active);
            var entityManager = World.Active.EntityManager;
            for(int i=0;i<spawnPerFrameCount;++i)
            {
                var inst = entityManager.Instantiate(prefab);
                
                //生成位置
                const float heigh = 5.71f;//y
                const float r = 100;
                var pos = transform.TransformPoint(new float3(UnityEngine.Random.Range(-r, r), heigh,UnityEngine.Random.Range(-r, r)));
                entityManager.SetComponentData(inst, new Translation() { Value = pos });
                spawnCount++;
            }
        }
    }
}