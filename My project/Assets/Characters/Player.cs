using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int health;
    public Healthbar healthBar;
    public CombatSystem combatSystem;

    void Start(){
       health = maxHealth; 
       healthBar.SetCurrentHealth(maxHealth);
    }

    void Update(){
       if(GetHit()) {
        TakeDamage(1);
       }
    }

    void TakeDamage(int damage) {
        health -= damage;
        healthBar.SetCurrentHealth(health);
    }

    bool GetHit() {
        return true;
    }
}
