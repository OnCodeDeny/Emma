using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafSwipe : MonoBehaviour
{

    Vector3 direction;

    // Move a leaf in a random direction when it is clicked
    private void OnMouseDown()
    {        
        direction = Random.insideUnitCircle.normalized;
        transform.Translate(direction, Space.World);
    }
}
