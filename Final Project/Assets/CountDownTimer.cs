using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 60f;
    public Animator animator;
    public Text CountDownText;
    public GameOver lose;
    public Animator player;

    void Start()
    {
        currentTime = startingTime;

    }
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        CountDownText.text = currentTime.ToString(".0");
        if (currentTime <= 0)
        {
            currentTime = 0;
        }
        if (currentTime <= 7)
        {
            animator.SetTrigger("novatime");
           
        }
        if (currentTime <= 1.9)
        {
            player.SetTrigger("death");
            lose._gameOver();
        }
        if(currentTime <= 0.9)
        {
            animator.enabled = false;
            player.enabled = false; 
           
            
            
        }
       
    }
}