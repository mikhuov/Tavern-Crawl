using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    void Death(){
        if(health <= 0){
            SceneManager.LoadScene(2);
        }
    }

    void Update(){
        Death();
    }

    public void TakeDamage(int damage) {
        health -= damage;
        healthBar.SetCurrentHealth(health);
    }

    public void Attack() {
         
    }

}
