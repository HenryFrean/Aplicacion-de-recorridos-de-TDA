using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsManager : MonoBehaviour
{
    [SerializeField] GameObject[] weapons;

    [SerializeField] Transform playerHand;

    [SerializeField] List<GameObject> weaponsList;

    public List<GameObject> WeaponsList { get => weaponsList; set => weaponsList = value; }
    public Dictionary<string, GameObject> WeaponDirectory { get => weaponDirectory; set => weaponDirectory = value; }

    private Dictionary<string, GameObject> weaponDirectory;

    // Start is called before the first frame update
    void Start()
    {
        //weapons[0].SetActive(true);
        //weapons[0].transform.parent = playerHand;
        //weapons[0].transform.localPosition = Vector3.zero;
        //DiseableAllWeapons();
        
        weaponsList = new List<GameObject>();
        weaponDirectory = new Dictionary<string, GameObject>();
    }

    void DiseableAllWeapons()
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            weapons[i].SetActive(false);
        }
    }

    void EnableAllWeapon()
    {
        foreach(var weapon in weaponsList)
        {
            weapon.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) EnableAllWeapon();
        {

        }
        if (Input.GetKeyDown(KeyCode.Alpha1)) weaponDirectory["WeaponA"].SetActive(true);
        if (Input.GetKeyDown(KeyCode.Alpha2)) weaponDirectory["WeaponB"].SetActive(true);
        if (Input.GetKeyDown(KeyCode.Alpha3)) weaponDirectory["WeaponC"].SetActive(true);
        if (Input.GetKeyDown(KeyCode.Alpha4)) weaponDirectory["WeaponD"].SetActive(true);
    }

}
