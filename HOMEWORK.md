### Uyga Vaifa 

## Решение
У всех реализаций Singleton есть два общих шага:

`Сделать конструктор по умолчанию приватным, чтобы предотвратить создание экземпляров класса с помощью оператора new.`
`Создать статический метод создания, который действует как конструктор. Под капотом этот метод вызывает приватный конструктор для создания объекта и сохраняет его в статическом поле. Все последующие вызовы этого метода возвращают кэшированный объект.`
`Если вашему коду доступен класс Singleton, то он может вызвать статический метод Singleton. Поэтому каждый раз, когда вызывается этот метод, возвращается один и тот же объект.`

# -----------

Bu yerda Singleton haqida bir oz aytib otilgan. Albatta bu - new ishlatmagan holda siz constructor ishlatib newni oldini olishingizga yordam beradi.
va singleton ekanligini alomati bu har safar default holatda `constructor` private holatda boladi.
static korinishida ochilgan ushbu `constructor` qayerda ishlatish mumkin bolsa static holatda siz yanga olingan obyektni ishlatishingiz mumkin va u har safar `возвращается один и тот же объект` bir xil obyekt qaytaradi.

## Pseudocode


В этом примере класс подключения к базе данных выступает в качестве `Singleton`. У этого класса нет открытого конструктора, поэтому единственный способ получить его объект - вызвать метод `getInstance`. Этот метод кеширует первый созданный объект и возвращает его во всех последующих вызовах.


```csharp
// The Database class defines the `getInstance` method that lets
// clients access the same instance of a database connection
// throughout the program.
class Database is
    // The field for storing the singleton instance should be
    // declared static.
    private static field instance: Database

    // The singleton's constructor should always be private to
    // prevent direct construction calls with the `new`
    // operator.
    private constructor Database() is
        // Some initialization code, such as the actual
        // connection to a database server.
        // ...

    // The static method that controls access to the singleton
    // instance.
    public static method getInstance() is
        if (Database.instance == null) then
            acquireThreadLock() and then
                // Ensure that the instance hasn't yet been
                // initialized by another thread while this one
                // has been waiting for the lock's release.
                if (Database.instance == null) then
                    Database.instance = new Database()
        return Database.instance

    // Finally, any singleton should define some business logic
    // which can be executed on its instance.
    public method query(sql) is
        // For instance, all database queries of an app go
        // through this method. Therefore, you can place
        // throttling or caching logic here.
        // ...

class Application is
    method main() is
        Database foo = Database.getInstance()
        foo.query("SELECT ...")
        // ...
        Database bar = Database.getInstance()
        bar.query("SELECT ...")
        // The variable `bar` will contain the same object as
        // the variable `foo`.
```

## -----------

## Keyingi savol


Запечатанные классы используются для ограничения возможности наследования в объектно-ориентированном программировании. Как только класс определен как запечатанный `sealed`, этот класс не может быть унаследован. В `C#` модификатор `sealed` используется для объявления класса как запечатанного. В `Visual Basic` `.NET` для этой цели служит ключевое слово `NotInheritable`.

# -----------


`Sealed` bu `class` ni inherit qobilyatlarini cheklash uchun ishlatiladi. Qisqa qilib aytganda `ограничения возможности наследования` mana shunday.


## -----------

\# hello