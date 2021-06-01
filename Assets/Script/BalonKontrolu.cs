using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonKontrolu : MonoBehaviour {
    public GameObject patlama;
    OyunKontrol oyunKontrol;

     void Start()
    {
        oyunKontrol = GameObject.Find(".Script").GetComponent<OyunKontrol>();
    }

    void OnMouseDown()
    {
        GameObject go = Instantiate(patlama, transform.position, transform.rotation);      
        Destroy(this.gameObject);
        Destroy(go, 0.267f);
        oyunKontrol.balonEkle();
    }
}
