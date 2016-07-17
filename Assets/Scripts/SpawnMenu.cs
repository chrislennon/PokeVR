using UnityEngine;
using System.Collections;

public class SpawnMenu : MonoBehaviour {

    SteamVR_TrackedObject trackedObj;
    public GameObject menuprefab;
    private GameObject spawned;
    //private Camera UICam;

    // Use this for initialization
    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
        

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        SteamVR_Controller.Device device = SteamVR_Controller.Input((int)trackedObj.index);
        if (device.GetPressDown(SteamVR_Controller.ButtonMask.ApplicationMenu))
        {
            //UICam = GameObject.Find("Controller UI Camera").GetComponent<Camera>();
            spawned = GameObject.FindWithTag("Menu");
            if (spawned)
            {
                Destroy(spawned);
            }
            SpawnMenu clone = (SpawnMenu)Instantiate(menuprefab, transform.position, transform.rotation);
            
            //Debug.Log(UICam);
            //clone.GetComponent<Canvas>().worldCamera = UICam;
            //clone.tag = "Menu";
        }

    }
}
