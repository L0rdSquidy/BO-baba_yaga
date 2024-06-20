using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Floating : MonoBehaviour
{

    public float underWaterDrag = 3f;

    public float underWaterAnglurDrag = 1f;

    public float airDrag = 0f;

    public float airAnglurDrag = 0.05f;

    public float floatingpower = 15f;

    public float WaterHeight = 0f;

    Rigidbody N_rigidbody;

    bool underwater;

    private RaiseWater water;


    // Start is called before the first frame update
    void Start()
    {
        N_rigidbody = GetComponent<Rigidbody>();

        water = FindObjectOfType<RaiseWater>();
    }

    private Transform GetTransform()
    {
        return transform;
    }

    public void Update()
    {
        if (water.returnraising() == true)
        {
            StartCoroutine(waitforSecond());
        }
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {

        


        float difference = transform.position.y - WaterHeight;

        if(difference < 0)
        {
            N_rigidbody.AddForceAtPosition(Vector3.up * floatingpower * Mathf.Abs(difference), transform.position, ForceMode.Force);
            if(underwater)
            {
                underwater = true;
                switchstate(true);
            }
        }
        else
        {
            underwater = false;
            switchstate(false);
        }
    }

    void switchstate(bool isUnderWater)
    {
        if (isUnderWater)
        {
            N_rigidbody.drag = underWaterDrag;
            N_rigidbody.angularDrag = underWaterAnglurDrag;
        }
        else 
        {
            N_rigidbody.drag = airDrag;
            N_rigidbody.angularDrag = airAnglurDrag;
        }
    }

    IEnumerator waitforSecond() 
    {
        yield return new WaitForSeconds(2f);
        WaterHeight = water.getwaterheigt() - 10;
        
    }
}
