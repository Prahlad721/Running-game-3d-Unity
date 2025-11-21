using UnityEngine;

public class coincollect : MonoBehaviour
{
    [SerializeField] AudioSource coinFx;

    void OnTriggerEnter(Collider other)
    {
        coinFx.Play();
        MasterInfo.coinCount +=1;
        this.gameObject.SetActive(false);
    }

}
