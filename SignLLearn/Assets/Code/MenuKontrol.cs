using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuKontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //Start butonuna basılınca tetiklenmesi ve yarışma modu sahnesine gitmesi için yazılan kod
    public void oyunagit()
    {
        SceneManager.LoadScene("yarismamodu");
    }
    //Exit butonuna basılınca tetiklenmesi ve oyunu kapatması için yazılan kod
    public void oyundancık()
    {
        Application.Quit();
    }
    //Bölümler butonuna basılınca tetiklenmesi ve modülbolum sahnesine gitmesi için yazılan kod
    public void Modulleregit()
    {
        SceneManager.LoadScene("modulbolum");
    }
    void Update()
    {
        
    }
}
