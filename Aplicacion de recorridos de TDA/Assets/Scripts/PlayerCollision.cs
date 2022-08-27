using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] WeaponsManager weaponsManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Weapons"))
        {
            other.gameObject.SetActive(false);
            weaponsManager.WeaponsList.Add(other.gameObject);

            weaponsManager.WeaponDirectory.Add(other.gameObject.name, other.gameObject);
            Debug.Log(weaponsManager.WeaponDirectory[other.gameObject.name]);
        }
    }
}
