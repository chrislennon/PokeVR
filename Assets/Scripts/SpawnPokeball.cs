using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SteamVR_TrackedObject))]

public class SpawnPokeball : MonoBehaviour {

    SteamVR_TrackedObject trackedObj;
    public GameObject pokeballprefab;

    // Use this for initialization
    void Awake () {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
	}
	
	// Update is called once per frame
	void Update () {

        SteamVR_Controller.Device device = SteamVR_Controller.Input((int)trackedObj.index);
        if (device.GetPressDown(SteamVR_Controller.ButtonMask.ApplicationMenu))
        {
            SpawnPokeball clone = (SpawnPokeball)Instantiate(pokeballprefab, transform.position, transform.rotation);
        }

	}
}
