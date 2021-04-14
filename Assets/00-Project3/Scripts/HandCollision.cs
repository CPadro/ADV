using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandCollision : MonoBehaviour
{
    [SerializeField] Animator map;
    [SerializeField] Animator lid;
    [SerializeField] AudioSource shimmer;
    [SerializeField] AudioSource open;
    [SerializeField] AudioSource close;
    private void OnTriggerEnter(Collider collision) 
    {
        lid = collision.gameObject.GetComponent<Animator>();
        map.SetBool("lidOpened", !(map.GetBool("lidOpened")));
        lid.SetBool("touchedLid", !(lid.GetBool("touchedLid")));
        if(map.GetBool("lidOpened")) 
        {
            shimmer.Play();
            open.Play();
            close.Pause();
        }
        else {
            shimmer.Pause();
            close.Play();
            open.Pause();
        }
    }
}
