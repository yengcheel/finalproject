using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 60f;
    float stoptime;
    float timespent;
    public Animator animator;
    public Text CountDownText;
    public GameOver lose;
    public Animator player;
    public Boss boss;
    public Text timetaken;
    
   
   

    void Start()
    {
        currentTime = startingTime;
        

    }
    void Update()
    {

        stoptime = currentTime;
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
        if (currentTime <= 1.6)
        {
            player.SetTrigger("death");
            lose._gameOver();
        }
        if(currentTime <= 0.9)
        {
            animator.enabled = false;
            player.enabled = false; 
           
            
            
        }
        if(boss.currentHealth == 0)
        {
            currentTime = stoptime;
            timespent = startingTime - stoptime;
            timetaken.text = timespent.ToString(".0");
        }
        if(GameManager.gameManager._playerHealth.Health <= 0)
        {
            currentTime = stoptime;
        }
       
    }
}
