using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    [SerializeField] private bool openTrigger = false;
   
    [SerializeField] private bool closeTrigger = false;

    public TMP_Text keyText;
    private PlayerData data;

    private void Start()
    {
        GameObject playerdata = GameObject.Find("PlayerData");
        data = playerdata.GetComponent<PlayerData>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (data.keys > 0)
            {
                if (openTrigger)
                {
                    myDoor.Play("DoorOpen", 0, 0.0f);
                    gameObject.SetActive(false);
                    data.keys--;
                    keyText.text = data.keys.ToString();
                }
                else if (closeTrigger)
                {
                    myDoor.Play("DoorClose", 0, 0.0f);
                    gameObject.SetActive(false);
                }
            }
        }
    }
}
