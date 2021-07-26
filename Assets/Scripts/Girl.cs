using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Girl : MonoBehaviour
{
    // Auto-implemented property
    public Animator Anim { get; set; }

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

    [SerializeField] protected Text damage_taken_text;

    void Awake()
    {
        Anim = GetComponent<Animator>();
    }

    void ResetAnimation()
    {
        Anim.SetBool("isLookUp", false);
        Anim.SetBool("isRun", false);
        Anim.SetBool("isJump", false);
    }

    public virtual void Run()
    {
        ResetAnimation();
        Anim.SetBool("isRun", true);
    }

    public virtual void HurtAction()
    {
        ResetAnimation();
        Anim.SetTrigger("hurt");
    }

    void HurtText()
    {
        StartCoroutine(ShowTakenDamage(DamageTaken, 0.3f));
    }

    public void Hurt()
    {
        HurtAction();
        HurtText();
    }

    IEnumerator ShowTakenDamage(float damage_taken, float delay)
    {
        damage_taken_text.text = "-" + damage_taken;
        damage_taken_text.gameObject.SetActive(true);
        yield return new WaitForSeconds(delay);
        damage_taken_text.gameObject.SetActive(false);
    }
}
