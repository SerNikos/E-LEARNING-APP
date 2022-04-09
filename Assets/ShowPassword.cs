using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowPasswordBoth : MonoBehaviour
{
    [SerializeField] private TMP_InputField userPassword1;
    [SerializeField] private TMP_InputField userPassword2;

    public void ShowUserPassword()
    {
        if (userPassword1.contentType == TMP_InputField.ContentType.Password && userPassword2.contentType == TMP_InputField.ContentType.Password)
        {
            userPassword1.contentType = TMP_InputField.ContentType.Standard;
            userPassword2.contentType = TMP_InputField.ContentType.Standard;
        }
        else
        {
            userPassword1.contentType = TMP_InputField.ContentType.Password;
            userPassword2.contentType = TMP_InputField.ContentType.Password;
        }
        userPassword1.ForceLabelUpdate();
        userPassword2.ForceLabelUpdate();

    }
}
