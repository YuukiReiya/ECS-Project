using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace Samples.HelloCube
{

    public class RotationSpeedSystem : ComponentSystem
    {
        protected override void OnUpdate()
        {
            Entities.ForEach((ref RotationSpeed rotSpeed, ref Rotation rot) =>
            {
                var deltaTime = Time.deltaTime;
                rot.Value = math.mul(math.normalize(rot.Value),
                    quaternion.AxisAngle(math.up(), rotSpeed.radiansPerSpeed * deltaTime));
            });
        }
    }
}