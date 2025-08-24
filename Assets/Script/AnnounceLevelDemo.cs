using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnnounceLevelDemo : MonoBehaviour
{
    void AnnounceLevel(string player, int level)
    {
        Debug.Log(player + " reached level " + level);
    }

    void Start()
    {
        AnnounceLevel("Isuru", 4);
        AnnounceLevel("Sahan", 7);
        AnnounceLevel("Amaya", 10);
    }
}
