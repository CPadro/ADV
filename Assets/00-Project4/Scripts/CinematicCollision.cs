using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class CinematicCollision : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] PlayableDirector cutsceneCam;
    private void OnTriggerEnter(Collider trigger) 
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        cutsceneCam.Play();
        StartCoroutine(EndCutscene());
    }

    IEnumerator EndCutscene()
    {
        yield return new WaitForSeconds(22);
        cutsceneCam.Stop();
        SceneManager.LoadScene("Project4");
    }
}
