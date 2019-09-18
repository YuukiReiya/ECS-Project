using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Samples.Mono
{
    public class Fall : MonoBehaviour
    {
        float speed;
        // Start is called before the first frame update
        void Start()
        {
            speed = Random.Range(0.1f, 0.5f);
        }

        // Update is called once per frame
        void Update()
        {
            var pos = transform.position;
            pos += Vector3.down * speed;
            transform.position = pos;
        }
    }
}