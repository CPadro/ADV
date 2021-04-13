using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandCollision : MonoBehaviour
{
    Animator anim;
    private void OnTriggerEnter(Collider collision) 
    {
        anim = collision.gameObject.GetComponent<Animator>();
        anim.SetBool("lidOpened", !(anim.GetBool("lidOpened")));
        anim.SetBool("touchedLid", !(anim.GetBool("touchedLid")));
    }
}
