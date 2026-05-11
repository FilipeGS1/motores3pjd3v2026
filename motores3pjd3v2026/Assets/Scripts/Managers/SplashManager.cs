using UnityEngine;
using System.Collections;

public class SplashManager : MonoBehaviour
{
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(2f);

        GameManager.Instance.LoadScene("MenuPrincipal");
    }
}