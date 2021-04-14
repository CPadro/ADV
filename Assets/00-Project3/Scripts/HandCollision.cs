using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandCollision : MonoBehaviour
{
    [SerializeField] Animator treasure;
    private void OnTriggerEnter(Collider collision) 
    {
        treasure = collision.gameObject.GetComponent<Animator>();
        treasure.SetBool("touchedLid", !(treasure.GetBool("touchedLid")));
    }
}
