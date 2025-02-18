
void SendMassag<T>(T message) where T : Message
{
    Console.WriteLine("Отправляется сообщение:"+message.Text);
}
SendMassag(new Message("Say hello"));
SendMassag(new EmailMessag("Say hello, mail"));
SendMassag(new SmsMessag("Say hello, sms"));
Massanger<Message> telegram = new Massanger<Message>();

IntMessanger<int> intMessanger = new IntMessanger<int>();
RefMessanger<string> refMessanger = new RefMessanger<string>();
PersonMassanger<Person> person = new PersonMassanger<Person>();

Instantion<string> instantionStr = new Instantion<string>();
Instantion<int> instantionInt = new Instantion<int>();
class Message
{
    public string? Text { get; }
    public Message(string? text)
    {
        Text = text;
    }   
}

class EmailMessag : Message
{
    public EmailMessag(string? text) : base(text)
    {
    }

}
class SmsMessag : Message
{
    public SmsMessag(string? text) : base(text)
    {
    }
}
class Massanger<T> where T : Message
{
    public void SendMassager(T message)
    {
        Console.WriteLine("Отправляется сообщение:" + message.Text);
    }
}

class IntMessanger<T> where T: struct {}
class RefMessanger<T> where T : class {}
class PersonMassanger<T> where T: new() {}

class Person
{
    private string? name;

    public Person()
    {
    }
}

class Instantion<T>
{
    public T instance;

    public Instantion()
    {
        instance = default(T);
    }
}