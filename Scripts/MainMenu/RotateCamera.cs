using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public GameObject board;

    void Update()
    {
        // Spin the object around the target at 20 degrees/second.
        transform.RotateAround(board.transform.position, Vector3.up, 20 * Time.deltaTime);
    }
}
