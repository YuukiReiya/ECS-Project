using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Jobs;
using Unity.Entities;
using Unity.Transforms;
using System;
using Unity.Mathematics;

namespace ECS
{

    public class System : JobComponentSystem
    {
        private struct JobTask : IJobProcessComponentData<Translation, Rotation, ECS.Entity>
        {
            public float DeltaTime;
            public void Execute(ref Translation pos,ref Rotation rot,ref ECS.Entity entity )
            {
                pos.Value.y -= entity.val * DeltaTime;
            }
        }

        protected override JobHandle OnUpdate(JobHandle inputDeps)
        {
            var job = new JobTask
            {
                DeltaTime = Time.deltaTime
            };

            return job.Schedule(this, 64, inputDeps);
        }
    }
}