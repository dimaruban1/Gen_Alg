using Genetic_Algorithm.DAL;

namespace Genetic_Algorithm
{
    internal class Program
    {
        static void Main()
        {
            var data = new Data();
            data.CreateRandomPopulation(20);
            var geneticAlg = new GeneticAlg(data, eliteSchedules: 3, tournamentSelectionSize:9, mutationRate: 0.5);
            var goodSchedule = geneticAlg.FindSolution();
            ScheduleWriter.Write(goodSchedule);
        }
    }
}