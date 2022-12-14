using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerBehaviour : MonoBehaviour
{
    
    [SerializeField] Healthbar _healthbar;
    public Animator animator;
    public RigidbodyConstraints2D constraints2D;
    public GameOver gameOver;
    private bool isDead;
    
    
    


    void Update()
    {
        
        if (GameManager.gameManager._playerHealth.Health <= 0 && !isDead)
        {
            
            isDead = true;
            gameOver._gameOver();
            animator.SetTrigger("death");
            


        }
    }
    public void PlayerTakeDmg(int dmg)
    {
        GameManager.gameManager._playerHealth.DmgUnit(dmg);
        _healthbar.SetHealth(GameManager.gameManager._playerHealth.Health);
        animator.SetTrigger("oof");
        
    }
    private void PlayerHeal(int healing)
    {
        GameManager.gameManager._playerHealth.HealUnit(healing);
        _healthbar.SetHealth(GameManager.gameManager._playerHealth.Health);

    }
}
