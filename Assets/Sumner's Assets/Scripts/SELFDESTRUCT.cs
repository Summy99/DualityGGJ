using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SELFDESTRUCT : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(SELF_DESTRUCT());
    }

    IEnumerator SELF_DESTRUCT()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
