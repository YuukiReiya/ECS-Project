using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedFPS : MonoBehaviour
{
    [SerializeField]
    uint fixedFPS = 60;
    public uint FPS { get { return fixedFPS; } }

    private void Awake()
    {
        Application.targetFrameRate = (int)fixedFPS;
    }
}
