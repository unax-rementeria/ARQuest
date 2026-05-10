using UnityEngine;
using UnityEngine.UI;

public class puntos : MonoBehaviour
{
    public Dropdown m_Dropdown;
    score score;

    public static bool Max5;
    public static bool Max10;
    public static bool Max20;
    public static bool Max40;
    public static bool Max60;

    void Start()
    {
        //Add listener for when the value of the Dropdown changes, to take action
        m_Dropdown.onValueChanged.AddListener(delegate {
            DropdownValueChanged(m_Dropdown);
        });

        //Initialise the Text to say the first value of the Dropdown
        Debug.Log("First Value : " + m_Dropdown.value);
        Max5 = false;
        Max10 = false;
        Max20 = false;
        Max40 = false;
        Max60 = false;
    }

    //Ouput the new value of the Dropdown into Text
    void DropdownValueChanged(Dropdown change)
    {
        Debug.Log("New Value : " + m_Dropdown.value);
        if (m_Dropdown.value == 0)
        {
            Max5 = true;
        }
        else if (m_Dropdown.value == 1)
        {
            Max10 = true;

        }
        else if (m_Dropdown.value == 2)
        {
            Max20 = true;
        }
        else if (m_Dropdown.value == 3)
        {
            Max40 = true;
        }
        else if (m_Dropdown.value == 4)
        {
            Max60 = true;
        }
    }
}
