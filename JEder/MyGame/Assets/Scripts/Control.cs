using UnityEngine;
using UnityEngine.UI;

public class Control : MonoBehaviour
{
    public InputField input1;
    public InputField input2;
    public Text result;

    float varA;
    float varB;

    public void SetResult()
    {
        result.text = CalculateNumbers();
    }

    string CalculateNumbers()
    {
        if (string.IsNullOrEmpty(input1.text) || string.IsNullOrEmpty(input2.text))
        {
            string outputError = "ERROR";
            return outputError;
        }
        else
        {
            varA = float.Parse(input1.text);
            varB = float.Parse(input2.text);

            string outputSuccess = (varA + varB).ToString();
            return outputSuccess;
        }
    }

    public void ResetApp()
    {
        input1.text = "";
        input2.text = "";
        result.text = "";
    }
}
