using Assets.SimpleLocalization;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiLanguage : MonoBehaviour
{

    private void Awake()
    {
        LocalizationManager.Read();

        switch (Application.systemLanguage)
        {
            case SystemLanguage.English:
                LocalizationManager.Language = "English";
                break;
            case SystemLanguage.Russian:
                LocalizationManager.Language = "Russian";
                break;
            case SystemLanguage.German:
                LocalizationManager.Language = "Uzbek";
                break;
            default:
                LocalizationManager.Language = "English";
                break;
        }
    }

    public void Language (string language)
    {
        LocalizationManager.Language = language;
    }
}
