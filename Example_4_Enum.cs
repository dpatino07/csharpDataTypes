using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_4_Enum : MonoBehaviour
{
    enum LevelOfDifficulty { easy, medium, hard, insane };

    LevelOfDifficulty levelOfDifficulty = LevelOfDifficulty.easy;

    void Start()
    {
        Debug.Log("Starting level of difficulty: " + levelOfDifficulty);
    }

}