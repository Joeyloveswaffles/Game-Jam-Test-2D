﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   //  public Player_Object playerDataObject; //we need a player scriptable object to pass data between levels to the scripts start methods
    public Player_Inputs inputs;

    [Header("Player Animation Settings")]
    [Tooltip("Make true when all aniation slots are filled")]
    public bool activateAnimations;
    public SpriteRenderer render;
    [Tooltip("Leave alone until you have all direction aniations...Must have 8 animations one fore each direction")]
    public Sprite[] directionAnimations;

    // public Player_Progression playerProgression; // if we decide to do




    [Header("Debug")]
    public Vector2 debugDir;
    public bool alive;
    public int currency;
    // Start is called before the first frame update
    void Start()
    {
        render = gameObject.GetComponentInChildren<SpriteRenderer>();
        currency = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (inputs.canMove)
        {
            if (activateAnimations)
            {
                findSpriteDirection(); //when we have the art sprites to do so
            }
        }

    }

    public void findSpriteDirection()
    {
        debugDir = inputs.dir;
        if (inputs.dir.x > 0 && inputs.dir.y > 0) // right and up
        {
            render.sprite = directionAnimations[0];
        }
        else if (inputs.dir.x < 0 && inputs.dir.y > 0) // left and up
        {
            render.sprite = directionAnimations[1];

        }
        else if (inputs.dir.x > 0 && inputs.dir.y < 0) // right and down
        {
            render.sprite = directionAnimations[2];

        }
        else if (inputs.dir.x < 0 && inputs.dir.y < 0) // left and down
        {
            render.sprite = directionAnimations[3];

        }
        else if (inputs.dir.x < 0 && inputs.dir.y == 0) // left
        {
            render.sprite = directionAnimations[4];

        }
        else if (inputs.dir.x > 0 && inputs.dir.y == 0) // right
        {
            render.sprite = directionAnimations[5];

        }
        else if (inputs.dir.x == 0 && inputs.dir.y < 0) //down
        {
            render.sprite = directionAnimations[6];

        }
        else if (inputs.dir.x == 0 && inputs.dir.y > 0)  //up
        {
            render.sprite = directionAnimations[7];

        }
        else
        {

        }

    }

    // Uses if we have currency system;
    public void gainCurrency()
    {
        currency += 1;
    }
}
