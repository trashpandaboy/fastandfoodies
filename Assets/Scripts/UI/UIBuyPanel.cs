using UnityEngine;

public class UIBuyPanel : MonoBehaviour
{
    Animator panelAnimator;
    bool isOpen = false;

    private void Awake()
    {
        panelAnimator = GetComponent<Animator>();
    }

    public void TogglePanel()
    {
        isOpen = !isOpen;

        if(isOpen)
        {
            panelAnimator.Play("Show");
        }
        else
        {
            panelAnimator.Play("Hide");
        }
    }

}
