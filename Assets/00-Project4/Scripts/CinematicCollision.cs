using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CinematicCollision : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] PlayableDirector cutsceneCam;
    private void OnTriggerEnter(Collider trigger) 
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        cutsceneCam.Play();
        //player.SetActive(false);
        StartCoroutine(EndCutscene());
    }

    IEnumerator EndCutscene()
    {
        yield return new WaitForSeconds(10);
        //player.SetActive(true);
        cutsceneCam.Stop();
    }
}
