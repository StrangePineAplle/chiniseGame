using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public ScoreManager ScoreM;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bolt"))
        {
            ScoreM.scorePlus = 1;
            other.gameObject.tag = "boltChockUp";
        }

        if (other.gameObject.CompareTag("IntrestingObject") && (other.gameObject.GetComponent<ObjectMove>().AlreadyAct == false))
        {
            ScoreM.Event(other.gameObject.GetComponent<ObjectMove>().ScoreValue, other.gameObject.GetComponent<ObjectMove>().HpValue);
        }
    }
}
