using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{

void Start()
 {
     Destroy(GameObject.Find("Emma"));
     Destroy(GameObject.Find("Acorn Text"));
 }

}
