using UnityEngine;
using System.Collections;

public class WeaponSelect : MonoBehaviour {

	// Use this for initialization
	/* void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("space has been pressed.");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("space has been pressed.");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log("space has been pressed.");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Debug.Log("space has been pressed.");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Debug.Log("space has been pressed.");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            Debug.Log("space has been pressed.");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            Debug.Log("space has been pressed.");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            Debug.Log("space has been pressed.");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            Debug.Log("space has been pressed.");
        }
    }*/

    public GameObject[] weapons; // push your prefabs

    public int currentWeapon = 0;

    private int nrWeapons;

    void Start()
    {

        nrWeapons = weapons.Length;

        SwitchWeapon(currentWeapon); // Set default gun

    }

    void Update()
    {
        for (int i = 1; i <= nrWeapons; i++)
        {
            if (Input.GetKeyDown("" + i))
            {
                currentWeapon = i - 1;

                SwitchWeapon(currentWeapon);

            }
        }

    }

    void SwitchWeapon(int index)
    {

        for (int i = 0; i < nrWeapons; i++)
        {
            if (i == index)
            {
                weapons[i].gameObject.SetActive(true);
            }
            else
            {
                weapons[i].gameObject.SetActive(false);
            }
        }
    }


}
