using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask bosslayer;
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
        Collider2D[] hitboss = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, bosslayer);
        //Damage enemy
       foreach(Collider2D enemy in hitboss)
        {
            enemy.GetComponent<Boss>().TakeDamage(10);
        }
    }
    void Attack2()
    {
        animator.SetTrigger("Attack2");
        Collider2D[] hitboss = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, bosslayer);
        foreach (Collider2D enemy in hitboss)
        {
            enemy.GetComponent<Boss>().TakeDamage(5);
        }
    }
    void OnDrawGizmosSelected()
    {
        if (attackPoint == null) { return; }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
