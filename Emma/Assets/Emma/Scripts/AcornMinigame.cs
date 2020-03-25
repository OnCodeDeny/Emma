using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcornMinigame : MonoBehaviour
{
    //This varable represents the value of each acorn on screen(# of acorns get once clicked an acorn on screen).
    public int amount;

    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Emma");
    }

    // When the acorn is clicked, it gets added to the amount andis destroyed
    private void OnMouseUpAsButton()
    {
            player.GetComponent<Player>().GetAcorn(amount);
            Destroy(gameObject);
    }
}
