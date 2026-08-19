# Öğrenci Bilgi Sistemi - Erdem Okulları 🎓

Bu proje, C# ve Windows Forms kullanılarak geliştirilmiş temel bir öğrenci bilgi sistemidir. Öğrencilerin kişisel bilgilerini kayıt altına alırken, girilen sınav notları üzerinden dönem sonu başarı ortalamasını otomatik olarak hesaplar ve kullanıcıya raporlar.

## 🚀 Özellikler

* **Kişisel Veri Girişi:** Öğrencinin adı, soyadı, okul numarası, TC kimlik numarası ve doğum tarihi (DateTimePicker) gibi temel bilgilerinin sisteme girilmesi.
* **Veri Formatlama:** TC Kimlik ve okul numarası gibi alanlarda hatalı girişi önlemek için MaskedTextBox kullanımı.
* **Ağırlıklı Not Hesaplama:** Vize, Proje ve Final notları üzerinden matematiksel oranlarla dönem sonu ortalamasının bulunması.
* **Dinamik Sonuç Ekranı:** Butona tıklandığı anda girilen tüm bilgilerin ve hesaplanan ortalamanın detaylı bir şekilde bilgi panosuna (RichTextBox) yazdırılması.

## 💻 Kullanılan Teknolojiler

* **Dil:** C#
* **Arayüz:** Windows Forms (WinForms)
* **Ortam:** Visual Studio & .NET

## ⚙️ Nasıl Kullanılır?

1. Uygulamayı çalıştırdığınızda sol taraftaki alana öğrencinin kimlik bilgilerini (Ad, Soyad, Numara, TC, Doğum Günü) eksiksiz girin.
2. Sağ üst taraftaki not giriş alanlarına sırasıyla **Vize**, **Proje** ve **Final** notlarını tam sayı olarak yazın.
3. Ekrandaki **KAYDET!** butonuna tıklayın.
4. Sistem arka planda notları belirlediğiniz katsayılara göre çarparak toplar.
5. Hesaplanan nihai sonuç, hem "Ortalama:" etiketinin yanında (label9) belirir hem de alt kısımdaki büyük beyaz alanda öğrenci bilgileriyle birlikte listelenir.

## 👨‍💻 Geliştirici

**Ahmet Erdem**
*İstanbul Sabahattin Zaim Üniversitesi - Bilgisayar Mühendisliği*
