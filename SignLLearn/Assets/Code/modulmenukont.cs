using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class modulmenukont : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //yarisma moduna git butonuna basılınca tetiklenmesi ve yarışma modu sahnesine gitmesi için yazılan kod
    public void yarismamodagit()
    {
        SceneManager.LoadScene("yarismamodu");
    }
    //alfabe modulune git butonuna basılınca tetiklenmesi ve alfabe modulu sahnesine gitmesi için yazılan kod
    public void alfabemodulegit()
    {
        SceneManager.LoadScene("level1");
    }
    //rakam modulune git butonuna basılınca tetiklenmesi ve alfabe modulu sahnesine gitmesi için yazılan kod
    public void rakammodulegit()
    {
        SceneManager.LoadScene("rakammodul");
    }
    //kelime modulune git butonuna basılınca tetiklenmesi ve kelime modulu sahnesine gitmesi için yazılan kod
    public void kelimemodulegit()
    {
        SceneManager.LoadScene("kelimemodu");
    }
    //geri git butonuna basılınca tetiklenmesi ve menu sahnesine gitmesi için yazılan kod
    public void gerigit()
    {
        SceneManager.LoadScene("MenuScreen");
    }
}
