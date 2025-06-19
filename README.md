# Patikaflix Pratik – TV Dizi Kayıt Uygulaması

Bu C# konsol uygulaması, kullanıcıdan dizi bilgilerini alarak bir listeye kaydeder ve "komedi" türündeki dizileri sıralayıp ekrana yazdırır.

## 🚀 Özellikler

- Kullanıcıya dizi eklemek isteyip istemediği sorulur.
- Kullanıcı `e` tuşuna bastığında:
  - Dizi adı
  - Yapım yılı
  - Türü
  - Yayın yılı
  - Yönetmen
  - İlk yayınlandığı platform bilgileri alınır.
- Girilen diziler bir `List<TvSeries>` listesinde tutulur.
- Türü **"komedi"** olan diziler filtrelenir, `ComedySeries` listesine aktarılır ve sıralanarak ekrana yazdırılır.
