using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerManager : MonoBehaviour
{
    public bool MoveByTouch, gameState, attackToTheBoss;
    private Vector3 Direction;
    public List<Rigidbody>  Rblst = new List<Rigidbody>();
    [SerializeField] private float runSpeed, velocity, swipeSpeed, roadSpeed;
    public static PlayerManager PlayerManagerCls;

    public Transform road_1;
    public Transform road_2;
    public Transform road_3;
    public Transform road_4;
    public Transform road_5;
    public Transform road_6;
    public Transform road_7;
    public Transform road_8;
    public Transform road_9;
    public Transform road_10;
    public Transform road_11;
    public Transform road_12;
    public Transform road_13;
    public Transform road_14;
    public Transform road_15;
    public Transform road_16;
    public Transform road_17;
    public Transform road_18;
    public Transform road_19;
    public Transform road_20;
    public Transform road_21;
    public Transform road_22;
    public Transform road_23;
    public Transform road_24;
    public Transform road_25;
    public Transform road_26;
    public Transform road_27;
    public Transform road_28;
    public Transform road_29;
    public Transform road_30;
    public Transform road_31;
    public Transform road_32;
    public Transform road_33;
    public Transform road_34;
    public Transform road_35;
    public Transform road_36;
    public Transform road_37;
    public Transform road_38;
    public Transform road_39;
    public Transform road_40;
    public Transform road_41;
    public Transform road_42;
    public Transform road_43;
    public Transform road_44;
    public Transform road_45;
    public Transform road_46;
    public Transform road_47;
    public Transform road_48;
    public Transform road_49;
    public Transform road_50;

    public int int_level;

    // audio
    public GameObject Speed_sound;
    public GameObject Shach;
    public int Music_int;

    // upg bonus
    public int upgrade_bonus_int;
    float upgrade_bonus_float;

    int int_jump;
    int define_jump;
    int click_jump;

    void Start()
    {
        PlayerManagerCls = this;
        Rblst.Add(transform.GetChild(0).GetComponent<Rigidbody>());

        upgrade_bonus_int = 0;
        PlayerPrefs.SetInt("upgrade_bonus_int",upgrade_bonus_int);
     
    }
    
    void Update()
    {
        int_jump = PlayerPrefs.GetInt("int_jump");
        int_level = PlayerPrefs.GetInt("int_level");
        Music_int = PlayerPrefs.GetInt("Music_int");

        upgrade_bonus_int = PlayerPrefs.GetInt("upgrade_bonus_int");


        if (int_jump == 1){
        MoveByTouch = true;
        if (Music_int == 0){
        Shach.SetActive(true);
        }

        define_jump = 1;
        }

        if (int_jump == 0){
        if (click_jump == 0){
        if (define_jump == 1){
            MoveByTouch = false;
            if (Music_int == 0){
            Shach.SetActive(false);
            }

            define_jump = 0;
        }
        }  
        }

        // speed upgrade
        if (upgrade_bonus_int == 1){
        roadSpeed = 0.6f; 
        upgrade_bonus_float += Time.deltaTime;
        if (Music_int == 0){
        Speed_sound.SetActive(true);
        }
            if (upgrade_bonus_float >= 3){
                Speed_sound.SetActive(false);
                upgrade_bonus_float = 0; 
                roadSpeed = 0.45f;
                upgrade_bonus_int = 0;
                PlayerPrefs.SetInt("upgrade_bonus_int",upgrade_bonus_int);
            }
        }
        
        if (gameState)
        {
            if (Input.GetMouseButtonDown(0))
            {
                click_jump = 1;
                if (int_jump == 0){
                MoveByTouch = true;
                if (Music_int == 0){
                Shach.SetActive(true);
                }
                }
            }
        
            if (Input.GetMouseButtonUp(0))
            {
                click_jump = 0;
                if (int_jump == 0){
                MoveByTouch = false;
                if (Music_int == 0){
                Shach.SetActive(false);
                }
                }
            }
        
            if (MoveByTouch)
            { 
            
                Direction.x = Mathf.Lerp(Direction.x,Input.GetAxis("Mouse X"), Time.deltaTime * runSpeed);
           
                Direction = Vector3.ClampMagnitude(Direction,1f);
            
                if (int_level == 1){
                road_1.position = new Vector3(0f,0f,Mathf.SmoothStep(road_1.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 2){
                road_2.position = new Vector3(0f,0f,Mathf.SmoothStep(road_2.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 3){
                road_3.position = new Vector3(0f,0f,Mathf.SmoothStep(road_3.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 4){
                road_4.position = new Vector3(0f,0f,Mathf.SmoothStep(road_4.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 5){
                road_5.position = new Vector3(0f,0f,Mathf.SmoothStep(road_5.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 6){
                road_6.position = new Vector3(0f,0f,Mathf.SmoothStep(road_6.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 7){
                road_7.position = new Vector3(0f,0f,Mathf.SmoothStep(road_7.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 8){
                road_8.position = new Vector3(0f,0f,Mathf.SmoothStep(road_8.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 9){
                road_9.position = new Vector3(0f,0f,Mathf.SmoothStep(road_9.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 10){
                road_10.position = new Vector3(0f,0f,Mathf.SmoothStep(road_10.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 11){
                road_11.position = new Vector3(0f,0f,Mathf.SmoothStep(road_11.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 12){
                road_12.position = new Vector3(0f,0f,Mathf.SmoothStep(road_12.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 13){
                road_13.position = new Vector3(0f,0f,Mathf.SmoothStep(road_13.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 14){
                road_14.position = new Vector3(0f,0f,Mathf.SmoothStep(road_14.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 15){
                road_15.position = new Vector3(0f,0f,Mathf.SmoothStep(road_15.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 16){
                road_16.position = new Vector3(0f,0f,Mathf.SmoothStep(road_16.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 17){
                road_17.position = new Vector3(0f,0f,Mathf.SmoothStep(road_17.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 18){
                road_18.position = new Vector3(0f,0f,Mathf.SmoothStep(road_18.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 19){
                road_19.position = new Vector3(0f,0f,Mathf.SmoothStep(road_19.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 20){
                road_20.position = new Vector3(0f,0f,Mathf.SmoothStep(road_20.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 21){
                road_21.position = new Vector3(0f,0f,Mathf.SmoothStep(road_21.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 22){
                road_22.position = new Vector3(0f,0f,Mathf.SmoothStep(road_22.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 23){
                road_23.position = new Vector3(0f,0f,Mathf.SmoothStep(road_23.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 24){
                road_24.position = new Vector3(0f,0f,Mathf.SmoothStep(road_24.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 25){
                road_25.position = new Vector3(0f,0f,Mathf.SmoothStep(road_25.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 26){
                road_26.position = new Vector3(0f,0f,Mathf.SmoothStep(road_26.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 27){
                road_27.position = new Vector3(0f,0f,Mathf.SmoothStep(road_27.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 28){
                road_28.position = new Vector3(0f,0f,Mathf.SmoothStep(road_28.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 29){
                road_29.position = new Vector3(0f,0f,Mathf.SmoothStep(road_29.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 30){
                road_30.position = new Vector3(0f,0f,Mathf.SmoothStep(road_30.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 31){
                road_31.position = new Vector3(0f,0f,Mathf.SmoothStep(road_31.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 32){
                road_32.position = new Vector3(0f,0f,Mathf.SmoothStep(road_32.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 33){
                road_33.position = new Vector3(0f,0f,Mathf.SmoothStep(road_33.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 34){
                road_34.position = new Vector3(0f,0f,Mathf.SmoothStep(road_34.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 35){
                road_35.position = new Vector3(0f,0f,Mathf.SmoothStep(road_35.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 36){
                road_36.position = new Vector3(0f,0f,Mathf.SmoothStep(road_36.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 37){
                road_37.position = new Vector3(0f,0f,Mathf.SmoothStep(road_37.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 38){
                road_38.position = new Vector3(0f,0f,Mathf.SmoothStep(road_38.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 39){
                road_39.position = new Vector3(0f,0f,Mathf.SmoothStep(road_39.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 40){
                road_40.position = new Vector3(0f,0f,Mathf.SmoothStep(road_40.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 41){
                road_41.position = new Vector3(0f,0f,Mathf.SmoothStep(road_41.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 42){
                road_42.position = new Vector3(0f,0f,Mathf.SmoothStep(road_42.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 43){
                road_43.position = new Vector3(0f,0f,Mathf.SmoothStep(road_43.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 44){
                road_44.position = new Vector3(0f,0f,Mathf.SmoothStep(road_44.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 45){
                road_45.position = new Vector3(0f,0f,Mathf.SmoothStep(road_45.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 46){
                road_46.position = new Vector3(0f,0f,Mathf.SmoothStep(road_46.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 47){
                road_47.position = new Vector3(0f,0f,Mathf.SmoothStep(road_47.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 48){
                road_48.position = new Vector3(0f,0f,Mathf.SmoothStep(road_48.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 49){
                road_49.position = new Vector3(0f,0f,Mathf.SmoothStep(road_49.position.z,-100f,Time.deltaTime * roadSpeed));
                }
                if (int_level == 50){
                road_50.position = new Vector3(0f,0f,Mathf.SmoothStep(road_50.position.z,-100f,Time.deltaTime * roadSpeed));
                }

                foreach (var stickman_Anim in Rblst)
                    stickman_Anim.GetComponent<Animator>().SetFloat("run",1f);
            }
        
            else
            {
                foreach (var stickman_Anim in Rblst)
                    stickman_Anim.GetComponent<Animator>().SetFloat("run",0f);
            }

            foreach (var stickman_rb in Rblst)
            {
                if (stickman_rb.velocity.magnitude > 0.5f)
                {
                    stickman_rb.rotation = Quaternion.Slerp(stickman_rb.rotation,Quaternion.LookRotation(stickman_rb.velocity), Time.deltaTime * velocity );
                }
                else
                {
                    stickman_rb.rotation = Quaternion.Slerp(stickman_rb.rotation,Quaternion.identity, Time.deltaTime * velocity );
                }
            }
        }
        else
        {
            if (!bossManager.BossManagerCls.BossIsAlive)
            {
                foreach (var stickMan in Rblst)
                {
                    stickMan.GetComponent<Animator>().SetFloat("attackmode",4);
                }
            }
        }
        
           
        
    }
    
    private void FixedUpdate()
    {
        if (gameState)
        {
            if (MoveByTouch)
            {
                Vector3 displacement = new Vector3(Direction.x,0f,0f) * Time.fixedDeltaTime;
            
                foreach (var stickman_rb in Rblst)
                    stickman_rb.velocity = new Vector3(Direction.x * Time.fixedDeltaTime * swipeSpeed,0f,0f) + displacement;
            }
            else
            {
                foreach (var stickman_rb in Rblst)
                    stickman_rb.velocity = Vector3.zero;
            }
        }
        
    }
}
