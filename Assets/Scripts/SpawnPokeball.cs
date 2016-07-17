using UnityEngine;
using System.Collections;

public class SpawnPokeball : MonoBehaviour {

    SteamVR_TrackedObject trackedObj;
    public GameObject pokeballprefab;

    [Tooltip("The axis on the touchpad to use, Vector2(0, 0) means anywhere on the touchpad.")]
    public Vector2 TouchpadAxis = Vector2.zero;

    // Use this for initialization
    void Awake () {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
	}
	
	// Update is called once per frame
	void Update () {

        SteamVR_Controller.Device device = SteamVR_Controller.Input((int)trackedObj.index);
        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Touchpad) &&
                    (TouchpadAxis.sqrMagnitude == 0f || Vector2.Dot(TouchpadAxis, device.GetAxis().normalized) >= 0.5f))
        {
            SpawnPokeball clone = (SpawnPokeball)Instantiate(pokeballprefab, transform.position, transform.rotation);
        }

	}
}
