using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PasswordSystem : MonoBehaviour
{
    public TMP_InputField passwordInputField; // Reference to the InputField component
    public Button submitButton;           // Reference to the Button component
    public TextMeshProUGUI resultText;               // Reference to the Text component for displaying the result
    public string correctPassword = "9718"; // The correct password

    void Start()
    {
        // Add click listener to the submit button
        submitButton.onClick.AddListener(CheckPassword);
    }

    void CheckPassword()
    {
        // Get the input password from the InputField
        string inputPassword = passwordInputField.text;

        // Check if the input password is correct
        if (inputPassword == correctPassword)
        {
            resultText.text = "Password correct! Access granted. And Thank You for playing my game";
            // Call the function to enable the desired functionality
            EnableFunctionality();
        }
        else
        {
            resultText.text = "Password incorrect! Access denied.";
        }
    }

    void EnableFunctionality()
    {
        // Add the code to enable the functionality here
        Debug.Log("Functionality enabled!");
        // For example, enabling a GameObject
        // someGameObject.SetActive(true);
    }
}
