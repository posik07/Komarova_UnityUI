using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;

    public void izkrit(int sk)
    {
        if (sk == 0)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0]; ;
        }
        if (sk == 1)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1]; ;
        }
        if (sk == 2)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[2]; ;
        }
    }
}
