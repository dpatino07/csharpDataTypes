using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_3_Array_Lists : MonoBehaviour
{
    public string[] playerNames = new string[3];

    public List<string> enemyNames = new List<string>();

    void Start()
    {
        // playerNames[0] = "Dom";
        // playerNames[1] = "Nick";
        // playerNames[2] = "Khinn";

        // enemyNames.Add("Boss 1");
        // enemyNames.Add("Big Boss");
        // enemyNames.Add("Bigger Boss");

        Debug.Log("Player Name is: " + playerNames[0] + " and Enemy Name is: " + enemyNames[2]);

    }
}
