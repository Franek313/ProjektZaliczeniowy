using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Konto : MonoBehaviour
{
    string nazwa_uzytkownika, haslo;
    List<KuponRabatowy> lista_kuponow_rabatowych;
    DateTime data_zalozenia;
    float fundusze;

    public List<KuponRabatowy> Lista_kuponow_rabatowych { get => lista_kuponow_rabatowych; set => lista_kuponow_rabatowych = value; }
    public DateTime Data_zalozenia { get => data_zalozenia; set => data_zalozenia = value; }
    public string Nazwa_uzytkownika { get => nazwa_uzytkownika; set => nazwa_uzytkownika = value; }
    public string Haslo { get => haslo; set => haslo = value; }
    public float Fundusze { get => fundusze; set => fundusze = value; }
}
