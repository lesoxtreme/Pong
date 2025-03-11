using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI uiWinner;
    void Start()
    {
        SaveController.Instance.Reset();
        string lastWinner = SaveController.Instance.GetLastWinner();
        if (lastWinner != "")
        uiWinner.text = "Last Winner: " + lastWinner;
        else
        uiWinner.text = "";
    }
    
}
