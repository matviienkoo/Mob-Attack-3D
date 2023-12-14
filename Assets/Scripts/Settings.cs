using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Settings : MonoBehaviour
{
    public int Music_int;
    public TextMeshProUGUI Text_Music;

    // langugage
    public Text contry_text;
    int contry_int;

    public int Vibration_int;

    void Start (){
    Music_int = PlayerPrefs.GetInt("Music_int");

        // ON
        if (Music_int == 0){
        if (contry_text.text == "United Kingdom"){
        Text_Music.text = "On"; 
        contry_int = 1;
        }
        if (contry_text.text == "Russia"){
        Text_Music.text = "Вкл"; 
        contry_int = 1;
        }
        if (contry_text.text == "Ukraine"){
        Text_Music.text = "Вкл"; 
        contry_int = 1;
        }
        if (contry_text.text == "Canada"){
        Text_Music.text = "On"; 
        contry_int = 1;
        }
        if (contry_text.text == "United States"){
        Text_Music.text = "On"; 
        contry_int = 1;
        }
        if (contry_text.text == "Netherlands"){
        Text_Music.text = "Aan"; 
        contry_int = 1;
        }
        if (contry_text.text == "Italy"){
        Text_Music.text = "Acceso"; 
        contry_int = 1;
        }
        if (contry_text.text == "Germany"){
        Text_Music.text = "An"; 
        contry_int = 1;
        }
        if (contry_text.text == "France"){
        Text_Music.text = "Allumé"; 
        contry_int = 1;
        }
        if (contry_text.text == "Austria"){
        Text_Music.text = "An"; 
        contry_int = 1;
        }
        if (contry_text.text == "Sweden"){
        Text_Music.text = "På"; 
        contry_int = 1;
        }
        if (contry_text.text == "Norway"){
        Text_Music.text = "På"; 
        contry_int = 1;
        }
        if (contry_text.text == "Finland"){
        Text_Music.text = "On"; 
        contry_int = 1;
        }
        if (contry_text.text == "Denmark"){
        Text_Music.text = "Tænd"; 
        contry_int = 1;
        }
        if (contry_text.text == "Czech Republic"){
        Text_Music.text = "Zapnuto"; 
        contry_int = 1;
        }
        if (contry_text.text == "Slovakia"){
        Text_Music.text = "Zapnuté"; 
        contry_int = 1;
        }
        if (contry_text.text == "Hungary"){
        Text_Music.text = "Be"; 
        contry_int = 1;
        }
        if (contry_text.text == "Bulgaria"){
        Text_Music.text = "Включено"; 
        contry_int = 1;
        }
        if (contry_text.text == "Spain"){
        Text_Music.text = "Esncendido"; 
        contry_int = 1;
        }   

        if (contry_int == 0){
        Text_Music.text = "On";  
        } 
        }

        // OFF
        if (Music_int == 1){
        if (contry_text.text == "United Kingdom"){
        Text_Music.text = "Off"; 
        contry_int = 1;
        }
        if (contry_text.text == "Russia"){
        Text_Music.text = "Выкл"; 
        contry_int = 1;
        }
        if (contry_text.text == "Ukraine"){
        Text_Music.text = "Викл"; 
        contry_int = 1;
        }
        if (contry_text.text == "Canada"){
        Text_Music.text = "Off"; 
        contry_int = 1;
        }
        if (contry_text.text == "United States"){
        Text_Music.text = "Off"; 
        contry_int = 1;
        }
        if (contry_text.text == "Netherlands"){
        Text_Music.text = "Uit"; 
        contry_int = 1;
        }
        if (contry_text.text == "Italy"){
        Text_Music.text = "Spento"; 
        contry_int = 1;
        }
        if (contry_text.text == "Germany"){
        Text_Music.text = "Aus"; 
        contry_int = 1;
        }
        if (contry_text.text == "France"){
        Text_Music.text = "De"; 
        contry_int = 1;
        }
        if (contry_text.text == "Austria"){
        Text_Music.text = "Aus"; 
        contry_int = 1;
        }
        if (contry_text.text == "Sweden"){
        Text_Music.text = "Av"; 
        contry_int = 1;
        }
        if (contry_text.text == "Norway"){
        Text_Music.text = "Av"; 
        contry_int = 1;
        }
        if (contry_text.text == "Finland"){
        Text_Music.text = "Off"; 
        contry_int = 1;
        }
        if (contry_text.text == "Denmark"){
        Text_Music.text = "Sluk"; 
        contry_int = 1;
        }
        if (contry_text.text == "Czech Republic"){
        Text_Music.text = "Vypnuto"; 
        contry_int = 1;
        }
        if (contry_text.text == "Slovakia"){
        Text_Music.text = "Vypnuté"; 
        contry_int = 1;
        }
        if (contry_text.text == "Hungary"){
        Text_Music.text = "Ki"; 
        contry_int = 1;
        }
        if (contry_text.text == "Bulgaria"){
        Text_Music.text = "Изключено"; 
        contry_int = 1;
        }
        if (contry_text.text == "Spain"){
        Text_Music.text = "Apagado"; 
        contry_int = 1;
        }   

        if (contry_int == 0){
        Text_Music.text = "Off";  
        }
        }
    }

    public void On_Off_Music (){
        Music_int += 1;

        if (Music_int == 1){
            if (contry_text.text == "United Kingdom"){
            Text_Music.text = "Off"; 
            contry_int = 1;
            }
            if (contry_text.text == "Russia"){
            Text_Music.text = "Выкл"; 
            contry_int = 1;
            }
            if (contry_text.text == "Ukraine"){
            Text_Music.text = "Викл"; 
            contry_int = 1;
            }
            if (contry_text.text == "Canada"){
            Text_Music.text = "Off"; 
            contry_int = 1;
            }
            if (contry_text.text == "United States"){
            Text_Music.text = "Off"; 
            contry_int = 1;
            }
            if (contry_text.text == "Netherlands"){
            Text_Music.text = "Uit"; 
            contry_int = 1;
            }
            if (contry_text.text == "Italy"){
            Text_Music.text = "Spento"; 
            contry_int = 1;
            }
            if (contry_text.text == "Germany"){
            Text_Music.text = "Aus"; 
            contry_int = 1;
            }
            if (contry_text.text == "France"){
            Text_Music.text = "De"; 
            contry_int = 1;
            }
            if (contry_text.text == "Austria"){
            Text_Music.text = "Aus"; 
            contry_int = 1;
            }
            if (contry_text.text == "Sweden"){
            Text_Music.text = "Av"; 
            contry_int = 1;
            }
            if (contry_text.text == "Norway"){
            Text_Music.text = "Av"; 
            contry_int = 1;
            }
            if (contry_text.text == "Finland"){
            Text_Music.text = "Off"; 
            contry_int = 1;
            }
            if (contry_text.text == "Denmark"){
            Text_Music.text = "Sluk"; 
            contry_int = 1;
            }
            if (contry_text.text == "Czech Republic"){
            Text_Music.text = "Vypnuto"; 
            contry_int = 1;
            }
            if (contry_text.text == "Slovakia"){
            Text_Music.text = "Vypnuté"; 
            contry_int = 1;
            }
            if (contry_text.text == "Hungary"){
            Text_Music.text = "Ki"; 
            contry_int = 1;
            }
            if (contry_text.text == "Bulgaria"){
            Text_Music.text = "Изключено"; 
            contry_int = 1;
            }
            if (contry_text.text == "Spain"){
            Text_Music.text = "Apagado"; 
            contry_int = 1;
            }   

            if (contry_int == 0){
            Text_Music.text = "Off";  
            }        
        }
        if (Music_int == 2){
            if (contry_text.text == "United Kingdom"){
            Text_Music.text = "On"; 
            contry_int = 1;
            }
            if (contry_text.text == "Russia"){
            Text_Music.text = "Вкл"; 
            contry_int = 1;
            }
            if (contry_text.text == "Ukraine"){
            Text_Music.text = "Вкл"; 
            contry_int = 1;
            }
            if (contry_text.text == "Canada"){
            Text_Music.text = "On"; 
            contry_int = 1;
            }
            if (contry_text.text == "United States"){
            Text_Music.text = "On"; 
            contry_int = 1;
            }
            if (contry_text.text == "Netherlands"){
            Text_Music.text = "Aan"; 
            contry_int = 1;
            }
            if (contry_text.text == "Italy"){
            Text_Music.text = "Acceso"; 
            contry_int = 1;
            }
            if (contry_text.text == "Germany"){
            Text_Music.text = "An"; 
            contry_int = 1;
            }
            if (contry_text.text == "France"){
            Text_Music.text = "Allumé"; 
            contry_int = 1;
            }
            if (contry_text.text == "Austria"){
            Text_Music.text = "An"; 
            contry_int = 1;
            }
            if (contry_text.text == "Sweden"){
            Text_Music.text = "På"; 
            contry_int = 1;
            }
            if (contry_text.text == "Norway"){
            Text_Music.text = "På"; 
            contry_int = 1;
            }
            if (contry_text.text == "Finland"){
            Text_Music.text = "On"; 
            contry_int = 1;
            }
            if (contry_text.text == "Denmark"){
            Text_Music.text = "Tænd"; 
            contry_int = 1;
            }
            if (contry_text.text == "Czech Republic"){
            Text_Music.text = "Zapnuto"; 
            contry_int = 1;
            }
            if (contry_text.text == "Slovakia"){
            Text_Music.text = "Zapnuté"; 
            contry_int = 1;
            }
            if (contry_text.text == "Hungary"){
            Text_Music.text = "Be"; 
            contry_int = 1;
            }
            if (contry_text.text == "Bulgaria"){
            Text_Music.text = "Включено"; 
            contry_int = 1;
            }
            if (contry_text.text == "Spain"){
            Text_Music.text = "Esncendido"; 
            contry_int = 1;
            }   

            if (contry_int == 0){
            Text_Music.text = "On";  
            } 
            Music_int = 0;
        }

        PlayerPrefs.SetInt("Music_int",Music_int); 
    }

    void Update (){
    Music_int = PlayerPrefs.GetInt("Music_int");
    }
}


