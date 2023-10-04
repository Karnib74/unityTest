using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ppWizardFab;

    // Start is called before the first frame update
    void Start()
    {

        Instantiate(ppWizardFab);
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(ppWizardFab);

    }
}
