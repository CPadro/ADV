using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandCollision : MonoBehaviour
{
    [SerializeField] Animator map;
    [SerializeField] Animator lid;
    private void OnTriggerEnter(Collider collision) 
    {
        lid = collision.gameObject.GetComponent<Animator>();
        map.SetBool("lidOpened", !(map.GetBool("lidOpened")));
        lid.SetBool("touchedLid", !(lid.GetBool("touchedLid")));
    }
}
