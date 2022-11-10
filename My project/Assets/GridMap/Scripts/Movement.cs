using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Movement : MonoBehaviour {
    public Vector3 curosrPosition;
    public Tilemap tilemap;
    public GameObject turnPlayer;
    public GameObject player1;
    public GameObject player2;
    int maxMoveDistance = 5;

    void Start() {
        turnPlayer = player1;
    }

    void Update() {
        if(Input.GetMouseButtonDown(0)) {
            curosrPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            curosrPosition.z = 0;
            Vector3Int tilemapPos = tilemap.WorldToCell(curosrPosition);
            float distanceX = transform.position.x - tilemapPos.x;
            float distanceY = transform.position.y - tilemapPos.y;
            Debug.Log(distanceY + " " + distanceX);

            if(distanceX > maxMoveDistance || distanceY > maxMoveDistance ) {
            } else {
                turnPlayer.transform.position = tilemap.GetCellCenterWorld(tilemapPos);
                if(turnPlayer != player1) {
                    turnPlayer = player1;
                } else {
                    turnPlayer = player2;
                }
            }

        }
    }
}