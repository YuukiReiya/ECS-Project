using System.Collections.Generic;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

namespace MyECS
{
    [UpdateInGroup(typeof(SimulationSystemGroup))]
    [UpdateAfter(typeof(TransformSystemGroup))]
    public class SpawnerSystem : ComponentSystem
    {
        protected override void OnUpdate()
        {
            Entities.ForEach((Entity e, Component.Spawner spawner, ref LocalToWorld localToWorld) =>
            {
                int spawnCount = spawner._count;

                var spawnPositions = new NativeArray<float3>(spawnCount, Allocator.TempJob);
                GeneratePoints.RandomPointsInUnitSphere(spawnPositions);
                var entities = new NativeArray<Entity>(spawnCount, Allocator.TempJob);
                for (int i = 0; i < spawnCount; ++i) { entities[i] = PostUpdateCommands.Instantiate(spawner._prefab); }
                for (int i = 0; i < spawnCount; i++)
                {
                    PostUpdateCommands.SetComponent(entities[i], new LocalToWorld
                    {
                        Value = float4x4.TRS(
                            localToWorld.Position + (spawnPositions[i] * spawner._radius),
                            quaternion.LookRotationSafe(spawnPositions[i], math.up()),
                            new float3(1.0f, 1.0f, 1.0f))
                    });
                }

                PostUpdateCommands.RemoveComponent<Component.Spawner>(e);
                spawnPositions.Dispose();
                entities.Dispose();
            });
        }
    }
}