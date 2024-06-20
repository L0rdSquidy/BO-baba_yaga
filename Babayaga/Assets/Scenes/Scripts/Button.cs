using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonInteraction : MonoBehaviour
{
    public RaiseWater raiseWaterScript; // Referentie naar het RaiseWater script

    public void OnButtonPress()
    {
        raiseWaterScript.Activate(); // Roept de Activate-methode aan om het water te laten stijgen
    }
}