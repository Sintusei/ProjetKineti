using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personnes : MonoBehaviour
{

    private int ID;
    private string Nom;
    private string Prenom;
    private string Mail;
    private string Tel;
    private string Cp;
    private string Adresse;
    private string Ville;
    private string Pays;
    private TypPers Type;

    public Personnes(int newID, string newNom, string newPrenom, string newMail, string newTel, string newCp, string newAdresse, string newVille, string newPays, TypPers newType)
    {
        ID = newID;
        Nom = newNom;
        Prenom = newPrenom;
        Mail = newMail;
        Tel = newTel;
        Cp = newCp;
        Adresse = newAdresse;
        Ville = newVille;
        Pays = newPays;
        Type = newType;
    }
    // Les GET s'utilisent comme accesseur classique. Peuvent être aparenté à des SELECT.
    public int GetID()
    {
        return ID;
    }
    public string GetNom()
    {
        return Nom;
    }
    public string GetPrenom()
    {
        return Prenom;
    }
    public string GetMail()
    {
        return Mail;
    }
    public string GetTel()
    {
        return Tel;
    }
    public string GetCp()
    {
        return Cp;
    }
    public string GetAdresse()
    {
        return Adresse;
    }
    public string GetPays()
    {
        return Pays;
    }
    public TypPers GetType()
    {
        return Type;
    }

    // Contrairement au GET, les SET sont a utiliser comme des UPDATE.
    public void SetNom()
    {

    }
}


