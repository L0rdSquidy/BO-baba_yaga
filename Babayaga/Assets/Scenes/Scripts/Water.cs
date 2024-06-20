using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseWater : MonoBehaviour
{
    public GameObject water;
    public float targetHeight = 5f;
    public float raiseSpeed = 8f;
    private bool isRaising = false;

    void Update()
    {
        if (isRaising && water.transform.position.y < targetHeight)
        {
            water.transform.position += Vector3.up * raiseSpeed * Time.deltaTime;
        }
    }

    public void Activate()
    {
        isRaising = true;
    }

    public bool returnraising() 
    {
        return isRaising;
    }

    public float getwaterheigt()
    {
        return targetHeight;
    }
}
