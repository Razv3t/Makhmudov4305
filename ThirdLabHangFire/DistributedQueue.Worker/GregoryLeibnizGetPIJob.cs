using System;
using System.Threading;
using System.Threading.Tasks;

namespace DistributedQueue.Common
{
    internal class GregoryLeibnizGetPIJob : IComputePiJob
    {
        public Task ComputePyAsync(string name, int iterrations, CancellationToken token)
        {

            var startTime = DateTime.Now;

            var iterrationsToCheck = 1000000;
            var iterrationCurrent = 0;
            string[] strings = {
                    "Кебаб",
                    "Самса",
                    "Шаурма",
                    "Закрытая пицца",
                    "Мужчин",
                    "Хинкал",
                    "Снюс",
                    "Рамен",
                    "Шурпа",
                    "Детей"
                };
            for (int i = 0; i < iterrations; i++)
            {
                Console.WriteLine($"{DateTime.Now}: Compute task: {name} Он думает, что шовкет любит -> {strings[i%10]}");
                Thread.Sleep(1000);
            }


            Console.WriteLine($"Nane potoka: {name}, Iterrations: {iterrations}");

            return Task.CompletedTask;
        }
    }
}
