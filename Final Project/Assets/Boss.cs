using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxHealth = 100;
    int currentHealth;
    public Transform player;
    public Animator animator;
    public LayerMask Playerlayer;
    public PlayerBehaviour playerdmg;
    public CountDownTimer timer;
   

  
    private void OnTriggerExit2D(Collider2D player)
    {
        playerdmg.PlayerTakeDmg(20);
    }
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if(currentHealth == 50)
        {
            animator.SetTrigger("50%");
        }
        if(currentHealth <= 0)
        {
            Die();
            
        }
    }
    void Die()
    {
        //Die animatuon
        //Disable boss
        animator.SetTrigger("dragon_die");
        timer.StopTime();
    }
}
