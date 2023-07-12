using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreMinus : MonoBehaviour
{
    public ScoreManager ScoreM;

    private void OnTriggerEnter(Collider other)
    {
        if ( (other.gameObject.CompareTag("bolt")) || (other.gameObject.CompareTag("boltDown")) )
        {
            ScoreM.scoreMinuss = 1;
            other.gameObject.tag = "boltDown";
        }

    }
}
