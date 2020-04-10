using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalisationSystem : MonoBehaviour
{
    // from tutorial https://www.youtube.com/watch?v=c-dzg4M20wY

    public enum Language
    {
        English,
        French
    }

    public static Language language = Language.English;

    private static Dictionary<string, string> localisedEN;
    private static Dictionary<string, string> localisedFR;

    public static bool isInit;
    
    //Function 1: initialize all the values
    // function to initialize our localisation system and 
    // read the data from the CSV
    public static void Init()
    {
        // load the CSV
        CSVLoader csvLoader = new CSVLoader();
        csvLoader.LoadCSV();

        // assign the dictionary to each of our languages using their attribute IDs en and fr
        localisedEN = csvLoader.GetDictionaryValues("en");
        localisedFR = csvLoader.GetDictionaryValues("fr");

        // set to true to tell the system we've loaded the values
        isInit = true;
    }

    // Function 2: return a localised value to a text element
    // return the value based on the key passed into the function
    public static string GetLocalisedValue(string key)
    {
        // tell the system to initialise if it hasn't already
        if(!isInit) { Init(); }

        // set the correct value based on the currently selected language
        string value = key;

        switch (language)
        {
            case Language.English:
                localisedEN.TryGetValue(key, out value);
                break;
            case Language.French:
                localisedFR.TryGetValue(key, out value);
                break;
        }

        return value;
    }
}
