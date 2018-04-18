using System;
using System.Collections.Generic;

namespace GenomicRangeQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().solution("CAGCCTA", new int[] { 2, 5, 0 }, new int[] { 4, 5, 6 }));
        }
    }

    class Dna
    {
        public Dna()
        {
        }

        public Dna(int acounter, int ccounter, int gcounter, int tcounter)
        {
            this.ACounter = acounter;
            this.CCounter = ccounter;
            this.GCounter = gcounter;
            this.TCounter = tcounter;
        }

        public int ACounter { get; set; }

        public int GCounter { get; set; }

        public int CCounter { get; set; }

        public int TCounter { get; set; }
    }

    class Solution
    {
        public int[] solution(string S, int[] P, int[] Q)
        {
            var n = S.Length;
            var m = P.Length;

            var impact = new Dictionary<char, int>()
            {
                { 'A', 1 },
                { 'C', 2 },
                { 'G', 3 },
                { 'T', 4 }
            };

            var currCounter = new Dictionary<char, int>()
            {
                { 'A', 0 },
                { 'C', 0 },
                { 'G', 0 },
                { 'T', 0 }
            };

            var counters = new List<Dna>();
            var minImpact = new List<int>();

            for (int i = 0; i <= n; i++)
            {
                Dna dna = new Dna();

                dna.ACounter = currCounter['A'];
                dna.CCounter = currCounter['C'];
                dna.GCounter = currCounter['G'];
                dna.TCounter = currCounter['T'];

                counters.Add(dna);

                if(i != n)
                {
                    currCounter[S[i]]++;
                }
            }

            for (int i = 0; i < m; i++)
            {
                var from = P[i];
                var to = Q[i] + 1;

                if(counters[to].ACounter - counters[from].ACounter > 0)
                {
                    minImpact.Add(impact['A']);
                }
                else if (counters[to].CCounter - counters[from].CCounter > 0)
                {
                    minImpact.Add(impact['C']);
                }
                else if(counters[to].GCounter - counters[from].GCounter > 0)
                {
                    minImpact.Add(impact['G']);
                }
                else
                {
                    minImpact.Add(impact['T']);
                }
            }

            return minImpact.ToArray();
        }
    }
}
