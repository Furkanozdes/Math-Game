using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DortIslem : MonoBehaviour
{
    public UnityEngine.UI.Text ilksayi;
    public UnityEngine.UI.Text ikincisayi;
    public UnityEngine.UI.Text islem;
    public UnityEngine.UI.Text cevap;
    public UnityEngine.UI.Text sonuc;
    public UnityEngine.UI.InputField sonucInput;
    int sayi1, sayi2, ıslemısareti, islemsonucu;
    // Start is called before the first frame update
    void Start()
    {
        yenisoru ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void cevapkontrol()
    {
        if (int.Parse(cevap.text) == islemsonucu)
        {
            sonuc.text = "DOĞRU";
        }
        else
        {
            sonuc.text = "YANLIŞ";
        }
    }
    public void yenisoru()
    {
        sonuc.text = " ";
        sonucInput.text = " ";
        sayi1 = Random.Range(1, 100);
        sayi2 = Random.Range(1, 100);
        ıslemısareti = Random.Range(1, 5);
        switch (ıslemısareti)
        {
            case 1:
                islem.text = "+";
                islemsonucu = sayi1 + sayi2;
                break;
            case 2:
                islem.text = "-";
                islemsonucu = sayi1 - sayi2;
                break;
            case 3:
                islem.text = "*";
                islemsonucu = sayi1 * sayi2;
                break;
            case 4:
                islem.text = "/";
                if (sayi1 > sayi2)
                {
                    islemsonucu = sayi1 / sayi2;
                }
                else
                {
                    islemsonucu = 0;
                }
                break;
        }
        ilksayi.text = sayi1 + "";
        ikincisayi.text = sayi2 + "";
    }
}
