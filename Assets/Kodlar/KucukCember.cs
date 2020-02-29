using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KucukCember : MonoBehaviour {

    Rigidbody2D fizik;
    public float hiz;
    bool hareketKontrol = false;
    GameObject oyunYoneticisi;

	// Use this for initialization
	void Start ()
    {
        fizik = GetComponent<Rigidbody2D>();
        oyunYoneticisi = GameObject.FindGameObjectWithTag("oyunyoneticisitag");
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (!hareketKontrol)
        {
            fizik.MovePosition(fizik.position + Vector2.up * hiz * Time.deltaTime);
        }
        
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "donencembertag")
        {
            transform.SetParent(col.transform);
            hareketKontrol = true;
            Debug.Log("Yes");
        }
        if (col.tag == "kucukcembertag")
        {
            oyunYoneticisi.GetComponent<OyunYoneticisi>().OyunBitti();
            Debug.Log("Bana Deydi Hocam!");
            
        }
    }
}
