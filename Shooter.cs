using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    public GameObject projectile, projectileParent;

    private void Fire ()
    {
        GameObject newProjetile = Instantiate (projectile);
        newProjetile.transform.parent = projectileParent.transform;
    }
	
}
