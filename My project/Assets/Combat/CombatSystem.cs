using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatSystem : MonoBehaviour
{
    public Player player;
    public Enemy enemy;
    public Healthbar healthBar;


    public void Hit() {
        player.Attack();
    }
}
