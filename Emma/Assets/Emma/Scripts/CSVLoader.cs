using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
using System.IO;
using System;

public class CSVLoader
{
    // Reference file;

    // Reference to our file
    private TextAsset csvFile;

    // defining variables for how to pass the sheet properly
    // character for the line separator:
    private char lineSeparator = '\n';
    // character we use to define an entry
    private char surround = '"';
    // the separator we use for defining each value 
    // (encapsulate it like this because don't want parser to break up text with commas in it)
    private string[] fieldSeparator = { "\",\"" };

    // a function to load the CSV file and assign it
    public void LoadCSV()
    {
        csvFile = Resources.Load<TextAsset>("localisation");
    }

    // Parser function
    // in engine will break values up into each of their languages
    // so we want to pass an attribute ID, 
    // which we define in the first line of the CSV file ("key","en","fr")
    // the function will return a list for each value in that language
    public Dictionary<string, string> GetDictionaryValues(string attributeId)
    {
        // create a dictionary to store our elements in
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        // break the text file up into its lines
        string[] lines = csvFile.text.Split(lineSeparator);
        
        // get the ID headers we added to the top of the CSV
        int attributeIndex = -1;
        // so the function can identify the location of each language value in our list
        string[] headers = lines[0].Split(fieldSeparator, StringSplitOptions.None);


        // allows to add more languages easily by simply adding a new value to each line
        // and an identifier at the header of the file
        for (int i = 0; i < headers.Length; i++)
        {
            if (headers[i].Contains(attributeId))
            {
                attributeIndex = i;
                break;
            }
        }

        // regular expression to define the parametres of splitting the line up
        Regex CSVParser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]\"))");

        
       
        
        for (int i = 0; i < lines.Length; i++)
        {
            // go through each of the lines in the list
            string line = lines[i];
            // break the lines into fields
            string[] fields = CSVParser.Split(line);
            // trim off the quotation marks surrounding our values
            for (int f = 0; f < fields.Length; f++)
            {
                fields[f] = fields[f].TrimStart(' ', surround);
                fields[f] = fields[f].TrimEnd (surround);
            }

            // make sure there are enough fields in the line
            if (fields.Length > attributeIndex)
            {
                // and if there is, assign the first field in the line as the key
                var key = fields[0];
                // check if the dictionary already contains that key
                if(dictionary.ContainsKey(key)) { continue; }
                // if it doesn't, we assign the element at the attribute Index as the value
                var value = fields[attributeIndex];
                // then add both of these to the dictionary
                dictionary.Add(key, value);
            }
        }

        return dictionary;
    }
}
