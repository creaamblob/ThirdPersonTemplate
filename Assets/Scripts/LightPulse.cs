using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class LightPulse : MonoBehaviour
{
    [SerializeField] private float PulseFreq;
    [SerializeField] private VolumeProfile vol;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float sine = (float)Math.Sin(Time.time * PulseFreq);
        float pulse = 0.5f + sine * 0.175f;
        
        if (vol.TryGet(out Bloom bloom)) {
            bloom.intensity.value = pulse;
        }
    }
}
