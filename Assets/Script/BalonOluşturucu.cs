using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonOluşturucu : MonoBehaviour {
    public GameObject balon;
    float balonOlusturmaSuresi = 1f;
    float zamanSayaci = 0f;
    OyunKontrol oyunKont;

	// Use this for initialization
	void Start () {
        oyunKont = GameObject.Find(".Script").GetComponent<OyunKontrol>();

    }

    // Update is called once per frame
    void Update () {
        zamanSayaci -= Time.deltaTime;
        int katsayi = (int)(oyunKont.zamanSayici / 10) -6;
        katsayi *= -1;
        if (zamanSayaci < 0 && oyunKont.zamanSayici>0)
        {
           GameObject go= Instantiate(balon, new Vector3(Random.Range(-2.5f,2.5f), -6f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0,Random.Range(60f*katsayi,150f*katsayi), 0));
            zamanSayaci = balonOlusturmaSuresi;
        }
        else
        {

        }
	}
}
