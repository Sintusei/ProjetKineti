using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypPers : MonoBehaviour {

    private int ID;
    private string lib;

    public TypPers(int newID, string newLib)
    {
        ID = newID;
        lib = newLib;
    }

    public int GetID()
    {
        return ID;
    }
    public string Getlib()
    {
        return lib;
    }

}
