using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hafta2Odev : MonoBehaviour
{
    private string sayi,say2,say3,say4,say5="";


    private void BolenleriBul(int ilkSayi, int ikinciSayi)
    {
        int bSayi,kSayi;

        if (ilkSayi > ikinciSayi)
        {
            bSayi = ilkSayi;
            kSayi = ikinciSayi;

            Hesapla(kSayi, bSayi);
        }
        else
        {
            kSayi = ilkSayi;
            bSayi = ikinciSayi;

            Hesapla(kSayi, bSayi);
        }
        print("T�m Liste: " + sayi);
        print("�kiye B�l�nenler: " + say2);
        print("��e B�l�nenler: " + say3);
        print("D�rte B�l�nenler: " + say4);
        print("Be�e B�l�nenler: " + say5);


    }

    private void Hesapla(int Sayi1, int Sayi2) 
    {
        for (int i = Sayi1; i <= Sayi2; i++)
        {
            sayi += "-" + i;
            if (i % 2 == 0)
            {
                say2 += "-" + i;
            }
            if (i % 3 == 0)
            {
                say3 += "-" + i;
            }
            if (i % 4 == 0)
            {
                say4 += "-" + i;
            }
            if (i % 5 == 0)
            {
                say5 += "-" + i;
            }
        }
    }
    void Start()
    {
        BolenleriBul(7,32);
    }
   
}
