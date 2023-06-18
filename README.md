# Bilgi Yön API

API kullanımı için aşağıdaki bilgileri kullanabilirsiniz:

## Öğrenci Bilgi Ekranı İçin

### Öğrenci Listeleme İçin
URL: https://localhost:44370/api/OgrenciBilgi

### Kişi Bazlı Öğrenci Listeleme İçin
URL: https://localhost:44370/api/OgrenciBilgi/OGRENCI_NO

### Öğrenci Ekleme İçin
URL: https://localhost:44370/api/OgrenciBilgi

{
  "ad": "string",
  "soyad": "string"
}

### Öğrenci Silme İçin
URL: https://localhost:44370/api/OgrenciBilgi/OGRENCI_NO

### Öğrenci Güncelleme İçin
URL: https://localhost:44370/api/OgrenciBilgi

{
  "ogrencI_NO": 0,
  "ad": "string",
  "soyad": "string"
}

## Notlar Bilgi Ekranı İçin

### Notlar Listeleme İçin
URL: https://localhost:44370/api/OgrenciNotlar

### Kişi Bazlı Notlar Listeleme İçin
URL: https://localhost:44370/api/OgrenciNotlar/ID

### Notlar Ekleme İçin
URL: https://localhost:44370/api/OgrenciNotlar

{
  "notu": 0,
  "ogrencI_NO": 0
}

### Notlar Silme İçin
URL: https://localhost:44370/api/OgrenciNotlar/ID

### Notlar Güncelleme İçin
URL: https://localhost:44370/api/OgrenciNotlar

{
  "id": 0,
  "notu": 0,
  "ogrencI_NO": 0
}
