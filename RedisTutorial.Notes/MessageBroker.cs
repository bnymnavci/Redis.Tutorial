namespace RedisTutorial.Notes;

internal class MessageBroker
{
    /*
     * Redis Pattern-Matching Subscription modeli sayesinde abonelerin belirli kalıplarda(pattern) ya da desenlerde mesajlar almasını sağlayabilmektedir.
     * Bu abonelerin birden fazla pattern'lara sahip olan kanaldan mesajlar almasını yahut belirli bir kalıba uyan kanalları filtremesini mümkün kılar.
     * Misal olarak bir abonenin sadece 'stock.*' pattern'ine uygun olan kanallardan mesaj almasını isterseniz; 'stock.apple', 'stock.google' ve 'stock.amazon' 
     * gibi kanallardan mesajları alabilir ancak 'news.tech' isimli kanaldan ise doğal olarak mesajlardan filtrelemiş olursun.
     * 
     * 
     * 
     * 
     */
}
