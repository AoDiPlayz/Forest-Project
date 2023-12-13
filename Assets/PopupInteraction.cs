using UnityEngine;
using UnityEngine.UI;

public class FloatingUIButton : MonoBehaviour
{
    public GameObject blackUI;
    private bool isUIVisible = false;

    // Start is called before the first frame update
    void Start()
    {
        // Assuming you have attached this script to the floating UI button
        Button button = GetComponent<Button>();
        if (button != null)
        {
            // Register a method to be called when the button is clicked
            button.onClick.AddListener(ToggleUIVisibility);
        }

        // Initially hide the black UI
        if (blackUI != null)
        {
            blackUI.SetActive(false);
        }
    }

    // Method to toggle the visibility of the black UI
    void ToggleUIVisibility()
    {
        // Toggle the visibility state
        isUIVisible = !isUIVisible;

        // Set the active state of the black UI based on the visibility state
        if (blackUI != null)
        {
            blackUI.SetActive(isUIVisible);
        }
    }
}