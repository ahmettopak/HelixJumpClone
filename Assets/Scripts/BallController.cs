using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class BallController : MonoBehaviour
{

    private Rigidbody rigidbody;
    //[SerializeField] private GameObject splashImg;
    [SerializeField] private float jumpForce;
    private GameManager gameManager;
    private RingController ring;

    void Start() {
        rigidbody= GetComponent<Rigidbody>();
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter(Collision other) {
        rigidbody.AddForce(Vector3.up * jumpForce);
        //GameObject splash = Instantiate(splashImg, transform.position - new Vector3(0, 0.22f, 0f), transform.rotation);
        // splash.transform.SetParent(other.gameObject.transform);
        //Destroy(splash, 1);

        
        if (other.gameObject.tag=="UnSafeArea") {
            Debug.Log("Rest");
            gameManager.restartGame();
        }
        else if (other.gameObject.tag=="FinishArea") {
            Debug.Log("Finish");

        }
    }
}
