using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    internal class HospitalQueue
    {
        public string Name { get; set; }
        public string Sickness { get; set; }
        public string medicine { get; set; }

        public static void HospitalPatient(Queue<HospitalQueue> patient)
        {
            Console.WriteLine($"Total patients in Queue: {patient.Count}");

            while (patient.Count > 0)
            {
                HospitalQueue currentPatient = patient.Dequeue();

                Console.WriteLine($"\nServing: {currentPatient.Name}");
                Console.WriteLine($"{currentPatient.Name} has been attended to.");
                Console.WriteLine($"{currentPatient.medicine} has been prescribed to cure {currentPatient.Sickness}.");

                Console.WriteLine($"\nRemaining Patients in Queue: {patient.Count}");
            }

            Console.WriteLine("\nAll patients have been attended to.");
        }
    }
}
