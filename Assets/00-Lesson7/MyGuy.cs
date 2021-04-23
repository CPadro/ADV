using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGuy : MonoBehaviour
{
    public float downAccel = 1f;
    public Animator animator;
    public CharacterController charController;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        charController.Move(Vector3.down * downAccel * Time.deltaTime);
        // Go forwards
        if (Input.GetKey(KeyCode.I))
        {
            if (animator.GetFloat("Vertical") < 1) { animator.SetFloat("Vertical", animator.GetFloat("Vertical") + 0.02f); }
        }
        // Go backwards
        else if (Input.GetKey(KeyCode.K))
        {
            if (animator.GetFloat("Vertical") > -1) { animator.SetFloat("Vertical", animator.GetFloat("Vertical") - 0.02f);}
        }
        else { 
            if (animator.GetFloat("Vertical") < 0) { animator.SetFloat("Vertical", animator.GetFloat("Vertical") + 0.02f); }
            if (animator.GetFloat("Vertical") > 0) { animator.SetFloat("Vertical", animator.GetFloat("Vertical") - 0.02f); }
        }
        // Go left
        if (Input.GetKey(KeyCode.J))
        {
            if (animator.GetFloat("Horizontal") < 1) { animator.SetFloat("Horizontal", animator.GetFloat("Horizontal") - 0.02f); }
        }
        // Go right
        else if (Input.GetKey(KeyCode.L))
        {
            if (animator.GetFloat("Horizontal") < 1) { animator.SetFloat("Horizontal", animator.GetFloat("Horizontal") + 0.02f); }
        }
        else
        {
            if (animator.GetFloat("Horizontal") < 0) { animator.SetFloat("Horizontal", animator.GetFloat("Horizontal") + 0.02f); }
            if (animator.GetFloat("Horizontal") > 0) { animator.SetFloat("Horizontal", animator.GetFloat("Horizontal") - 0.02f); }
        }
    }
}
