﻿// запускаем пять потоков
for (int i = 1; i < 6; i++)
{
    Reader reader = new Reader(i);
}
class Reader
{
    // создаем семафор
    static Semaphore sem = new Semaphore(3, 3);
    Thread myThread;
    int count = 3;// счетчик чтения

    public Reader(int i)
    {
        myThread = new Thread(Read);
        myThread.Name = $"Читатель {i}";
        myThread.Start();
    }

    public void Read()
    {
        while (count > 0)
        {
            sem.WaitOne();  // ожидаем, когда освободиться место

            Console.WriteLine($"{Thread.CurrentThread.Name} входит в шаурмечную");

            Console.WriteLine($"{Thread.CurrentThread.Name} кушает кебаб");
            Thread.Sleep(1000);

            Console.WriteLine($"{Thread.CurrentThread.Name} покидает шаурмечную");

            sem.Release();  // освобождаем место

            count--;
            Thread.Sleep(1000);
        }
    }
}