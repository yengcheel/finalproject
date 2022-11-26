using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerBehaviour : MonoBehaviour
{
    
    [SerializeField] Healthbar _healthbar;
    public Animator animator;
    public RigidbodyConstraints2D constraints2D;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            PlayerTakeDmg(10);
            Debug.Log(GameManager.gameManager._playerHealth.Health);
            animator.SetTrigger("oof");
            
        }
        if (GameManager.gameManager._playerHealth.Health == 0)
        {
            animator.SetTrigger("death");
            constraints2D.FreezeAll;
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            PlayerHeal(20);
            Debug.Log(GameManager.gameManager._playerHealth.Health);
        }
       
    }
    private void PlayerTakeDmg(int dmg)
    {
        GameManager.gameManager._playerHealth.DmgUnit(dmg);
        _healthbar.SetHealth(GameManager.gameManager._playerHealth.Health);
    }
    private void PlayerHeal(int healing)
    {
        GameManager.gameManager._playerHealth.HealUnit(healing);
        _healthbar.SetHealth(GameManager.gameManager._playerHealth.Health);

    }
}
