using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketSort
{
    internal class AccountSorter
    {
        public static class AccountsSorter
        {
            // Sort method for arrays
            public static void Sort(Account[] accounts, int b)
            {
                // Implementation using Bucket Sort algorithm
                List<List<Account>> buckets = new List<List<Account>>(b);
                decimal M = CalculateMaxValue(accounts);

                // Initialize buckets
                for (int i = 0; i < b; i++)
                {
                    buckets.Add(new List<Account>());
                }

                // Insert elements into buckets
                foreach (var acc in accounts)
                {
                    int bucketIndex = (int)Math.Floor(b * acc.Balance / M);

                    // Ensure the bucketindex is within the valid range
                    if (bucketIndex >= b)
                    {
                        bucketIndex = b - 1; 
                    }

                    buckets[bucketIndex].Add(acc);
                }

                // Sort each bucket
                foreach (var bucket in buckets)
                {
                    nextSort(bucket);
                }

                // Concatenate buckets
                List<Account> result = new List<Account>();
                foreach (var bucket in buckets)
                {
                    result.AddRange(bucket);
                }

                // Copy sorted elements back to the original array
                for (int i = 0; i < result.Count; i++)
                {
                    accounts[i] = result[i];
                }
            }

            // Sort method for List<Account>
            public static void Sort(List<Account> accounts, int b)
            {
                // Implementation using Bucket Sort algorithm
                List<List<Account>> buckets = new List<List<Account>>(b);
                decimal M = CalculateMaxValue(accounts);

                // Initialize buckets
                for (int i = 0; i < b; i++)
                {
                    buckets.Add(new List<Account>());
                }

                // Insert elements into buckets
                foreach (var acc in accounts)
                {
                    int bucketIndex = (int)Math.Floor(b * acc.Balance / M);

                    // Ensure the bucketindex is within the valid range
                    if (bucketIndex >= b)
                    {
                        bucketIndex = b - 1;
                    }

                    buckets[bucketIndex].Add(acc);
                }

                // Sort each bucket
                foreach (var bucket in buckets)
                {
                    nextSort(bucket);
                }

                // Concatenate buckets
                accounts.Clear();
                foreach (var bucket in buckets)
                {
                    accounts.AddRange(bucket);
                }
            }

            // Helper method for nextSort (you can use native .NET sorting methods here)
            private static void nextSort(List<Account> bucket)
            {
                // Implementation of nextSort
                // You can use Array.Sort or List<T>.Sort here
                bucket.Sort((a1, a2) => a1.Balance.CompareTo(a2.Balance));
            }

            // Helper method to calculate the maximum key value
            private static decimal CalculateMaxValue(Account[] array)
            {
                decimal max = decimal.MinValue;
                foreach (var acc in array)
                {
                    if (acc.Balance > max)
                    {
                        max = acc.Balance;
                    }
                }
                return max;
            }

            // Helper method to calculate the maximum key value for List<Account>
            private static decimal CalculateMaxValue(List<Account> array)
            {
                decimal max = decimal.MinValue;
                foreach (var acc in array)
                {
                    if (acc.Balance > max)
                    {
                        max = acc.Balance;
                    }
                }
                return max;
            }


        }
    }
}
