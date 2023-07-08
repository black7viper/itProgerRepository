namespace Learn
{
    //на примере этих классов
    class Message
    {
        public string Text { get; set; }
        public Message(string text) => Text = text;
    }
    class EmailMessage : Message
    {
        public EmailMessage(string text) : base(text) { }
    }

    //Ковариантность:       позволяет использовать более конкретный тип, чем заданный изначально
    //Контравариантность:   позволяет использовать более универсальный тип, чем заданный изначально
    //Инвариантность:       позволяет использовать только заданный тип

    //Ковариантность
    interface IMessengerOut<out T>
    {
        public T WriteMessage(string text);
    }
    class EmailMessenger : IMessengerOut<EmailMessage>
    {
        public EmailMessage WriteMessage(string text)
        {
            return new EmailMessage($"Email: {text}");
        }
    }

    //Контрвариантность
    interface IMessengerIn<in T>
    {
        void SendMessage(T message);
    }
    class SimpleMessenger : IMessengerIn<Message>
    {
        public void SendMessage(Message message)
        {
            Console.WriteLine($"Отправляется сообщение: {message.Text}");
        }
    }

    //главный класс
    internal class Interfaces
    {
        public static void Main()
        {

            // IExample example = new ExampleImplementation(); 
            // Мы используем интерфейс IExample в качестве типа переменной example, чтобы создать экземпляр класса ExampleImplementation. 
            // Это делается с целью абстрагирования и использования полиморфизма.
            // Когда мы создаем экземпляр класса ExampleImplementation и присваиваем его переменной типа IExample, 
            // мы говорим, что переменная example может ссылаться на любой объект, который реализует интерфейс IExample. 
            // Это позволяет нам работать с объектом через интерфейс, не завися от конкретной реализации.      

            //Ковариантность
            IMessengerOut<Message> outlookOut = new EmailMessenger();
            Message message = outlookOut.WriteMessage("Hello World");
            Console.WriteLine(message.Text);    // Email: Hello World

            //Мы можем присвоить более общему типу IMessenger<Message> объект более конкретного 
            //типа EmailMessenger или IMessenger<EmailMessage>
            IMessengerOut<EmailMessage> emailClientOut = new EmailMessenger();
            IMessengerOut<Message> messenger = emailClientOut;
            Message emailMessage = messenger.WriteMessage("Hi!");
            Console.WriteLine(emailMessage.Text);    // Email: Hi!

            //Контравариантность
            IMessengerIn<EmailMessage> outlookIn = new SimpleMessenger();
            outlookIn.SendMessage(new EmailMessage("Hi!"));

            IMessengerIn<Message> telegram = new SimpleMessenger();
            IMessengerIn<EmailMessage> emailClientIn = telegram;
            emailClientIn.SendMessage(new EmailMessage("Hello"));
        }
    }
}