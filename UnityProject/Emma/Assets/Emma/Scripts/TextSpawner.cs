using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSpawner : MonoBehaviour
{

    public Text acornTextPrefab;
    public GameObject renderCanvas;

    // Start is called before the first frame update
    void Start()
    {
        Text tempAcornText = Instantiate(acornTextPrefab, transform.position, transform.rotation) as Text;
        tempAcornText.transform.SetParent(renderCanvas.transform, false);
    }
}
