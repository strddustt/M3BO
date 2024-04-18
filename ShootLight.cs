using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShootLight : MonoBehaviour
{
    private Light lc;
    private AudioSource m_AudioSource;
    private float cooldown;
    [SerializeField] private float cooldownTime = 4;
    [SerializeField] private float lighttime = 1;
    void Start()
    {
        lc = GetComponent<Light>();
        m_AudioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (cooldown <= lighttime)
        {
            lc.enabled = false;
        }

        if (cooldown <= 0 && Input.GetMouseButtonDown(0))
        {
            lc.enabled = true;
            m_AudioSource.Play();
            cooldown = cooldownTime;
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        }


        cooldown -= Time.deltaTime;
    }
}
