using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 5;
    public int health;
    public Healthbar healthBar;
    public CombatSystem combatSystem;

    void Start(){
        health = maxHealth; 
        healthBar.SetCharacterHealth(maxHealth);
    }

    void Update(){
        combatSystem.Hit();
    }

    public void TakeDamage(int damage) {
        health -= damage;
        healthBar.SetCurrentHealth(health);
    }

    public void Attack() {
         
    }
}
