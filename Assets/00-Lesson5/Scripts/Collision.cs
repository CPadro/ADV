using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    Animator anim;
    private void OnTriggerEnter(Collider collision) 
    {
        anim = collision.gameObject.GetComponent<Animator>();
        anim.SetBool("Kicked", !(anim.GetBool("Kicked")));
    }
}
