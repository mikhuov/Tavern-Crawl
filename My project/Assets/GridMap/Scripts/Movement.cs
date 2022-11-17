using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Movement : MonoBehaviour {
    public Tilemap tilemap;
    public GameObject player1;
    public GameObject enemy;
    GameObject turnPlayer;
    Vector3 curosrPosition;
    Vector3 characterPosition;

    void Start() {
        turnPlayer = player1;
    }

    void Update() {
        if(Input.GetMouseButtonDown(0)) {
            curosrPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            curosrPosition.z = 0;
            Vector3Int cursorPos = tilemap.WorldToCell(curosrPosition);
            Debug.Log("tilemapPos " + cursorPos);
            characterPosition = Camera.main.ScreenToWorldPoint(turnPlayer.transform.position);
            Vector3Int charPosition = tilemap.WorldToCell(characterPosition);
    

            float distanceX = charPosition.x - cursorPos.x;
            float distanceY = charPosition.y - cursorPos.y;
            Debug.Log("distanceX " + distanceX + ' ' + distanceY);

            if(distanceX <= 5 || distanceY <= 5 ) {
            } else {
                turnPlayer.transform.position = tilemap.GetCellCenterWorld(cursorPos);
                if(turnPlayer != player1) {
                    turnPlayer = player1;
                } else {
                    turnPlayer = enemy;
                }
            }

        }
    }
}