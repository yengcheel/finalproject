using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public float attackRate = 0.1f;
    float nextAttackTime = 0f;
    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextAttackTime)
        {


            if (Input.GetKeyDown(KeyCode.Z))
            {
                Attack();
                nextAttackTime = Time.time + 0.95f / attackRate;
            }
            if(Input.GetKeyDown(KeyCode.A))
            {
                Attack2();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    }
    void Attack()
    {
        //Play attack animation
        animator.SetTrigger("Attack");
        //Detect enemy in range of attack
       
        //Damage enemy
       
    }
    void Attack2()
    {
        animator.SetTrigger("Attack2");
    }
}
