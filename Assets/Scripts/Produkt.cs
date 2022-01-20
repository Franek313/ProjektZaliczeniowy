using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;

public class Produkt : MonoBehaviour
{
    string nazwa;
    float cena, waga;
    bool ograniczenie_wiekowe;
    Sprite sprite;
    public Produkt(string nazwa, float cena, float waga, bool ograniczenie_wiekowe, Sprite sprite)
    {
        this.Nazwa = nazwa;
        this.Cena = cena;
        this.Waga = waga;
        this.Ograniczenie_wiekowe = ograniczenie_wiekowe;
        this.Sprite = sprite;
    }

    public string Nazwa { get => nazwa; set => nazwa = value; }
    public float Cena { get => cena; set => cena = value; }
    public float Waga { get => waga; set => waga = value; }
    public bool Ograniczenie_wiekowe { get => ograniczenie_wiekowe; set => ograniczenie_wiekowe = value; }
    public Sprite Sprite { get => sprite; set => sprite = value; }

    public void DoKoszyka()
    {
        if (transform.parent.name != "Koszyk")
        {
            Instantiate(gameObject, GameObject.Find("Koszyk").transform);
            string s = transform.GetChild(2).GetComponent<Text>().text.ToString().Replace(".", ",");

            GameObject.Find("Canvas").GetComponent<SklepInternetowy>().sumakoszyka += float.Parse(s);
            GameObject.Find("SumaKoszyka").GetComponent<Text>().text = "Suma: " + GameObject.Find("Canvas").GetComponent<SklepInternetowy>().sumakoszyka.ToString();

        }
        

        

        
    }


}
