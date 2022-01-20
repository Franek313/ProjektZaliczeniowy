using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;
using System.Linq;

public class Osoba
{
    string imie, nazwisko;
    DateTime data_urodzenia;

    public string Imie { get => imie; set => imie = value; }
    public string Nazwisko { get => nazwisko; set => nazwisko = value; }
    public DateTime Data_urodzenia { get => data_urodzenia; set => data_urodzenia = value; }
}

public class Klient : Osoba
{
    float fundusze;

    public float Fundusze { get => fundusze; set => fundusze = value; }
}


public class KuponRabatowy
{
    float procent_rabatu;
    DateTime data_wygasniecia;

    public float Procent_rabatu { get => procent_rabatu; set => procent_rabatu = value; }
    public DateTime Data_wygasniecia { get => data_wygasniecia; set => data_wygasniecia = value; }
}

public abstract class EkranRejestracji
{

}

public abstract class EkranLogowania
{

}

public class SklepInternetowy : MonoBehaviour
{
    public List<Sprite> list_of_sprites;
    public GameObject produkt;
    Koszyk koszyk;
    public float sumakoszyka = 0f;
    public List<Konto> lista_kont;
    Konto Zalogowane_konto = null;
    

    private void Start()
    {
        var ListaProdoktow = GameObject.Find("ListaProduktow");

        /* for (int i = 0; i < 3; i++)
         {
             Instantiate(produkt, ListaProdoktow.transform);
         }


         ListaProdoktow.transform.GetChild(0).transform.GetChild(0).GetComponent<Image>().sprite = list_of_sprites[0];
         ListaProdoktow.transform.GetChild(0).transform.GetChild(1).GetComponent<Text>().text = "mleko";

         ListaProdoktow.transform.GetChild(1).transform.GetChild(0).GetComponent<Image>().sprite = list_of_sprites[1];
         ListaProdoktow.transform.GetChild(2).transform.GetChild(0).GetComponent<Image>().sprite = list_of_sprites[2];

         /* produkt.transform.GetChild(1).GetComponent<Text>().text = mleko.Nazwa;
          produkt.transform.GetChild(2).GetComponent<Text>().text = mleko.Cena.ToString(CultureInfo.InvariantCulture);*/

        //var ListaProdoktow = GameObject.Find("ListaProduktow");
        List<String> lista_sortowania = new List<String>();
        foreach (Transform child in ListaProdoktow.transform)
        {
            lista_sortowania.Add(child.name);
        }
        

        

    }

    public void SortujArtykuly()
    {
        
    }

    public void Zarejestruj()
    {

        var nowaNazwaUzytkownika = GameObject.Find("EkranRejestracji").transform.GetChild(1).GetComponentInChildren<Text>().text.ToString();
        var noweHasloUzytkownika = GameObject.Find("EkranRejestracji").transform.GetChild(2).GetComponentInChildren<Text>().text.ToString();
        bool zajetanazwa = false;

        for (int i = 0; i < lista_kont.Count; i++)
        {
            if (nowaNazwaUzytkownika == lista_kont[i].Nazwa_uzytkownika)
            {
                zajetanazwa = true;
            }
        }

        if (zajetanazwa == false)
        {
            if (nowaNazwaUzytkownika.Contains(" ") || nowaNazwaUzytkownika.Contains("\n") || nowaNazwaUzytkownika.Contains("\t") || nowaNazwaUzytkownika.Length == 0)
            {
                GameObject.Find("EkranRejestracji").transform.GetChild(4).GetComponentInChildren<Text>().text = "Nazwa u¿ytkownika nie mo¿e byæ pusta, zawieraæ spacji, znaków nowej linii ani tabulatorów";

            }
            else if (noweHasloUzytkownika.Contains(" ") || noweHasloUzytkownika.Contains("\n") || noweHasloUzytkownika.Contains("\t") || noweHasloUzytkownika.Length == 0)
            {
                GameObject.Find("EkranRejestracji").transform.GetChild(4).GetComponentInChildren<Text>().text = "Has³o u¿ytkownika nie mo¿e byæ puste, zawieraæ spacji, znaków nowej linii ani tabulatorów";

            }
            else
            {
                Konto k = new Konto();
                k.Nazwa_uzytkownika = nowaNazwaUzytkownika;
                k.Haslo = noweHasloUzytkownika;
                k.Data_zalozenia = System.DateTime.Now;
                k.Fundusze = 50f;
                lista_kont.Add(k);
            }

            for (int i = 0; i < lista_kont.Count; i++)
            {
                print(lista_kont[i].Nazwa_uzytkownika);
            }

            GameObject.Find("EkranRejestracji").transform.GetChild(4).GetComponentInChildren<Text>().text = "Konto utworzone poprawnie!";


        }
        else GameObject.Find("EkranRejestracji").transform.GetChild(4).GetComponentInChildren<Text>().text = "Nazwa zajeta!";
    }

    public void Zarejestruj_Testowanie_Hasel_I_Nazw_Uzytkownika_Nie_Spelniajacych_Wymogow()
    {

        var nowaNazwaUzytkownika = "\n";
        var noweHasloUzytkownika = "      ";
        bool zajetanazwa = false;

        for (int i = 0; i < lista_kont.Count; i++)
        {
            if (nowaNazwaUzytkownika == lista_kont[i].Nazwa_uzytkownika)
            {
                zajetanazwa = true;
            }
        }

        if (zajetanazwa == false)
        {
            if (nowaNazwaUzytkownika.Contains(" ") || nowaNazwaUzytkownika.Contains("\n") || nowaNazwaUzytkownika.Contains("\t") || nowaNazwaUzytkownika.Length == 0)
            {
                GameObject.Find("EkranRejestracji").transform.GetChild(4).GetComponentInChildren<Text>().text = "Nazwa u¿ytkownika nie mo¿e byæ pusta, zawieraæ spacji, znaków nowej linii ani tabulatorów";

            }
            else if (noweHasloUzytkownika.Contains(" ") || noweHasloUzytkownika.Contains("\n") || noweHasloUzytkownika.Contains("\t") || noweHasloUzytkownika.Length == 0)
            {
                GameObject.Find("EkranRejestracji").transform.GetChild(4).GetComponentInChildren<Text>().text = "Has³o u¿ytkownika nie mo¿e byæ puste, zawieraæ spacji, znaków nowej linii ani tabulatorów";

            }
            else
            {
                Konto k = new Konto();
                k.Nazwa_uzytkownika = nowaNazwaUzytkownika;
                k.Haslo = noweHasloUzytkownika;
                k.Data_zalozenia = System.DateTime.Now;
                k.Fundusze = 50f;
                lista_kont.Add(k);
            }

            for (int i = 0; i < lista_kont.Count; i++)
            {
                print(lista_kont[i].Nazwa_uzytkownika);
            }

            GameObject.Find("EkranRejestracji").transform.GetChild(4).GetComponentInChildren<Text>().text = "Konto utworzone poprawnie!";


        }
        else GameObject.Find("EkranRejestracji").transform.GetChild(4).GetComponentInChildren<Text>().text = "Nazwa zajeta!";
    }

    public void Zaloguj()
    {

        var NazwaUzytkownika = GameObject.Find("EkranLogowania").transform.GetChild(1).GetComponentInChildren<Text>().text.ToString();
        var HasloUzytkownika = GameObject.Find("EkranLogowania").transform.GetChild(2).GetComponentInChildren<Text>().text.ToString();
        bool konto_istnieje = false;
        Konto wybrane_konto = null;

        for (int i = 0; i < lista_kont.Count; i++)
        {
            if (lista_kont[i].Nazwa_uzytkownika == NazwaUzytkownika)
            {
                konto_istnieje = true;
                wybrane_konto = lista_kont[i];
            }
        }

        if (konto_istnieje == true)
        {
            if (wybrane_konto.Haslo != HasloUzytkownika)
            {
                GameObject.Find("EkranLogowania").transform.GetChild(4).GetComponentInChildren<Text>().text = "B³êdne has³o!";
            }
            else
            {
                Zalogowane_konto = wybrane_konto;
                GameObject.Find("NazwaUzytkownika").GetComponent<Text>().text = wybrane_konto.Nazwa_uzytkownika;
                GameObject.Find("PieniadzeUzytkownika").GetComponent<Text>().text = wybrane_konto.Fundusze.ToString();
                GameObject.Find("KonsolaGlowna").GetComponent<Text>().text = "Zalogowano jako " + wybrane_konto.Nazwa_uzytkownika;
                GameObject.Find("EkranLogowania").SetActive(false);
            }
        }
        else GameObject.Find("EkranLogowania").transform.GetChild(4).GetComponentInChildren<Text>().text = "Nie ma takiego konta, zarejestruj siê w ekranie rejestracji!";

    }

    
    public void Zaloguj_Testowanie_Nieodpowiednich_Hasel()
    {

        var NazwaUzytkownika = GameObject.Find("EkranLogowania").transform.GetChild(1).GetComponentInChildren<Text>().text.ToString();
        var HasloUzytkownika = " ";
        bool konto_istnieje = false;
        Konto wybrane_konto = null;

        for (int i = 0; i < lista_kont.Count; i++)
        {
            if (lista_kont[i].Nazwa_uzytkownika == NazwaUzytkownika)
            {
                konto_istnieje = true;
                wybrane_konto = lista_kont[i];
            }
        }

        if (konto_istnieje == true)
        {
            if (wybrane_konto.Haslo != HasloUzytkownika)
            {
                GameObject.Find("EkranLogowania").transform.GetChild(4).GetComponentInChildren<Text>().text = "B³êdne has³o!";
            }
            else
            {
                Zalogowane_konto = wybrane_konto;
                GameObject.Find("NazwaUzytkownika").GetComponent<Text>().text = wybrane_konto.Nazwa_uzytkownika;
                GameObject.Find("PieniadzeUzytkownika").GetComponent<Text>().text = wybrane_konto.Fundusze.ToString();
                GameObject.Find("KonsolaGlowna").GetComponent<Text>().text = "Zalogowano jako " + wybrane_konto.Nazwa_uzytkownika;
                GameObject.Find("EkranLogowania").SetActive(false);
            }
        }
        else GameObject.Find("EkranLogowania").transform.GetChild(4).GetComponentInChildren<Text>().text = "Nie ma takiego konta, zarejestruj siê w ekranie rejestracji!";

    }

    public void ZakonczIZaplac()
    {
        if (Zalogowane_konto.Fundusze - sumakoszyka >= 0)
        {
            if (Zalogowane_konto.Nazwa_uzytkownika == "")
            {
                GameObject.Find("KonsolaGlowna").GetComponent<Text>().text = "Zaloguj sie aby kupowaæ!";
            }
            else
            {

                Zalogowane_konto.Fundusze -= sumakoszyka;
                GameObject.Find("Koszyk").GetComponent<Koszyk>().OproznijKoszyk();
                GameObject.Find("PieniadzeUzytkownika").GetComponent<Text>().text = Zalogowane_konto.Fundusze.ToString();
            }
        }
        else
        {
            GameObject.Find("KonsolaGlowna").GetComponent<Text>().text = "Zabrak³o pieniêdzy!";
        }
            
        
    }
}
