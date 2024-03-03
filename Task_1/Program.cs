//Задание 1 Создайте приложение, использующее класс Task.
//Приложение должно отображать текущее время и дату. Запустите задачу три способами: 
//■ Через метод Start класса Task; 
//■ Через метод Task.Factory.StartNew; 
//■ Через метод Task.Run 

//Задание 2 Напишите асинхронный метод для отображения текущего времени и даты.
//(async) Метод не должен блокировать основной поток

namespace Task_1
{
    internal class Program
    {
        class MyClass
        {
            public void CurrentTime() => Console.Write($"\n\tCurrent date & time: {DateTime.Now.ToString()}\n");

            public async void CurrentTimeStartTaskAssync()
            {
                Console.Write("Method Task.Start is in use: ");
                Task task = new Task(CurrentTime);
                task.Start();
                await task;
                Console.WriteLine("End of Metod Task.Start");
            }

            public async void CurrentTimeTaskFactoryAssync()
            {
                Console.Write("Method Task.Factory is in use: ");
                await Task.Factory.StartNew(CurrentTime);
                Console.WriteLine("End of Metod Task.Factory");
            }

            public async void CurrentTimeTaskRunAssync()
            {
                Console.Write("Method Task.Run is in use: ");
                await Task.Run(CurrentTime);
                Console.WriteLine("End of Metod Task.Run");
            }
        }
        

        static void Main(string[] args)
        {
           MyClass my = new MyClass();
            //my.CurrentTime();
            Console.WriteLine("\n\n");
            my.CurrentTimeStartTaskAssync();
            Console.WriteLine("\n\n");
            my.CurrentTimeTaskFactoryAssync();
            Console.WriteLine("\n\n");
            my.CurrentTimeTaskRunAssync();
            Console.WriteLine("\n\n");
            Console.ReadKey();
        }
    }
}
