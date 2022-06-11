using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class rakamodulkont : MonoBehaviour
{
    // Sorular için oluşturulan nesneler
    public Soru[] sorular;
    private static List<Soru> sorulmamisSorular;
    private Soru simdikiSoru;
    public Text SoruTexti;
    // butonların oluşturulması
    public Button butonA;
    public Button butonB;
    public Button butonC;
    public Button butonD;
    //Soru Görselinin oluşturulması
    public Image soruİmagesi;
    //Soru ve Oyun bitti panellerinin oluşturulması
    public GameObject soruPaneli;
    public GameObject oyunbittiPaneli;
    //Doğru yanlış sayısı textleri ve değerlerinin oluşturulması
    public Text dogruSayisiText;
    public Text yanlisSayisiText;

    private static int dogruSayisi;
    private static int yanlisSayisi;

    void Start()
    {
        //Oyun başalyınca Oyun bitti panelinin gizlenmesi
        oyunbittiPaneli.SetActive(false);
        //Quiz yapısının kurulması
        if (sorulmamisSorular == null)
        {
            sorulmamisSorular = sorular.ToList<Soru>();
        }
        if (sorulmamisSorular.Count <= 0)
        {
            OyunBitti();
        }
        else
        {
            SoruSor();
        }

    }

    void Update()
    {


    }
    //geri git butonuna basılınca tetiklenmesi ve modul bolum sahnesi gitmesi için yazılan kod
    public void gerigit()
    {
        SceneManager.LoadScene("modulbolum");
    }
    //Sıradaki soru geldiğinde soru texti,görseli ve buton textlerinin değişmesi
    void SoruSor()
    {
        soruPaneli.SetActive(true);
        int soruIndexi = Random.Range(0, sorulmamisSorular.Count);
        simdikiSoru = sorulmamisSorular[soruIndexi];
        soruPaneli.SetActive(true);
        SoruTexti.text = simdikiSoru.soru;
        sorulmamisSorular.RemoveAt(soruIndexi);
        soruİmagesi.GetComponent<Image>().sprite = simdikiSoru.Soruımage;
        butonA.GetComponentInChildren<Text>().text = simdikiSoru.A_s;
        butonB.GetComponentInChildren<Text>().text = simdikiSoru.B_s;
        butonC.GetComponentInChildren<Text>().text = simdikiSoru.C_s;
        butonD.GetComponentInChildren<Text>().text = simdikiSoru.D_s;

    }
    //A butonun doğru cevap olup olmadığının kontrolü ve cevabın durumuna göre butonun rengi değişmesi için yazılan kod
    public void SecenekA()
    {
        if (simdikiSoru.cevap == 1)
        {

            butonA.GetComponent<Image>().color = Color.green;
            dogruSayisi++;
        }
        else
        {
            butonA.GetComponent<Image>().color = Color.red;
            yanlisSayisi++;
        }

        StartCoroutine(SonrakiSoru());
    }
    //B butonun doğru cevap olup olmadığının kontrolü ve cevabın durumuna göre butonun rengi değişmesi için yazılan kod
    public void SecenekB()
    {
        if (simdikiSoru.cevap == 2)
        {
            butonB.GetComponent<Image>().color = Color.green;
            dogruSayisi++;
        }
        else
        {
            butonB.GetComponent<Image>().color = Color.red;
            yanlisSayisi++;
        }

        StartCoroutine(SonrakiSoru());
    }
    //C butonun doğru cevap olup olmadığının kontrolü ve cevabın durumuna göre butonun rengi değişmesi için yazılan kod
    public void SecenekC()
    {
        if (simdikiSoru.cevap == 3)
        {
            butonC.GetComponent<Image>().color = Color.green;
            dogruSayisi++;
        }
        else
        {
            butonC.GetComponent<Image>().color = Color.red;
            yanlisSayisi++;
        }
        StartCoroutine(SonrakiSoru());
    }
    //D butonun doğru cevap olup olmadığının kontrolü ve cevabın durumuna göre butonun rengi değişmesi için yazılan kod
    public void SecenekD()
    {
        if (simdikiSoru.cevap == 4)
        {
            butonD.GetComponent<Image>().color = Color.green;
            dogruSayisi++;
        }
        else
        {
            butonD.GetComponent<Image>().color = Color.red;
            yanlisSayisi++;
        }
        StartCoroutine(SonrakiSoru());
    }
    //Sonraki soru fonksiyonu
    IEnumerator SonrakiSoru()
    {

        soruPaneli.SetActive(true);

        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(5);

    }

    //Oyun bitti fonksiyonu sonuc ekranının getirilmesi doğru ve yanlış sayısı yazdırılması
    public void OyunBitti()
    {
        soruPaneli.SetActive(false);
        butonA.gameObject.SetActive(false);
        butonB.gameObject.SetActive(false);
        butonC.gameObject.SetActive(false);
        butonD.gameObject.SetActive(false);
        dogruSayisiText.text = dogruSayisi + "";
        yanlisSayisiText.text = yanlisSayisi + "";
        oyunbittiPaneli.SetActive(true);

    }
}
