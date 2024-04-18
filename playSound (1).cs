using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playSound : MonoBehaviour
{
    private AudioSource m_AudioSource;
    [SerializeField] private string NewGameLevel = "Win";

    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        m_AudioSource.Play();
        SceneManager.LoadScene(NewGameLevel);
    }
}
