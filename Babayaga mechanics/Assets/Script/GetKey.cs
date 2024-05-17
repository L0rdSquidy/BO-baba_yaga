using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GetKey : MonoBehaviour
{
    public GameObject keyPicture;
    public GameObject keyText2;
    public TMP_Text keyText;
    public GameObject PickUpText;
    private int keys = 0;
    private bool isPlayerInTrigger = false;

    void Start()
    {
        keyPicture.SetActive(false);
        keyText2.SetActive(false);
        PickUpText.SetActive(false);

        keyText.GetComponent<TMP_Text>();
        keys = 0;
        keyText.text = "" + keys;
    }
    void Update()
    {
        if (isPlayerInTrigger && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E key pressed while in trigger");
            this.gameObject.SetActive(false);
            keyPicture.SetActive(true);
            keyText2.SetActive(true);
            AddKeys(1);
            PickUpText.SetActive(false);
        }
    }

    public void AddKeys(int add)
    {
        keys += add;
        keyText.text = "" + keys;
        Debug.Log(keys);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player entered trigger");
            PickUpText.SetActive(true);
            isPlayerInTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player exited trigger");
            PickUpText.SetActive(false);
            isPlayerInTrigger = false;
        }
    }
}
