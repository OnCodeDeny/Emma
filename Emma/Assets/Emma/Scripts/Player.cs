using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    Vector3 offScreen = new Vector3(1000f, 1000f, 1000f);

    // Start is called before the first frame update
    void Start()
    {
        //DontDestroyOnLoad(player);
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (GameObject.FindGameObjectWithTag("Leaf Pile Leaf"))
        {
            transform.position += offScreen;
        }
    }
}
