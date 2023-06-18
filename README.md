# Bilgi_Yon_Api

# APİ KULLANIMI İÇİN BİLGİLER

## ÖĞRENCİ BİLGİ EKRANI İÇİN
  
  
 ### ÖĞRENCİ LİSTELEME İÇİN;
 URL:https://localhost:44370/api/OgrenciBilgi
    
 ### KİŞİ BAZLI ÖĞRENCİ LİSTELEME İÇİN;
 URL:https://localhost:44370/api/OgrenciBilgi/OGRENCI_NO
 
 ### ÖĞRENCİ EKLEMEK İÇİN;
 URL:https://localhost:44370/api/OgrenciBilgi
 {
 
  "ad": "string",
  "soyad": "string"
 }
 
  ### ÖĞRENCİ SİLMEK İÇİN;
 URL:https://localhost:44370/api/OgrenciBilgi/OGRENCI_NO

 
  ### ÖĞRENCİ GÜNCELLEMEK İÇİN;
 URL:https://localhost:44370/api/OgrenciBilgi
{
  "ogrencI_NO": 0,
  "ad": "string",
  "soyad": "string"
}


 ## NOTLAR BİLGİ EKRANI İÇİN
 
 
  ### NOTLAR LİSTELEME İÇİN;
https://localhost:44370/api/OgrenciNotlar    

    
 ### KİŞİ BAZLI NOTLAR LİSTELEME İÇİN;
 https://localhost:44370/api/OgrenciNotlar/ID    

  
 ### NOTLAR EKLEMEK İÇİN;
 https://localhost:44370/api/OgrenciNotlar    

{
 
  "notu": 0,
  "ogrencI_NO": 0
}
 
  ### NOTLAR SİLMEK İÇİN;
https://localhost:44370/api/OgrenciNotlar/ID    

 
  ### NOTLAR GÜNCELLEMEK İÇİN;
 https://localhost:44370/api/OgrenciNotlar    
{
  "id": 0,
  "notu": 0,
  "ogrencI_NO": 0
}

 
 
 
 
 
 
 
 
 
 
 
  
