using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Collections;

//参考:http://ghoul-life.hatenablog.com/entry/2019/05/12/164539

namespace ECS
{
    /// <summary>
    /// ECS使った命令を行う管理機構
    /// </summary>
    public class Manager : MonoBehaviour
    {
        [SerializeField] private Mesh _mesh;
        [SerializeField] private Material _mat;

        [SerializeField] private int _createCount = 1;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void Init()
        {
            var entityManager = World.Active.EntityManager;

            var entityArcheType = entityManager.CreateArchetype(
               typeof(Unity.Rendering.RenderMesh),
               typeof(Unity.Transforms.LocalToWorld),
               typeof(Unity.Transforms.Translation)
                );
            NativeArray<Entity> entities = new NativeArray<Entity>(_createCount, Allocator.Temp);

        }
    }

}