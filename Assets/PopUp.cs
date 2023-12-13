using UnityEngine;
using UnityEngine.UI;

public class UIButtonInteraction : MonoBehaviour
{
    private GameObject blackUIPanel; // Reference to the black UI panel
    private bool isUIVisible = false; // Flag to track the visibility state

    void Start()
    {
        // Find the black UI panel by name (adjust the name accordingly)
        blackUIPanel = transform.Find("BlackUIPanel").gameObject;

        if (blackUIPanel == null)
        {
            Debug.LogError("BlackUIPanel not found! Make sure it is a child of the button GameObject.");
            return;
        }

        // Make sure the black UI panel is initially disabled
        blackUIPanel.SetActive(false);

        // Assuming you have a Button component attached to the GameObject with this script
        Button button = GetComponent<Button>();
        if (button != null)
        {
            // Attach the method to be called when the button is clicked
            button.onClick.AddListener(ToggleUIVisibility);
        }
        else
        {
            Debug.LogError("Button component not found!");
        }
    }

    // Method to toggle the visibility of the black UI panel
    void ToggleUIVisibility()
    {
        isUIVisible = !isUIVisible; // Toggle the visibility state

        // Activate or deactivate the black UI panel based on the visibility state
        blackUIPanel.SetActive(isUIVisible);
    }
}
