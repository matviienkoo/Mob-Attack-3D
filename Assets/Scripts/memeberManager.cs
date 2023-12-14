using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class memeberManager : MonoBehaviour
{
    public Animator character_animator;
    public GameObject Particle_Death;
    private Transform Boss;
    private Transform Agressor;
    public int Health;
    public float MinDistanceOfEnemy,MaxDistanceOfEnemy,moveSpeed;
    public bool fight,member;
    private Rigidbody rb;
    private CapsuleCollider _capsuleCollider;

    public CapsuleCollider myCollider;

    public int Loaded_level;
    public int int_level;

    // audio 
    public AudioSource Audio_obcerantable;  
    public AudioSource add_sound;
    public AudioSource punch_sound;
    public GameObject Shach;

    public int Music_int;

    // upg bonus
    int upgrade_bonus_int;

    public int Life;
    public int Dead;
    public int Life_define;
    public int Dead_define;

    public int int_jump;
    
    void Start()
    { 
        PlayerPrefs.DeleteKey("Dead");
        PlayerPrefs.DeleteKey("Life");

        character_animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        _capsuleCollider = GetComponent<CapsuleCollider>();
        Health = 3;     
    }

    void Update()
    {
        Dead = PlayerPrefs.GetInt("Dead");
        Life = PlayerPrefs.GetInt("Life");

        Loaded_level = PlayerPrefs.GetInt("Loaded_level");
        Music_int = PlayerPrefs.GetInt("Music_int");
        int_level = PlayerPrefs.GetInt("int_level");
        int_jump = PlayerPrefs.GetInt("int_jump");

        upgrade_bonus_int = PlayerPrefs.GetInt("upgrade_bonus_int");

        // life
        if (gameObject.tag == "add_special"){
            if (Life_define == 0){
            Life += 1;
            PlayerPrefs.SetInt("Life",Life);
            Life_define = 1;
            }
        }

        // dead
        if (Dead_define == 1){
            Dead += 1;
            PlayerPrefs.SetInt("Dead",Dead);
            Dead_define = 2;
        }

        if (Loaded_level == 1){
        Boss = GameObject.FindWithTag("boss").transform;
        var bossDistance = Boss.position - transform.position;

        if (!fight)
        {
            if (bossDistance.sqrMagnitude <= MaxDistanceOfEnemy * MaxDistanceOfEnemy)
            {
                PlayerManager.PlayerManagerCls.attackToTheBoss = true;
                PlayerManager.PlayerManagerCls.gameState = false;

                Shach.SetActive(false);
            }

            if (PlayerManager.PlayerManagerCls.attackToTheBoss && member)
            {
                transform.position = Vector3.MoveTowards(transform.position,Boss.position,moveSpeed * Time.deltaTime);
                
                var stickManRotation = new Vector3(Boss.position.x,transform.position.y,Boss.position.z) - transform.position;
                
                transform.rotation = Quaternion.Slerp(transform.rotation,quaternion.LookRotation(stickManRotation,Vector3.up),10f * Time.deltaTime );
                
                character_animator.SetFloat("run",1f);
                
                rb.velocity = Vector3.zero;
            }
        }

        if (bossDistance.sqrMagnitude <= MinDistanceOfEnemy * MinDistanceOfEnemy)
        {
            fight = true;
            
            var stickManRotation = new Vector3(Boss.position.x,transform.position.y,Boss.position.z) - transform.position;
                
            transform.rotation = Quaternion.Slerp(transform.rotation,quaternion.LookRotation(stickManRotation,Vector3.up),10f * Time.deltaTime );
                
            character_animator.SetBool("fight",true);

            MinDistanceOfEnemy = MaxDistanceOfEnemy;
           
            rb.velocity = Vector3.zero;
        }

        else
        {
            fight = false;
        }

        }
    }

    public void ChangeTheAttackMode()
    {
        character_animator.SetFloat("attackmode",Random.Range(0,2));
     
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("jump"))
        {
            transform.DOJump(transform.position, 1f, 1, 1f).SetEase(Ease.Flash);

            int_jump = 1;
            PlayerPrefs.SetInt("int_jump",int_jump);
        }

        if (other.collider.CompareTag("road"))
        {
            int_jump = 0;
            PlayerPrefs.SetInt("int_jump",int_jump);
        }

        if (other.collider.CompareTag("damage"))
        {
            Health--;

            if (Health <= 0)
            {
                if (Dead_define <= 0){
                Instantiate(Particle_Death, transform.position, Quaternion.identity);
                Dead_define = 1;
                }

                if (gameObject.name != PlayerManager.PlayerManagerCls.Rblst.ElementAt(0).name)
                {

                    // умирает добвленный
                    myCollider.enabled = false;
                    transform.GetChild(0).gameObject.SetActive(false);
                    transform.GetChild(1).gameObject.SetActive(false);
                }
                else
                {

                    // умирает игрок
                    myCollider.enabled = false;

                    transform.GetChild(0).gameObject.SetActive(false);
                    transform.GetChild(1).gameObject.SetActive(false);
                }
              
                for (int i = 0; i < bossManager.BossManagerCls.Enemies.Count; i++)
                {
                    if (bossManager.BossManagerCls.Enemies.ElementAt(i).name == gameObject.name)
                    {
                        bossManager.BossManagerCls.Enemies.RemoveAt(i);
                        break;
                    }
                }

                bossManager.BossManagerCls.LockOnTarget = false;                  
                }

        }

        // система препядствий
        if (other.collider.CompareTag("obstacle"))
        {   
                // панель бонуса
                if (upgrade_bonus_int >= 1){
                    if (Music_int == 0){
                    punch_sound.Play();
                    }

                    Instantiate(Particle_Death, transform.position, Quaternion.identity);
                    Destroy(other.collider.gameObject);
                }

                // смерть вторичного персонажа
                if (upgrade_bonus_int == 0){

                if (gameObject.name != PlayerManager.PlayerManagerCls.Rblst.ElementAt(0).name)
                {
                    if (Dead_define <= 0){
                    Instantiate(Particle_Death, transform.position, Quaternion.identity);
                    Dead_define = 1;
                    }

                    // умирает добвленный
                    myCollider.enabled = false;
                    transform.GetChild(0).gameObject.SetActive(false);
                    transform.GetChild(1).gameObject.SetActive(false);

                    if (Music_int == 0){
                    Audio_obcerantable.Play();
                    }          
                }

                else
                {
                    // смерть главного персонажа
                    if (Dead_define <= 0){
                    Instantiate(Particle_Death, transform.position, Quaternion.identity);
                    Dead_define = 1;
                    }

                    // умирает игрок
                    myCollider.radius = 0f;
                    myCollider.height = 0f;

                    transform.GetChild(0).gameObject.SetActive(false);
                    transform.GetChild(1).gameObject.SetActive(false);

                    if (Music_int == 0){
                    Audio_obcerantable.Play();
                    }
                }
                }
                
                for (int i = 0; i < bossManager.BossManagerCls.Enemies.Count; i++)
                {
                    if (bossManager.BossManagerCls.Enemies.ElementAt(i).name == gameObject.name)
                    {
                        bossManager.BossManagerCls.Enemies.RemoveAt(i);
                        break;
                    }
                }
        }

        // add person
        if (other.collider.CompareTag("add"))
        {  
            if (Music_int == 0){ 
            add_sound.Play();
            }

            other.rigidbody.constraints = RigidbodyConstraints.None; 
            other.rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionY; 

            other.gameObject.tag = "add_special";
        }

        // speed upg bonus
        if (other.collider.CompareTag("upg"))
        {   
            Destroy(other.collider.gameObject);

            upgrade_bonus_int = 1;
            PlayerPrefs.SetInt("upgrade_bonus_int",upgrade_bonus_int);
        }
    }
}
