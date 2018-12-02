using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomDiceRolling : MonoBehaviour {

    [SerializeField] InputField inputFieldFaces;
    [SerializeField] InputField inputFieldDices;

    public void OnClickCustomDice()
    {
        int[] result =  DiceRollingMethod.RollingMethod(int.Parse(inputFieldFaces.text), int.Parse(inputFieldDices.text));
    }
}
