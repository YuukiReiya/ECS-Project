using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace Samples.ECS
{
    public class FallSystem : ComponentSystem
    {
        protected override void OnUpdate()
        {
            Entities.ForEach((ref Fall component, ref Translation pos) =>
            {
                pos.Value.y -= component.speed;
            });
        }
    }
}