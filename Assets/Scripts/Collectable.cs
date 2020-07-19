using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    GameController gameController;

    private void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.GetComponent<Rigidbody>())
        {
            gameController.CollectableHit(gameObject);
        }
    }
}
