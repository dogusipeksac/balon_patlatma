using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour {
    public float zamanSayici =60f;
    int patlayanBalon = 0;
    public UnityEngine.UI.Text zamanText, balontext;
    public GameObject patlama;
	// Use this for initialization
	void Start () {
        balontext.text = "Balon:" +patlayanBalon;
	}
	
	// Update is called once per frame
	void Update () {
        if (zamanSayici > 0) { 
        zamanSayici -= Time.deltaTime;
        zamanText.text = "Zaman:" + (int)zamanSayici;
        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("balon");
            for(int i = 0; i < go.Length; i++)
            {
                Instantiate(patlama,go[i].transform.position, go[i].transform.rotation);
                Destroy(go[i]);

            }
        }
    }
    public  void balonEkle()
    {
        patlayanBalon += 1;
        balontext.text = "Balon:" + patlayanBalon;
    }
}
