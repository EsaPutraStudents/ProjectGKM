using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongButton : MonoBehaviour
{
    AudioManager audioManager;
    public GameObject PanelOpen;
    ChoicesManager choiceManager;
       

   
    public void OpenPanelOnly()
    {
        if (PanelOpen != null )
        {
            PanelOpen.SetActive(true);            
        }
    }

    public void OnWrongChoiceButtonClicked()
    {
        // Simulate a wrong choice
        choiceManager.MakeChoice(false);
    }


}
