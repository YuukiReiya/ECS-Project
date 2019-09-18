using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Samples.Mono
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
            spawnCount = 0;
            prevTime = Time.time;
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
            for (int i = 0; i < spawnPerFrameCount; ++i)
            {
                var inst = Instantiate(prefab);
                var pos = inst.transform.position;

                float r = 100;
                pos.x = Random.Range(-r, r);
                pos.z = Random.Range(-r, r);
                inst.transform.position = pos;
                spawnCount++;
            }
        }
    }
}