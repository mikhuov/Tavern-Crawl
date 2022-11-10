using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    public int health;

    void Start(){
       health = maxHealth; 
    }

    void Update(){
       
    }

    void TakeDamage(int damage) {
        health -= damage;
    }
}
