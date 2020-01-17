using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Progression : MonoBehaviour
{
    //insert player object data contrainer, not a gameobject this is because we need a non script object to hold current level
    public Player player;
    private int level;
    private float currentXP;
    private float maxXPToNextLevelUp;

    [Tooltip("This modifies the max xp for a level up after each level up increasing the max each level")]
    public float maxXPModifier;

    public GameObject progressBar;
    

    [Header("Debug")]
    public int levelDebug;
    public float currentXpDebug;
    

    // Start is called before the first frame update
    void Start()
    {
        level = 0; // need to find a way to record variaibles so that when loading a new scene we can load the previous variables. Mayber a scriptable object?
        currentXP = 0f;
        maxXPToNextLevelUp = 0f;

        if (maxXPModifier == 0f)
        {
            maxXPModifier = 1.1f;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        updateDebugVariables();
    }

    private void updateDebugVariables()
    {

    }
}
