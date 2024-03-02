using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class dialogTest : MonoBehaviour
{
    public DialogueRunner DialogueRunner;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            DialogueRunner.StartDialogue("testAI");
        }
    }
}
