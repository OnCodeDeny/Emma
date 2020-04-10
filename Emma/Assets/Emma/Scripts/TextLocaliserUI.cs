using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// from tutorial https://www.youtube.com/watch?v=c-dzg4M20wY

// if all text is sdf:
[RequireComponent(typeof(TextMeshProUGUI))]
// but will still work fine with standard text rendering
public class TextLocaliserUI : MonoBehaviour
{
    TextMeshProUGUI textfield;

    public string key;

    // Start is called before the first frame update
    void Start()
    {
        // tell the text box to set itself to 
        // the localised value returned from 
        // the localisation system based on the key
        textfield = GetComponent<TextMeshProUGUI>();
        string value = LocalisationSystem.GetLocalisedValue(key);
        textfield.text = value;
    }

}
