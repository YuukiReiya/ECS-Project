using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Burst;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace MyECS
{
    public class UpDownSystem : JobComponentSystem
    {
        [BurstCompile]
        struct MoveUpDown : IJobParallelFor
        {
            public void Execute(int i)
            {
                Debug.Log("c");
            }
        }

        protected override JobHandle OnUpdate(JobHandle inputDeps)
        {
            var job = new MoveUpDown { };
            return inputDeps;
        }
    }
}