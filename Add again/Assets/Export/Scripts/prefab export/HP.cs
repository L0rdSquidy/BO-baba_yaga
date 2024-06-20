using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HP : MonoBehaviour
{
    private TMP_Text scoreField;
    private int hp = 3;
    
    private int Hitcounter;

    public GameObject player;

    public Vector3 teleport_exit;

    public GameObject UI;
    // Start is called before the first frame update
    void Start()
    {
        scoreField = GetComponent<TMP_Text>();
        scoreField.text = "" + hp;
    }

    public int getHp(){
        return hp;
    }

    public int returnHitcounter()
    {
        return Hitcounter;
    }
    public void AddScore(int add) {
        
        hp += add;
        scoreField.text = "" + hp;
        Hitcounter -= add;
        UI.SetActive(true);
        StartCoroutine(HitCounterWait());
    }

    IEnumerator HitCounterWait()
    {
        yield return new WaitForSeconds(1f);
        player.SetActive(true);
        Hitcounter = 0;
        UI.SetActive(false);
        player.transform.position = teleport_exit;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
