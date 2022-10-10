using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyables : Fighter
{
    protected override void Death()
    {
        Destroy(gameObject);
    }
}
