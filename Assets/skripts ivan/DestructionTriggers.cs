using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionTriggers : MonoBehaviour
{

    public ScoreManager ScoreM;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bolt"))
        {
            ScoreM.MinusScoreFunc();
        }

    }

}
