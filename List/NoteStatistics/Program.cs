using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, string> frequencyOfNotes = new Dictionary<double, string>();
            {
                frequencyOfNotes[261.63] = "C";
                frequencyOfNotes[277.18] = "C#";
                frequencyOfNotes[293.66] = "D";
                frequencyOfNotes[311.13] = "D#";
                frequencyOfNotes[329.63] = "E";
                frequencyOfNotes[349.23] = "F";
                frequencyOfNotes[369.99] = "F#";
                frequencyOfNotes[392.00] = "G";
                frequencyOfNotes[415.30] = "G#";
                frequencyOfNotes[440.00] = "A";
                frequencyOfNotes[466.16] = "A#";
                frequencyOfNotes[493.88] = "B";
            }

            List<double> inputFrequency = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            List<string> notes = new List<string>();
            List<string> naturalNotes = new List<string>();
            List<string> sharpedNotes = new List<string>();
            double naturalNotesSum = 0;
            double sharpedNotesSum = 0;

            foreach (var frequency in inputFrequency)
            {
                string note = frequencyOfNotes[frequency];

                notes.Add(note);

                if (note.Length == 1)
                {
                    naturalNotes.Add(note);
                    naturalNotesSum += frequency;
                }
                else
                {
                    sharpedNotes.Add(note);
                    sharpedNotesSum += frequency;
                }
            }

            Console.WriteLine("Notes: " + string.Join(" ", notes));
            Console.WriteLine("Naturals: " + string.Join(", ", naturalNotes));
            Console.WriteLine("Sharps: " + string.Join(", ", sharpedNotes));
            Console.WriteLine($"Naturals sum: {naturalNotesSum}");
            Console.WriteLine($"Sharps sum: {sharpedNotesSum}");

        }
    }
}
