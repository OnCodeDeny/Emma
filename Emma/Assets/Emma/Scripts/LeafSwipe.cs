using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafSwipe : MonoBehaviour
{

    Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        //playerDetector = transform.Find("PlayerDetector").gameObject.GetComponent<ObjectDetector>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Click leaf pile to enter minigame
    private void OnMouseDown()
    {
        direction = Random.insideUnitCircle.normalized;
        transform.Translate(direction, Space.World);
    }
}
