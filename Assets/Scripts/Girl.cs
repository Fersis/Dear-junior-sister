using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Girl : MonoBehaviour
{
    protected Animator anim;

    private float _damage_taken;
    public float damage_taken
    {
        get
        {
            return _damage_taken;
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
                _damage_taken = value;
            }
        }
    }

    [SerializeField] protected Text damage_taken_text;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void ResetAnimation()
    {
        anim.SetBool("isLookUp", false);
        anim.SetBool("isRun", false);
        anim.SetBool("isJump", false);
    }

    public virtual void Run()
    {
        ResetAnimation();
        anim.SetBool("isRun", true);
    }

    public virtual void HurtAction()
    {
        ResetAnimation();
        anim.SetTrigger("hurt");
    }

    void HurtText()
    {
        StartCoroutine(ShowTakenDamage(_damage_taken, 0.3f));
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
