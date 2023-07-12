using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speedMove, speedTurn, timeMove, timeTurn;

    public void Awake()
    {
        Time.timeScale = 1.0f;
    }
    public void moveForward()
    {
        StartCoroutine(updateMove(timeMove));
    }

    public void turnRight()
    {
        transform.Rotate(0, 90, 0, Space.World);
    }

    public void turnLeft()
    {
        transform.Rotate(0, -90, 0, Space.World);
    }

    private IEnumerator updateMove(float seconds)
    {
        float i = 0;
        while (i < seconds) {
            transform.Translate(0, 0, -Time.deltaTime * speedMove);
            i += Time.deltaTime;
            yield return null;
        }
    }
}
