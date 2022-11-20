using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int maxHealth = 20;
    public int health;
    public float attackRange = 1f;

    public Healthbar healthBar;
    public CombatSystem combatSystem;
    public Animator animator;
    public LayerMask enemyLayers;
    public Transform attackPoint;

    void Start(){
        health = maxHealth; 
        healthBar.SetCharacterHealth(maxHealth);
    }

    void Update(){
        if (Input.GetKeyDown(KeyCode.Space)) {
            combatSystem.Hit();
        }
    }

    public void TakeDamage(int damage) {
        health -= damage;
        healthBar.SetCurrentHealth(health);
    }

    public void Attack() {
        animator.SetTrigger("Attack");
        
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
       
        foreach(Collider2D enemy in hitEnemies) {
            enemy.GetComponent<Enemy>().TakeDamage(5);
        }
    }

    void OnDrawGizmosSelected() {
        if (attackPoint == null)

        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
