using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
namespace Samples.ECS
{

    public class SpawnerSystem : ComponentSystem
    {
       // float prevTime = Time.time;
        protected override void OnUpdate()
        {
            //メイン処理
            Entities.ForEach((ref Spawner component) =>
            {
                //if (Time.time > prevTime + component.intervalTime)
                //{
                //    //生成処理
                //    for (int i = 0; i < component.spawnPerFrameCount; ++i)
                //    {
                //        //var inst = GameObject.Instantiate(component.prefab);
                //        //var pos = inst.transform.position;
                //        //const float r = 100;
                //        //pos.x = Random.Range(-r, r);
                //        //pos.z = Random.Range(-r, r);
                //        //inst.transform.position = pos;
                //    }
                //    prevTime = Time.time;
                //}
            });
        }

    }
}