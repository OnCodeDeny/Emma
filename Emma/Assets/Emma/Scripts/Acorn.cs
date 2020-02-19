using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acorn : MonoBehaviour
{
    public GameObject player;
    public int amount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseUpAsButton()
    {
        player.SendMessage("GetAcorn", amount, SendMessageOptions.DontRequireReceiver);
        Destroy(gameObject);
    }
}
