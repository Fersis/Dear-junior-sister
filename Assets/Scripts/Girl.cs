using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Girl : MonoBehaviour
{
    // Auto-implemented property
    public Animator Anim { get; set; }

    // Encapsulation
    private float _damageTaken;
    public float DamageTaken
    {
        get
        {
            return _damageTaken;
        }
        set
        {
            if (value < 0)
            {
                Debug.LogError(
                    "Damage taken shouldn't be negative.");
            }
            else
            {
                _damageTaken = value;
            }
        }
    }

    [SerializeField]
    Text DamageTakenText;

    void Awake()
    {
        Anim = GetComponent<Animator>();
    }

    public virtual void Run()
    {
        ResetAnimation();
        Anim.SetBool("isRun", true);
    }

    // Abstraction
    void ResetAnimation()
    {
        Anim.SetBool("isLookUp", false);
        Anim.SetBool("isRun", false);
        Anim.SetBool("isJump", false);
    }

    public void Hurt()
    {
        DoHurtAction();
        ShowHurtText();
    }

    public virtual void DoHurtAction()
    {
        ResetAnimation();
        Anim.SetTrigger("hurt");
    }

    void ShowHurtText()
    {
        StartCoroutine(ShowTakenDamage(DamageTaken, 0.3f));
    }

    IEnumerator ShowTakenDamage(float damageTaken, float delay)
    {
        DamageTakenText.text = "-" + damageTaken;
        DamageTakenText.gameObject.SetActive(true);
        yield return new WaitForSeconds(delay);
        DamageTakenText.gameObject.SetActive(false);
    }
}
