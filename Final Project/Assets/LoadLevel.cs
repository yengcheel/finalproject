using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    // Start is called before the first frame update
    void Start()
    {

    }


 
        void OnTriggerEnter2D(Collider2D collision)
        {
            GameObject collisionGameObject = collision.gameObject;

            if (collisionGameObject.name == "Player")
            {
                LoadScene();
            }
        }
    
    

    void LoadScene()
    {
        StartCoroutine(LevelLoader(SceneManager.GetActiveScene().buildIndex + 1));
    }


    IEnumerator LevelLoader(int levelIndex)
    {
        //play animation
        transition.SetTrigger("Start");
        //wait
        yield return new WaitForSeconds(transitionTime);
        //load scene 
        SceneManager.LoadScene(levelIndex);
    }
}
