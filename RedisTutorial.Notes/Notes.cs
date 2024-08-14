using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisTutorial.Notes;

internal class Notes
{
    /*
     * Redis CLI çalıştırmak için;
     *      docker exec -it <containerId> redis-cli
     *      docker exec -it <containerId> redis-cli --raw
     *      docker exec -it 39e574e4af72b5da7f299ae58dd05c6a1a3395f9931b5ca865229a620dd37c3c redis-cli --raw
     */

    // Container'a bağlanıldığında rediste Türkçe karakterleri desteklemiyor
    // bunun için redis'e cli'a bağlanırken bir "--raw" keyword'unu kullanmamız
    // gerekir.

    /*
     * Distrubuted Caching için birçok farklı yapı mevcuttur.
     * 
     *      ->  Redis: Remote Dictionary Service open source olan ve bellekte veriyapılarını yüksek performanslı bir şekilde 
     *      cache'lemek için kullanılan bir veritabanıdır. Caching işlemklerinin yanında message broker olarak da kullanılabilmektedir.
     *      Yapısal olarak key-value veri modellerinde çalışmaktadır ve NoSQL veritabanıdır.
     *      
     *      ->  Memcached: 
     *      Opensource, key-value veri modelinde caching yazılımıdır.
     *      
     *      ->  Hazelcast:
     *      Opensource, key-value veri modelinde caching işlemleri yapan Java tabanlı bir yazılımdır.
     *      
     *      ->  Apache Ignite:
     *      Opensource, key-value veri modelinde caching yazılımıdır.
     *      
     *      ->  EHCache:
     *      Opensource, key-value veri modelinde caching işlemleri yapan Java tabanlı bir yazılımdır.
     */



    /*      Redis veri türü açısından oldukça zengin bir veritabanıdır.
     *      
     *      String : Redis'in en temel ve basit veri türüdür. Metinsel değerlerle birlikte her türlü veriyi saklayabilmek için kullanılır.
     *      Hatta binary olarak resim, dosya vb. belgelerde saklanabilir.
     *      
     *      List : Değerleri koleksiyonel olarak tutan bir türdür.
     *      
     *      Set : VErileri rastgele bir düzende unique bir biçimde tutan veri türüdür.
     *      
     *      Sorted Set: Set'in düzenli bir şekilde tutulan versiyonudur.
     *      
     *      Hash : Key-Value formatlarında veri tutan türdür.
     *      
     *      Streams : Log gibi hareket eden bir veri türüdür. Streams, event'lerin oluşturdukları sırayla kaydedilmelerini 
     *      ve daha sonra işlenmelerini sağlar.
     *      
     *      Geospital Indexes : Coğrafi kordinatların saklanmasını sağlayan veri türüdür.
     *      
     */


    /*  ---- String ----
     * Set : Ekleme
     * Get : Okuma 
     * Getrange : Karakter aralığı okuma
     * Incr & Incrby : Arttırma
     * Decr & Decrby : Azaltma
     * Append : Üzerine Ekleme
     */


    /*  ---- List ----
     * LPush : Başa veri ekleme 
     * LRange : Verileri Listeleme
     * RPush : Sona veri ekleme
     * LPOP : İlk datayı çağırma
     * RPOP : Son datayı çağırma
     * LINDEX : Indexe göre datayı getirme
     */

    /*  ---- Set ----
     * SADD : Ekleme 
     * SREM : Silme
     * SISMEMBER : Arama
     * SINTER : İki Set'teki Kesişimi Yakalama
     * SCARD : Elaman Sayısını Getirir
     */

    /*  ---- Sorted Set ----
     * Birbirinden farklı değerleri sıralı bir şekilde ve unique olarak tutan bir 
     * veri türüdür. Her veriye score adı verilen değer atanır ve bu değerler
     * kullanılarak veriler sıralanır.
     * 
     * ZADD : Ekleme
     * ZRANGE : Getirme
     * ZREM : Silme
     * ZREVRANK : Sıralama / Öğrenme
     */

    /*  ---- Hash ----
     *  HMSET & HSET : Ekleme
     *  HMGET & HGET : Getirme
     *  HDEL : Silme
     *  HGETALL : Tümünü Getirme
     */
}
