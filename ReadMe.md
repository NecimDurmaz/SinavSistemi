# Sınav Otomasyonu

## Hazırlayanlar;
-[Necim Durmaz](https://github.com/NecimDurmaz)

-[Mustafa Yenal](https://github.com/2129mustafa)

-[Yavuz Selim Göç](https://github.com/YavuzSelimGoc)

-[Mehmet Yıldırım](https://github.com/MehmetYildirimDev)

## A-) Programın çalışma işleyişi;

 Programın amacı bir soruyu 6 farklı zamanda görüp soruyu her bir defasında doğru yaparak hafızaya kalıcı olarak alıp o sorunun konusunu öğrenmektir. Soruyu yanlış çözdüğünde bu döngü baştan başlayarak 6 defa art arda oluncaya kadar o soru farklı zamanlarda karşısına gelmektedir ve bu işleyişe Sigma 6 denir.

## B-) Giriş;

1-) Kullanıcı ilk girdiğine Kaydol kısmından kendi kaydını mailine göre kaydediyor. Bu kayıt tamamlandığında sistem tarafından Sigma 6 zamanları otomatik dolduruluyor. Uygulamaya kendi maili ve şifresi ile girdiğinde çıkan ana ekrandan istenilirse bu zamanlar istenilen şekilde değiştiriliyor.

## C-) Öğrenci;

2-) Çözülen sorulardan Sigma 6 zamanlarına uygun şekilde gelmesi gereken sorular veri tabanından çekiliyor. Bu sorulara ek olarak 10 tane rastgele soru eklenip sınav bu soruların zorluğuna göre zamanı otomatik oluşturup sınav başlıyor. Soru istenilirse boş bırakılabiliyor ve istenilen soruya geri dönülebiliyor. Soruyu cevapladığınız takdirde sorunun doğru cevabı anlık olarak gösteriliyor. Sınav bitirmek istediğinizde veya süre bitince soruların cevap butonları kapanıyor ve sınav sonucunuz geliyor. İstenilirse soruları gezerek soruların cevabını ve verdiğiniz cevaplara bakılabiliyor. Sınav bittiğinde soruya verilen doğru, yanlış ve boş cevaplara göre veri tabanı güncelleniyor.
3-) İstenilirse en son yanlış çözülen sorulardan süre bazlı olmayan bir sınav oluşturulabiliyor.
4-) İstatistik kısmından tüm konulardaki doğru, yanlış ve boş sayısını görüp yüzdelik olarak kaç doğru yaptığınızın çıktısı alınabiliyor. İstenilen dersin konusundaki sorulardaki doğru, yanlış ve boş sayınızı grafikte görülüyor ve o konudaki toplam doğru, yanlış ve boş sayısı pasta grafikte gösteriliyor.

## D-) Sınav Sorumlusu;

5-) Soru ekleme bölümünden sorunun zorluğunu, resmini, cevaplarını, açıklamasını ve detaylarını ekliyor. Bu eklenen soru admin onaylayana kadar pasif bir durumda veri tabanına ekleniyor.
6-) Ders ve Konu ekleme bölümünden ders ve konu ekleniyor.

## E-) Admin;

7-) Sınav Sorumlusunun eklediği soruları onaylamayı bekleyen kısmında görüntülüyor. Sorunun üstüne tıklandığında detaylıca soru görülüyor ve isteniliyorsa soruyu onaylayıp soru havuzuna ekliyor veya silebiliyor.
8-)Soru havuzundaki aktif olan tüm soruları tüm sorular kısmından görüntüleyebiliyor.
9-) Kayıtları görüntüle ve düzenle kısmından sistemdeki tüm kullanıcıları görüp üstüne bastığında bilgilerini detaylıca görüp bunları güncelleyebiliyor.

## -) Sınav Sistemi
Öğrenci ilk kaydolduğunda Sigma sıklığı otomatik sistem tarafından atanır. Sınav başlatılırken Sigma zamanlarına uygun soru varsa eğer ilk o soruların ID ve cevapları Collections kütüphanesinin Array.Resize() fonksiyonu sayesinde dizilerin boyutları arttırarak dizilere atılarak tutulur. Sonrasında bu sorulara ek olarak rastgele 10 soru daha eklenir. Soruların Zorluğuna göre sınavın süresi belirlenip sınav başlatılıyor. Sorulara cevap verildiğinde anlık olarak doğru cevabı gösteriliyor. Soru istenilirse boş bırakılabiliyor. Bir önceki ve bir sonraki soruya gidip boş bırakılan sorular istenilirse doldurulabilir. Sınavı bitir butonuna basınca veya sınav süresi bitince cevap butonları kapanır. Sınav sonucu gösterilir (doğru, yanlış, boş sayısı).İstenilirse sorular arasında gezip cevaplarına ve verilen cevaplara bakılabilir. Sınav bittiğinde sorunun durumuna göre (doğru, yanlış, boş)DogruSoruHavuzu’ndan -Sigma 6-  gelen sorular doğru ise sayaç bir arttırılır yoksa döngü baştan başlaması için silinir. Yanlış yapılan sorular YanlışSoruHavuzuna eklenir özel sınavda kullanılmak için. Soruların şimdiye dek kaç defa doğru, yanlış, boş yapıldığının tutulduğu IstatistikSoru veritabanında durumu bir arttırılır.

