using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PillowDrop : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] PillowHit droplet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Random.value < 0.0005)
        {
            PillowHit copyDroplet = Instantiate(droplet);
            copyDroplet.transform.position = transform.position;
            Destroy(copyDroplet,1f);
        } 
}
}
