using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingController : MonoBehaviour
{
    public Transform ball;
    public int ringCount;
    private GameManager gameManager;

    void Start() {
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }


    void Update() {
        if (transform.position.y >= ball.position.y) {
            Destroy(gameObject);
            gameManager.gameScore(5);

        }
    }
}
