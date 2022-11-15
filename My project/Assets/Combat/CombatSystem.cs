using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatSystem : MonoBehaviour
{
    public Player player;
    public Enemy enemy;
    public Healthbar healthBar;


    void Start() {

    }

    public void Hit() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            enemy.TakeDamage(5);
        }
    }
}
