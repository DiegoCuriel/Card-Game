using UnityEngine;
using UnityEngine.UI;

public class GuiManager : MonoBehaviour
{
    public TMPro.TextMeshProUGUI descText;
    public TMPro.TextMeshProUGUI actualesText;

    private string actuales;


    void Start()
    {
        

    }

    void Update()
    {

        

    }

    public void AddActuales(string actuales)
    {
        actualesText.text = actuales;
    }
}
