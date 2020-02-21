using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Detect if an gameobject with a specific tag is in range.

/* Dependencies:
 * Tag of target gameobject
 * Rigidbody
 * Collider (visualize range)
 */

public class ObjectDetector : MonoBehaviour
{
    public bool isObjectInRange;
    public string objectTag;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == objectTag)
        {
            isObjectInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == objectTag)
        {
            isObjectInRange = false;
        }
    }
}
