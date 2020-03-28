using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //need to use this to access Text type

public class AdventureGame : MonoBehaviour
{

    [SerializeField] Text textComponent; //this means this is available in our Inspector
    [SerializeField] State startingState;

    

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory(); //access the text property found in the text component
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();
        for (int index = 0; index < nextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = nextStates[index];
            }
        }

        textComponent.text = state.GetStateStory();
    }
}
