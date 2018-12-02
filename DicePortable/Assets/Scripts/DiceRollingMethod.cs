using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceRollingMethod : MonoBehaviour{

    [SerializeField] InputField inputFieldDices;

    static public int[] RollingMethod(int nbFaces = 0, int nbDices = 1)
    {
        int[] result = new int[nbDices];

        if (nbDices == 1)
        {
            result[0] = Random.Range(1, nbFaces + 1);
        }
        else
        {
            for (int i = 0; i < nbDices; i++)
            {
                result[i] = Random.Range(1, nbFaces + 1);
            }
        }

        return result;
    }
    
    public void OnClickRoll(int nbFaces)
    {
        if (inputFieldDices.text != "")
        {
            int[] result = RollingMethod(nbFaces, int.Parse(inputFieldDices.text));

            for (int i = 0; i < int.Parse(inputFieldDices.text); i++)
            {
                Debug.Log(result[i]);
            }
        }
        else
        {
            int[] result = RollingMethod(nbFaces, 1);
            Debug.Log(result[0]);
        }
    }
}
