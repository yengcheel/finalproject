using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxHealth = 300;
    public int currentHealth;
    public Transform player;
    public Animator animator;
    public LayerMask Playerlayer;
    public PlayerBehaviour playerdmg;
    public CountDownTimer timer;
    private bool isDead;
    public WinScript win;


     void OnTriggerExit2D(Collider2D Player)
    {
        int num = Random.Range(8, 16);
        playerdmg.PlayerTakeDmg(num);
        
    }
    
    public void Start()
    {
        currentHealth = maxHealth;
    }
    void Update()
    {
        if (GameManager.gameManager._playerHealth.Health <= 0)
        {
            
            animator.enabled = false;
        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if(currentHealth == 150)
        {
            animator.SetTrigger("50%");
            
        }
        if (currentHealth == maxHealth * 0.25) 
        {
            animator.SetTrigger("25%");
           
        }
        if(currentHealth <= 0)
        {
            Die();
            currentHealth = 0;
           
        }
    }
    void Die()
    {
        //Die animatuon
        //Disable boss
        animator.SetTrigger("dragon_die");
        win._win();
        
    }
}
