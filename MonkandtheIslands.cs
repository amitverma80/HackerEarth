using System;
using System.Collections.Generic;
 
namespace HackerEarth
{
    class Node
    {
        public int Vertex { get; set; }
 
        public List<int> Next { get; set; }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
 
 
            for (int t = 0; t < T; t++)
            {
                string str = Console.ReadLine();
 
                int N = Convert.ToInt32(str.Split(" ")[0]);
                int M = Convert.ToInt32(str.Split(" ")[1]);
 
                List<Node> node = new List<Node>(N + 1);
 
                for (int i = 0; i <= N; i++)
                {
                    node.Add(new Node() { Vertex = i, Next = new List<int>() });
                }
 
                for (int i = 0; i < M; i++)
                {
                    str = Console.ReadLine();
                    int a = Convert.ToInt32(str.Split(" ")[0]);
                    int b = Convert.ToInt32(str.Split(" ")[1]);
 
                    node[a].Next.Add(b);
                    node[b].Next.Add(a);
                }
 
                bfs(node, 1, N);
            }
        }
 
        private static void bfs(List<Node> node, int sourceNode, int N)
        {
            System.Collections.Queue q = new System.Collections.Queue(N);
            q.Enqueue(sourceNode);
            int[] visited = new int[N + 1];
            int[] levelFromSource = new int[N + 1];
 
            int level = 0;
            visited[sourceNode] = 1;
            levelFromSource[sourceNode] = level;
 
            while (q.Count != 0)
            {
                //Dequeue the element
                int n = Convert.ToInt32(q.Dequeue());// Remove first element
 
                //get all node associated with this node which are not visisted yet
                var childNodes = node[n];
                level = levelFromSource[n]+1;
 
                for (int i = 0; i < childNodes.Next.Count; i++)
                {
                    if (visited[childNodes.Next[i]] != 1)// if not visited yet
                    {
                        q.Enqueue(childNodes.Next[i]);
                        visited[childNodes.Next[i]] = 1;
                        levelFromSource[childNodes.Next[i]] =level;
                    }
                }
            }
            Console.WriteLine(levelFromSource[N]);
        }
    }
}
