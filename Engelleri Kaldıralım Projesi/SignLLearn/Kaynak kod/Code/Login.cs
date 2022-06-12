using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Login : MonoBehaviour
{
    //Giriş Ekranı Alan ve butonların tanımlanması
    public InputField UserNameInput;
    public InputField PasswordInput;
    public Button LoginButton;
    public Button TryButton;
    void Start()
    {
        //Main.Instance.Web.Login();
        LoginButton.onClick.AddListener(() =>
        {
            StartCoroutine(Main.Instance.Web.Login(UserNameInput.text, PasswordInput.text));
        });
    }
    //Giriş yapmak için giriş butonuna yazılan kod
    public void oyunagit()
    {
       
        //Login butona tıklanması sonrasında lokal veri tabanında Username ve Password kontrölü
        LoginButton.onClick.AddListener(() =>
        {
            StartCoroutine(Main.Instance.Web.Login(UserNameInput.text, PasswordInput.text));
        });



    }
    //Anonim olarak oyuna bağlanmak için geçiş butonuna yazılan kod
    public void retryoyunagit()
    {
        //Anonim olarak oyuna bağlanmak
        SceneManager.LoadScene("MenuScreen");


    }
    //Oyunu kapatmak için çıkış butonuna yazılan kod
    public void oyundancik()
    {
        //
        Application.Quit();


    }

}
