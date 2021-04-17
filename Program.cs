using System;

namespace DNA_Replication
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDNA = Console.ReadLine();
            bool IsvalidSeq = IsvalidSequence(inputDNA);

            if (IsvalidSeq == true)
            {
                Console.Write("Current half DNA sequence : ");
                Console.WriteLine(inputDNA);
                Console.Write("Do you want to replicate it ? (Y/N) : ");
                string confirmReplicate = Console.ReadLine();

                if (confirmReplicate == "Y")
                {
                    string RepDNA = ReplicateSequence(inputDNA);
                    Console.Write("Replicated half DNA sequence : ");
                    Console.WriteLine(RepDNA);

                    Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");

                    string anotherProcess = Console.ReadLine();
                    if (anotherProcess == "Y")
                    {
                        process();
                    }
                    else if (anotherProcess == "N")
                    {

                    }
                    else
                    {
                        Console.WriteLine("Please input Y or N.");
                        Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
                        confirmProcess();
                    }

                }
                else if (confirmReplicate == "N")
                {
                    Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");

                    string anotherProcess = Console.ReadLine();
                    if (anotherProcess == "Y")
                    {
                        process();
                    }
                    else if (anotherProcess == "N")
                    {

                    }
                    else
                    {
                        Console.WriteLine("Please input Y or N.");
                        Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
                        confirmProcess();
                    }
                }
                else
                {
                    Console.WriteLine("Please input Y or N.");
                    confirmRep(inputDNA);
                }
            }else if (IsvalidSeq == false)
            {
                Console.WriteLine("That half DNA sequence is invalid.");
                Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");

                string anotherProcess = Console.ReadLine();
                if (anotherProcess == "Y")
                {
                    process();
                }else if (anotherProcess == "N")
                {
                    
                }
                else
                {
                    Console.WriteLine("Please input Y or N.");
                    Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
                    confirmProcess();
                }

            }
        }
        static bool IsvalidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }
        static string ReplicateSequence(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TACG"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }
        static void process()
        {
            string inputDNA = Console.ReadLine();
            bool IsvalidSeq = IsvalidSequence(inputDNA);

            if (IsvalidSeq == true)
            {
                Console.Write("Current half DNA sequence : ");
                Console.WriteLine(inputDNA);
                Console.Write("Do you want to replicate it ? (Y/N) : ");
                string confirmReplicate = Console.ReadLine();

                if (confirmReplicate == "Y")
                {
                    string RepDNA = ReplicateSequence(inputDNA);
                    Console.Write("Replicated half DNA sequence : ");
                    Console.WriteLine(RepDNA);

                    Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");

                    string anotherProcess = Console.ReadLine();
                    if (anotherProcess == "Y")
                    {
                        process();
                    }
                    else if (anotherProcess == "N")
                    {

                    }
                    else
                    {
                        Console.WriteLine("Please input Y or N.");
                        Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
                        confirmProcess();
                    }

                }
                else if (confirmReplicate == "N")
                {
                    Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");

                    string anotherProcess = Console.ReadLine();
                    if (anotherProcess == "Y")
                    {
                        process();
                    }
                    else if (anotherProcess == "N")
                    {

                    }
                    else
                    {
                        Console.WriteLine("Please input Y or N.");
                        Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
                        confirmProcess();
                    }
                }
                else
                {
                    Console.WriteLine("Please input Y or N.");
                    Console.Write("Do you want to replicate it ? (Y/N) : ");
                    confirmRep(inputDNA);
                }
            }
            else if (IsvalidSeq == false)
            {
                Console.WriteLine("That half DNA sequence is invalid.");
                Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");

                string anotherProcess = Console.ReadLine();
                if (anotherProcess == "Y")
                {
                    process();
                }
                else if (anotherProcess == "N")
                {

                }
                else
                {
                    Console.WriteLine("Please input Y or N.");
                    Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
                    confirmProcess();
                }

            }
        }
        static void confirmRep(string inputDNA)
        {
            string confirmReplicate = Console.ReadLine();
            if (confirmReplicate == "Y")
            {
                string RepDNA = ReplicateSequence(inputDNA);
                Console.Write("Replicated half DNA sequence : ");
                Console.WriteLine(RepDNA);
            }
            else if (confirmReplicate == "N")
            {
                Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");

                string anotherProcess = Console.ReadLine();
                if (anotherProcess == "Y")
                {
                    process();
                }
                else if (anotherProcess == "N")
                {

                }
                else
                {
                    Console.WriteLine("Please input Y or N.");
                    Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
                    confirmProcess();
                }
            }
            else
            {
                Console.WriteLine("Please input Y or N.");
                Console.Write("Do you want to replicate it ? (Y/N) : ");
                confirmRep(inputDNA);
            }
        }
        static void confirmProcess()
        {
            string anotherProcess = Console.ReadLine();
            if (anotherProcess == "Y")
            {
                process();
            }
            else if (anotherProcess == "N")
            {

            }
            else
            {
                Console.WriteLine("Please input Y or N.");
                confirmProcess();
            }
        }
    }
}
