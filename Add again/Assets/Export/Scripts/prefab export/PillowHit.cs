using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PillowHit : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEvent Portalenter;
    private GameObject Player;
    public GameObject teleport_exit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.name == "Playertarget"){
            Portalenter.Invoke();
            Player = other.gameObject;
            other.gameObject.SetActive(false);
            StartCoroutine(WaitForTeleport());

        }
    }
    IEnumerator WaitForTeleport() {
        yield return new WaitForSeconds(1f);
        Player.transform.position = teleport_exit.transform.position;
        Player.SetActive(true);
    }
}

