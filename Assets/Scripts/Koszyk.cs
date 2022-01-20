using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Koszyk : MonoBehaviour
{
    List<Produkt> produkty_w_koszyku;

    public bool CzyPusty()
    {
        if (produkty_w_koszyku.Count == 0) return true;
        else return false;
    }

    public bool CzyPusty_Testowanie_Ujemnej_Zawartosci_Koszyka()
    {
        if (produkty_w_koszyku.Count <= 0) return true;
        else return false;
    }

    public void OproznijKoszyk()
    {
        foreach(Transform child in gameObject.transform)
        {
            Destroy(child.gameObject);
        }
        GameObject.Find("Canvas").GetComponent<SklepInternetowy>().sumakoszyka = 0;
        GameObject.Find("SumaKoszyka").GetComponent<Text>().text = "Suma: ";
    }

    public void OproznijKoszyk_Testowanie_Oprozniania_Pustego_Koszyka()
    {
        print(CzyPusty());
        foreach (Transform child in gameObject.transform)
        {
            Destroy(child.gameObject);
        }
        GameObject.Find("Canvas").GetComponent<SklepInternetowy>().sumakoszyka = 0;
        GameObject.Find("SumaKoszyka").GetComponent<Text>().text = "Suma: ";
        print(CzyPusty());
    }

    public void DodajDoKoszyka(Produkt p)
    {
        produkty_w_koszyku.Add(p);
    }
}
