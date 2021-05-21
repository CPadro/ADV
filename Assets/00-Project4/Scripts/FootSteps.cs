using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour
{
    [SerializeField] AudioClip clip;
    private AudioSource source;
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Step()
    {
        source.PlayOneShot(clip);
    }
}
