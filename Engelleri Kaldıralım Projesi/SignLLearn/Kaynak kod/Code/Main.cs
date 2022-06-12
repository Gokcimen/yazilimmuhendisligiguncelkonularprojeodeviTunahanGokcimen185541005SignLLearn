using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Web nesnesinin oluşturulması
    public static Main Instance;
    public web Web;
    void Start()
    {
        Instance = this;
        Web = GetComponent<web>();
    }

   
}
