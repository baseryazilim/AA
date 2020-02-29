using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuKontrol : MonoBehaviour {

    void Start()
    {
        //PlayerPrefs.DeleteAll();
    }

    public void OyunuBaslat()
    {
        int kayitliLevel = PlayerPrefs.GetInt("kayit");
        if (kayitliLevel == 0)
        {
            SceneManager.LoadScene(kayitliLevel + 1);
        }
        else
        {
            SceneManager.LoadScene(kayitliLevel);

        }
    }
    public void KayitliOyunuSil()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(1);
    }
        public void OyundanCik()
    {
        Application.Quit();
    }
    
}
