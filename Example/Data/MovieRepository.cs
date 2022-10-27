using System;
using System.Collections.Generic;
using System.Linq;
using Example.Models;

namespace Example.Data
{
    public static class MovieRepository
    {
        private static List<Movie> _movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie() {
                    Id = 1,
                    Name = "Top Gun",
                    ShortDescription = "Full Hd Top Gun",
                    Description = "<p>Başrolünde Tom Cruise’un bulunduğu <strong>Top Gun: Maverick</strong> filmi 1986 yılında yapılan Top Gun filminin devam filmidir. Top Gun kendi döneminin gişe rekorları kırıp çok sevilmiş ve kült filmler arasına girmeyi başarmıştır. Tom Cruise bu filmde Maverick rolünü canlandırıyor. Tom Cruise’a ek olarak oyuncu kadrosunda bulunan isimler ise A Beautiful Mind filminde izlediğimiz Oscar ödüllü oyuncu Jennifer Connelly, Top Gun filminden Val Kilmer, Divergent serisinden Miles Teller, Jon Hamm, Ed Harris ve daha fazlası yer almaktadır.\n<br>Aksiyon ve dram kategorilerine giren 4k formatlı filmin yönetmen koltuğunda oturan isim Oblivion filminin yönetmeni Joseph Kosinski’dir. Senaryoda yer alan isimler ise birbirinden ünlü yapımların senaristliğini üstlenmiş isimler olan Peter Craig, Justin Marks ve Ashley Miller’dır.\n<br>Pete Mitchell namı diğer Maverick bir pilottur ve çoğu kişi tarafından donanmanın en iyi pilotlarından biri olarak kabul görmüştür. Eşsiz yeteneği cesareti herkesin dikkatini çekiyordur. Maverick ordu donanmasına 30 yıldır hizmet ediyordur. Hayatının büyük bir bölümünü gönüllü olarak orduda geçirmiştir. Bir gün Maverick üstlerinden bir terfi alır. Lakin bu terfi Maverick’in hoşuna gitmez çünkü terfiyi kabul ederse karada çalışmak zorunda kalacaktır. Maverick ait olduğu yerin gökyüzü olduğuna inanıyordur bu yüzden cesur bir pilot olarak sınırlarını zorlamak ister. Bir gün eğitilmesi için yeni bir pilot birliği kurulur. Bunun için akla gelen ilk isim ise Maverick’dir. Maverick’in yeni görevi Top Gun’dan mezun olmuş askerleri pilot olarak eğitmektir. Ama bu öyle askerlerin düşündüğü gibi sıradan bir eğitim değildir. Askerler daha önce hiçbir pilotun yüzleşmediği bir eğitimle karşı karşıyadırlar. Maverick bu süreçte bazı zorluklarla mücadele etmek zorunda kalır. Bir gün bir göreve gitmek zorunda kalır. Lakin bu görev Maverick’in düşündüğünden daha fazlasıdır. Maverick’in korkularıyla yüzleşmesi ve aynı zamanda bazı şeylerden de fedakârlık yapması gerekir. Peki, bu Maverick için o kadar kolay olacak mı? Bu zamana kadar başardığı diğer görevler gibi bu durumunda üstesinden kolaylıkla gelebilecek mi?</p>",
                    ImageUrl = "1.jpg",
                    CategoryId = 1
                },
                new Movie() {
                    Id = 2,
                    Name = "Accident Man",
                    ShortDescription = "Döyüş filmi",
                    Description = "<p>Accident Man serisinin ikinci filmi olarak sinemaseverlerin karşısına çıkan <strong>Accident Man 2: Hitman’s Holiday</strong>, seyir zevki son derece yüksek olan bir kara komediyi beyazperdeyle buluştuyor. 4k film formatı seçeneğiyle izleyeceğiniz bu aksiyon ve komedi dolu yapımda, kısa süre önce birbirinden tehlikeli olayların içerisine girmiş Mike Fallon isimli bir suikastçi; bu sefer kendisini amansız bir savaşın içerisinde bulacaktır. Eski sevgilisinin öldürülmesinin ardından hayatı birçok kez tehlike altına giren bu yetenekli suikastçi, bu sefer bir mafya patronunun oğlunu korumakla görevlendirilecektir. Ancak bu görev, hiç de kolay olmayacaktır. Yönetmenliğini George Kirby ve Harry Kirby’nin üstlendiği bu yapımın senaryosu ise aynı zamanda filmin başrolu olan Scott Adkins’in ve Stu Small’ın imzasını taşıyor. 14 Ekim 2022 tarihinde beyazperdeyle buluşan film, aksiyon; komedi ve suç türlerinde karşımıza çıkıyor. Filmin oyuncu kadrosunda ise Scott Adkins, Ray Stevenson, Perry Benson, Sarah Chang, Javad Ramezani ve George Fouracres gibi isimler bulunuyor.\n<br>Suç dünyasında Accident Man lakabıyla tanınan Mike Fallon (Scott Adkins), bir süre önce hamile sevgilisinin öldürülmesinin ardından bunu yapanlardan birer birer intikam almış ve bu tehlikeli savaşın içerisinden sağ çıkmayı başarmıştır. Bunun ardından zor da olsa hayatını yoluna koymayı başarmış olan yetenekli suikastçiyi, şimdilerde yeni ve fazlasıyla tehlikeli bir görev beklemektedir. Günün birinde yeni bir iş alan Mike, ünlü bir mafyanın oğlunun; bazı suikastçiler tarafından hedef alındığını öğrenir.\n<br>Bunun üzerine bu mafya patronu tarafından işe alınan Fallon, bu çocuğu peşine düşen dünyanın en ölümcül ve tehlikeli suikastçilerinden korumakla görevlendirilmiştir. Ancak Mike’ın sorunları sadece bunlarla sınırlı değildir. Bu çocuğu korumaya çalışırken birbirinden tehlikeli suikastçilerle mücadele etmek zorunda kalan Mike, aynı zamanda bir arkadaşını kurtaracaktır. Bir de bunun üstüne yıllardır hayatında olmayan bir baba figürünün ortaya çıkmasıyla hayatı iyice karmaşık bir hal alan Mike, bir kez daha bu zorlu durumların üstesinden gelebilecek midir?</p>",
                    ImageUrl = "2.jpg",
                    CategoryId = 2
                },
                new Movie() {
                    Id = 3,
                    Name = "Mermarid Power",
                    ShortDescription = "Animasyon filmi",
                    Description = "<p>Barbie’nin bu yeni filminde yeni ve bambaşka bir hikâye için uzun bir yolculuğa çıkıyor olacağız. Deniz kızları ve çok daha fazla efsanevi şeyi göreceğimiz deniz altına doğru dalış yapıyoruz. Filmimizin ana kahramanları ise deniz kızları. Deniz kızlarının macerasına kim katılmak istemez ki? Kahramanlarımızın bu seferki amaçları Pacifica dünyasını kurtarmaktır. Bunun için Brooklyn, Malibu, Skipper, Stacie ve Chelsea birer deniz kızına dönüşmek zorundadır. İşte soluksuz macera da tam buradan sonra başlamaktadır. Deniz kızına dönüşen kahramanlarımızın başına neler gelecek dersiniz?\n<br>Denizlerde yaşayan ve daha önceki filmlerden tanıdığımız Isla, kızları bir yarışma için deniz altına çağırır. Bu yarışmanın sonucunda Güç Bekçileri seçilecektir. Denizleri korumak için ihtiyaç duyulan kişilerdir. Kızlar bu yarışmalar sırasında bir sürü yeni kişi ile tanışırlar. Artık çok daha fazla deniz altında yaşayan arkadaşları olmuştur. Kızlar bu yarışmalar sırasında ne tür ve hangi güçlere sahip deniz kızları olduklarını keşfedeceklerdir. Yarışmaların sonucunda kızlar hava, su, toprak ve ateş elementlerinden hangisi olduklarını keşfedeceklerdir. Tabii deniz altında onları bekleyen tek şey ne yazık ki bu değildir. Bu kadar güzelliğin içinde her zaman sorun yaratan ve kötülük çıkartan birileri vardır. Bu durumda ise deniz kızları devreye girecekler. Deniz kızları Pacifica’yı savunmayı başarabilecekler mi? Görünen o ki deniz altı dünyasını korumak sadece onların elinde.\n<br>Animasyon türündeki yapımı ailecek izleyebilirsiniz. <strong>Barbie: Mermaid Power</strong> filmi özellikle çocuklar için orijinal dili İngilizce olmasına rağmen, Türkçe dublaj seçeneği ile hazırlanmıştır. 1 Eylül 2022 tarihine izleyici ile buluşan yapım 1 saat 5 dakika uzunluğundadır. Sizleri bambaşka bir dünyaya çıkaracak olan yapımın IMDB puanı ise 6.2’dir.<span class=\"Apple-converted-space\">&nbsp;</span> <br>4k formatlı animasyonun seslendirmesinde yer alan isimler arasında Joshua Blumhagen, Johnny Yong Bosch, Julia Bose, Hannah Cam, Tiana Camacho, Abbygale Chung gibi isimler ve çok daha fazlası yer almaktadır. Filmin yönetmeni ise Ron Myrick’tir.</p>",
                    ImageUrl = "3.jpg",
                    CategoryId = 2
                },
                new Movie() {
                    Id = 4,
                    Name = "School Good",
                    ShortDescription = "Fantezi film",
                    Description = "<p>Sophie ile Agatha uzun zamandır birbirlerinden ayrılmayan iki yakın dostturlar. Gavaldon köyünün sıkıcı hayatını yaşayan Sophie ile Agatha iki yakın dost olmalarının yanında bu köyden ayrılmayı da isteyen iki özel yeteneklere sahip genç cadılardır. Günlerden bir gün ay kırmızı rengi aldığında ve cadılar okuluna gitme zamanları geldiğinde hayatları sonsuza dek değişecektir.<span class=\"Apple-converted-space\">&nbsp;</span> <br>Sophie altın rengi saçlara sahip olan ve tek hayali prenses olmak olan bir terzidir. Agatha ise soyundan gelen cadı kanı ile doğmuştur ve tamamen karanlık büyüyü takip etmeyi istemektedir. Ay kızıl tonunu aldığında ise Sophie ile Agatha bir anda kendilerini bir anda İyilik ve Kötülük Okulunda bulan Sophie ile Agatha için okul korkunç bir yanlış yapmıştır. Çünkü bu okulda iki farklı bölüm vardır. Bu bölümlerden biri İyilik diğeri ise Kötülük sınıfıdır. Sophie iyilik sınıfına gitmesi gerekirken kötülük sınıfına, Agatha ise kötülük sınıfına gitmesi gerekirken iyilik sınıfına alındığında işler bir anda değişmeye başlar. Sophie ile Agatha ait oldukları sınıfların yanlış olduğunu hemen anlasalar da okul yönetimi henüz bunu kabul etmeyi reddetmektedir. Ancak olaylar sadece bununla da sınırlı değildir. Çünkü Rafal adında kötü bir büyücünün Sophie ile geçmişten gelen gizemli bir bağlantısı vardır ve sadece Sophie’yi değil tüm dünyayı tehdit etmek üzeredir.<span class=\"Apple-converted-space\">&nbsp;</span> <br>Sitemiz üzerinden 4k film formatı ve de Türkçe dublajı ile izleyeceğiniz <strong>The School for Good and Evil </strong>isimli filmde Paul Feig hem yönetmen koltuğundaki hem de David Magee ile birlikte senarist köşesindeki isimdir. Soman Chainani’nin kitabından beyaz perdeye uyarlanan filmde Kit Young ile Sophia Anne Caruso başrol oyuncu kadrosunda bizzat bulunurken, Cate Blanchett ise filmin seslendirmen kadrosunda yer alan isimdir. Sophie ile Agatha ikilisini bu tuhaf okulda ne tür maceralar beklemektedir? Geçmişten gelen Rafal tam olarak ne istemektedir?<span class=\"Apple-converted-space\">&nbsp;</span></p>",
                    ImageUrl = "4.jpg",
                    CategoryId = 3
                },
                new Movie() {
                    Id = 5,
                    Name = "Super Sons",
                    ShortDescription = "Animasyon film",
                    Description = "<p><strong>Batman and Superman: Battle of the Super Sons </strong>isimli bu eğlenceli animasyon filmi Jonathan Kent ile isteksiz yardımcısı olan Damian Wayne’in dünyayı yaklaşmakta olan bir felaketten kurtarmak için daha da ötesi babalarını kurtarmak için bir araya gelmelerini ve bu süreçte yaşanan olayları anlatmaktadır. Süper kahraman olarak doğan bu çocukların hikayesinin anlatıldığı animasyonda Matt Peters yönetmen koltuğunda yer alırken, Jeremy Adams ise animasyonun senaryo bölümünde yer almaktadır. Jonathan ile Damian ikilisinin hikayelerinin anlatıldığı filmde Jack Dylan Grazer ile Jack Griffo ve de Laura Bailey isimleri de animasyonun seslendirme kısmında yer alan sanatçılardır.<span class=\"Apple-converted-space\">&nbsp;</span> <br>Sitemiz üzerinden hem Türkçe dublajı ile hem de 4k film formatıyla izleyeceğiniz animasyonda Jonathan Kent sonunda süper güçlere sahip bir çocuk olduğunun farkına varmıştır. Tam da bu sırada Jonathan kendi yerini keşfetmek zorunda kalır. Çünkü Jonathan aslında kim olduğunu anladığı sırada Starro adındaki uzaylı bir kötü güç ile savaşmakta olan süper kahramanlarla karşılaşmıştır. Bu yeni ve Jonathan için tuhaf olan olaylar zincirinde Wonder Boy-Wonder Damian Wayne ile dost olan Kent bu dostluğu istese de istemese de sürdürmek zorundadır çünkü ikilinin babaları kaçırılmış ve dünya da yok olma tehlikesi ile karşı karşıya gelmiştir. Artık Kent ne olursa olsun kim olduğunu kabul etmeli, Damian ile tam bir takım çalışmasında bulunmalı ve dünya için iyi olan tarafta da yerini almalıdır. Kent ile Damian’ın babaları neden ve kim tarafından kaçırılmıştır? Bu iki genç süper kahraman hem babalarını hem de dünyayı kurtarmayı başarabilecekler midir? Starro denen bu uzaylı dünya gezegeninden ne istemektedir? Dünyaya yapılan saldırının altında süper oğulların babaları ile olan ve geçmişten gelen bir intikam söz konusu mudur? Kent yaşadığı tüm bu hızlı değişime ayak uydurmayı nasıl başaracaktır?<span class=\"Apple-converted-space\">&nbsp;</span></p>",
                    ImageUrl = "5.jpg",
                    CategoryId = 3
                }
            };
        }
        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id);
        }
    }
}

